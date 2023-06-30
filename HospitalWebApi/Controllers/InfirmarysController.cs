using Hospital.Data.IRepsitory;
using Hospital.Servise.DTOs.HospitalDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfirmarysController : ControllerBase
    {
        private readonly IInfirmaryServise infirmaryServise;

        public InfirmarysController(IInfirmaryServise infirmaryServise)
        {
            this.infirmaryServise = infirmaryServise;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(InfirmaryAddDto infirmaryAddDto)
        {
            if (infirmaryAddDto is not null)
            {
                await infirmaryServise.AddAsync(infirmaryAddDto);
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var infirmarys = await infirmaryServise.GetAllAsync();
            return Ok(infirmarys);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, InfirmaryAddDto infirmaryAddDto)
        {
            await infirmaryServise.UpdateAsync(id, infirmaryAddDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            await infirmaryServise.DeleteAsync(id);
            return Ok();
        }
    }

}
