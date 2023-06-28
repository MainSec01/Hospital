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
        IDoctorServise doctorServise;

        public DoctorsController(IDoctorServise doctorServise)
        {
            this.doctorServise = doctorServise;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(DoctorAddDto doctorAddDto)
        {
            if (doctorAddDto is not null)
            {
                await doctorServise.AddAsync(doctorAddDto);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await doctorServise.GetAllAsync());
        }
    }
}
