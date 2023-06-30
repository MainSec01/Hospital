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
        private readonly IDiseaseCauseServise diseaseCauseServise;

        public DiseaseCausesController(IDiseaseCauseServise diseaseCauseServise)
        {
            this.diseaseCauseServise = diseaseCauseServise;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(DiseaseCauseAddDto diseaseCauseAddDto)
        {
            if (diseaseCauseAddDto != null)
            {
                await diseaseCauseServise.AddAsync(diseaseCauseAddDto);
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var diseaseCauses = await diseaseCauseServise.GetAllAsync();
            return Ok(diseaseCauses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, DiseaseCauseAddDto diseaseCauseAddDto)
        {
            await diseaseCauseServise.UpdateAsync(id, diseaseCauseAddDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            await diseaseCauseServise.DeleteAsync(id);
            return Ok();
        }
    }

}
