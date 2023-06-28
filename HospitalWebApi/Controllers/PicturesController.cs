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
        IPictureServise pictureServise;

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
            return Ok(await pictureServise.GetAllAsync());
        }
    }
}
