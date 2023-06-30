using Hospital.Data.IRepsitory;
using Hospital.Servise.DTOs.FileDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PicturesController : ControllerBase
    {
        private readonly IPictureServise pictureServise;

        public PicturesController(IPictureServise pictureServise)
        {
            this.pictureServise = pictureServise;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(PictureAddDto pictureAddDto)
        {
            if (pictureAddDto is not null)
            {
                await pictureServise.AddAsync(pictureAddDto);
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var pictures = await pictureServise.GetAllAsync();
            return Ok(pictures);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, PictureAddDto pictureAddDto)
        {
            await pictureServise.UpdateAsync(id, pictureAddDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            await pictureServise.DeleteAsync(id);
            return Ok();
        }
    }

}
