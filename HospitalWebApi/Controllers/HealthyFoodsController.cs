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
        private readonly IHealthyFoodServise healthyFoodServise;

        public HealthyFoodsController(IHealthyFoodServise healthyFoodServise)
        {
            this.healthyFoodServise = healthyFoodServise;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(HealthyFoodAddDto healthyFoodAddDto)
        {
            if (healthyFoodAddDto != null)
            {
                await healthyFoodServise.AddAsync(healthyFoodAddDto);
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var healthyFoods = await healthyFoodServise.GetAllAsync();
            return Ok(healthyFoods);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, HealthyFoodAddDto healthyFoodAddDto)
        {
            await healthyFoodServise.UpdateAsync(id, healthyFoodAddDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            await healthyFoodServise.DeleteAsync(id);
            return Ok();
        }
    }

}
