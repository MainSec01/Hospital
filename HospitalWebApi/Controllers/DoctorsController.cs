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
        private readonly IDoctorServise servise;

        public DoctorsController(IDoctorServise servise)
        {
            this.servise = servise;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(DoctorAddDto doctorAddDto)
        {
            if (doctorAddDto is not null)
            {
                await servise.AddAsync(doctorAddDto);
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await servise.GetAllAsync());
        }
    }
}
