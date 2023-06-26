using AutoMapper;
using Hospital.Domain.Entitys;
using Hospital.Servise.DTOs.DoctorDtos;

namespace RoboMarketApi.Canfigurations
{
    public class MapConfiguration : Profile
    {
        public MapConfiguration()
        {
           CreateMap<DoctorAddDto,Doctor>().ReverseMap();
        }
    }
}
