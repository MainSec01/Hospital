using Hospital.Data.IRepsitory;
using Hospital.Servise.DTOs.TreatmentMethodDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentMethodsController : ControllerBase
    {
        private readonly ITreatmentMethodServise treatmentMethodServise;

        public TreatmentMethodsController(ITreatmentMethodServise treatmentMethodServise)
        {
            this.treatmentMethodServise = treatmentMethodServise;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(TreatmentMethodAddDto treatmentMethodAddDto)
        {
            if (treatmentMethodAddDto is not null)
            {
                await treatmentMethodServise.AddAsync(treatmentMethodAddDto);
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var treatmentMethods = await treatmentMethodServise.GetAllAsync();
            return Ok(treatmentMethods);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, TreatmentMethodAddDto treatmentMethodAddDto)
        {
            await treatmentMethodServise.UpdateAsync(id, treatmentMethodAddDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            await treatmentMethodServise.DeleteAsync(id);
            return Ok();
        }
    }

}
