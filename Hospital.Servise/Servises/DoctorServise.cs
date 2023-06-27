using AutoMapper;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys;
using Hospital.Servise.DTOs.DoctorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Servise.Servises
{
    public class DoctorServise : IDoctorServise
    {
        IDoctorRepsitory doctorRepsitory;
        Mapper mapper;

        public DoctorServise(Mapper mapper, IDoctorRepsitory doctorRepsitory)
        {
            this.mapper = mapper;
            this.doctorRepsitory = doctorRepsitory;
        }

        public async Task AddAsync(DoctorAddDto doctorAddDto)
        {
            var doctor = mapper.Map<Doctor>(doctorAddDto);
            await doctorRepsitory.Add(doctor);
        }

        public async Task DeleteAsync(int id)
        {
        }

        public async Task<IEnumerable<Doctor>> GetAllAsync() =>
            await doctorRepsitory.GetAll();

        public async Task UpdateAsync(int id, DoctorAddDto doctorAddDto)
        {
        }
    }
}
