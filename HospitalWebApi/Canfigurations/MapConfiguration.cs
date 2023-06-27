using AutoMapper;
using Hospital.Domain.Entitys;
using Hospital.Domain.Entitys.DiseaseCauses;
using Hospital.Domain.Entitys.Files;
using Hospital.Domain.Entitys.HealthyFoods;
using Hospital.Domain.Entitys.Hospitals;
using Hospital.Domain.Entitys.TreatmentMethods;
using Hospital.Servise.DTOs.DiseaseCauseDtos;
using Hospital.Servise.DTOs.DoctorDtos;
using Hospital.Servise.DTOs.FileDtos;
using Hospital.Servise.DTOs.HealthyFoodDtos;
using Hospital.Servise.DTOs.HospitalDtos;
using Hospital.Servise.DTOs.SicknesseDtos;
using Hospital.Servise.DTOs.SymptomDtos;
using Hospital.Servise.DTOs.TreatmentMethodDtos;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RoboMarketApi.Canfigurations
{
    public class MapConfiguration : Profile
    {
        public MapConfiguration()
        {
            CreateMap<DoctorAddDto,Doctor>().ReverseMap();
            CreateMap<SicknesseAddDto, Sickness>().ReverseMap();  
            CreateMap<DiseaseCauseAddDto, DiseaseCause>().ReverseMap();
            CreateMap<ModelAddDto, Model>().ReverseMap();
            CreateMap<PictureAddDto, Picture>().ReverseMap();
            CreateMap<ResponseAddDto, Response>().ReverseMap();
            CreateMap<HealthyFoodAddDto, HealthyFood>().ReverseMap();
            CreateMap<InfirmaryAddDto, Infirmary>().ReverseMap();
            CreateMap<SymptomAddDto,  Symptom>().ReverseMap();
            CreateMap<TreatmentMethodAddDto, treatmentMethod>().ReverseMap();
        }
    }
}
