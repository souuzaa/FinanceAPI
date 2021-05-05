using System;
using System.Threading.Tasks;
using Finance.ApiModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Profile.Api.Services;
using Profile.Api.Services.Factories;

namespace Profile.Api.Controllers
{
    [ApiController]
    [Route("api/v1/profile")]
    public class SaveProfileController : ControllerBase
    {
        private readonly ICreateProfileService _service;

        public SaveProfileController(IProfileServiceFactory factory)
        {
            _service = (ICreateProfileService)factory.Create();
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorsModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorsModel))]
        [Produces("application/json")]
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> CreateProfileAsync(int i)
        {
            return Ok(await _service.CreateProfileAsync(new Finance.ApiModels.Models.Profile()));
        }
    }
}
