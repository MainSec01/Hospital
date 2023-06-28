using Hospital.Data.IRepsitory;
using Hospital.Servise.DTOs.SicknesseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SicknessesController : ControllerBase
    {
        ISicknessServise sicknessServise;

        public SicknessesController(ISicknessServise sicknessServise)
        {
            this.sicknessServise = sicknessServise;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(SicknesseAddDto sicknesseAddDto)
        {
            if (sicknesseAddDto is not null)
            {
                await sicknessServise.AddAsync(sicknesseAddDto);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await sicknessServise.GetAllAsync());
        }
    }
}
