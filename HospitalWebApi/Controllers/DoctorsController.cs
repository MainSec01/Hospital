using Hospital.Data.IRepsitory;
using Hospital.Servise.DTOs.DoctorDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorServise doctorServise;

        public DoctorsController(IDoctorServise doctorServise)
        {
            this.doctorServise = doctorServise;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(DoctorAddDto doctorAddDto)
        {
            if (doctorAddDto != null)
            {
                await doctorServise.AddAsync(doctorAddDto);
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var doctors = await doctorServise.GetAllAsync();
            return Ok(doctors);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, DoctorAddDto doctorAddDto)
        {
            await doctorServise.UpdateAsync(id, doctorAddDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            await doctorServise.DeleteAsync(id);
            return Ok();
        }
    }

}
