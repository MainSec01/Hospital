using Hospital.Data.IRepsitory;
using Hospital.Servise.DTOs.DiseaseCauseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiseaseCausesController : ControllerBase
    {
        IDiseaseCauseServise diseaseCauseServise;

        public DiseaseCausesController(IDiseaseCauseServise diseaseCauseServise)
        {
            this.diseaseCauseServise = diseaseCauseServise;
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync(DiseaseCauseAddDto diseaseCauseAddDto)
        {
            if (diseaseCauseAddDto is not null)
            {
                await diseaseCauseServise.AddAsync(diseaseCauseAddDto);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await diseaseCauseServise.GetAllAsync());
        }
    }
}
