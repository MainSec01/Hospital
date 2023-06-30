using Hospital.Data.IRepsitory;
using Hospital.Data.Repsitory;
using Hospital.Servise.DTOs.SymptomDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SymptomsController : ControllerBase
    {
        private readonly ISymptomServise symptomServise;

        public SymptomsController(ISymptomServise symptomServise)
        {
            this.symptomServise = symptomServise;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(SymptomAddDto symptomAddDto)
        {
            if (symptomAddDto is not null)
            {
                await symptomServise.AddAsync(symptomAddDto);
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var symptoms = await symptomServise.GetAllAsync();
            return Ok(symptoms);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, SymptomAddDto symptomAddDto)
        {
            await symptomServise.UpdateAsync(id, symptomAddDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            await symptomServise.DeleteAsync(id);
            return Ok();
        }
    }

}
