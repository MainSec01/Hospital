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
        private readonly ISicknessServise sicknessServise;

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
            var sicknesses = await sicknessServise.GetAllAsync();
            return Ok(sicknesses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, SicknesseAddDto sicknesseAddDto)
        {
            await sicknessServise.UpdateAsync(id, sicknesseAddDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            await sicknessServise.DeleteAsync(id);
            return Ok();
        }
    }

}
