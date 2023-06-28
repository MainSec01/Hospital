using Hospital.Data.IRepsitory;
using Hospital.Servise.DTOs.HealthyFoodDtos;
using Hospital.Servise.Servises;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthyFoodsController : ControllerBase
    {
        IHealthyFoodServise healthyFoodServise;

        public HealthyFoodsController(IHealthyFoodServise healthyFoodServise)
        {
            this.healthyFoodServise = healthyFoodServise;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(HealthyFoodAddDto healthyFoodAddDto)
        {
            if (healthyFoodAddDto is not null)
            {
                await healthyFoodServise.AddAsync(healthyFoodAddDto);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await healthyFoodServise.GetAllAsync());
        }
    }
}
