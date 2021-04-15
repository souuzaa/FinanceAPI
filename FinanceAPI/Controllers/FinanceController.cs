using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FinanceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FinanceController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "APPL", "MSFT", "AMZN", "FDX"
        };

        private static List<Profile> _listProfiles = new List<Profile>();

        private readonly ILogger<FinanceController> _logger;

        public FinanceController(ILogger<FinanceController> logger)
        {
            _logger = logger;
        }

        [HttpGet("watchlist")]
        public IEnumerable<Stock> GetList()
        {
            var rng = new Random();
            return Enumerable.Range(1, 4).Select(index => new Stock
            {
                Date = DateTime.Now.AddDays(index),
                LastPrice = (double)rng.Next(20, 55),
                Ticker = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //only for test
        [HttpGet("profiles")]
        public IEnumerable<Profile> GetAllProfile()
        {
            return _listProfiles;
        }

        [HttpGet("profile/{id}")]
        public Profile GetProfile(int id)
        {
            return _listProfiles.Where(u => u.ID.Equals(id)).FirstOrDefault();
        }

        [HttpGet("profile/{name}/{city}")]
        public bool AddProfile(string name, string city)
        {
            try
            {
                var item = new Profile()
                {
                    ID = _listProfiles.Count + 1,
                    Name = name,
                    City = city
                };

                _listProfiles.Add(item);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
            }

            return false;
        }
    }
}
