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

        private readonly ILogger<FinanceController> _logger;

        public FinanceController(ILogger<FinanceController> logger)
        {
            _logger = logger;
        }

        [HttpGet("list")]
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
    }
}
