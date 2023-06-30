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
        ITreatmentMethodServise treatmentMethodServise;

    }
}
