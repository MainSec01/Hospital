using Hospital.Data.IRepsitory;
using Hospital.Servise.DTOs.HospitalDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfirmarysController : ControllerBase
    {
        IInfirmaryServise infirmaryServise;

        public InfirmarysController(IInfirmaryServise infirmaryServise)
        {
            this.infirmaryServise = infirmaryServise;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(InfirmaryAddDto infirmaryAddDto)
        {
            if (infirmaryAddDto is not null)
            {
                await infirmaryServise.AddAsync(infirmaryAddDto);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await infirmaryServise.GetAllAsync());
        }
    }
}
