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
        private readonly IDoctorRepsitory doctorRepsitory;
        private readonly IMapper mapper;

        public DoctorServise(IMapper mapper, IDoctorRepsitory doctorRepsitory)
        {
            this.mapper = mapper;
            this.doctorRepsitory = doctorRepsitory;
        }

        public async Task AddAsync(DoctorAddDto doctorAddDto)
        {
            var doctor = mapper.Map<Doctor>(doctorAddDto);
            await doctorRepsitory.Add(doctor);
        }

        public async Task DeleteAsync(long id)
        {
            await doctorRepsitory.Delete(id);
        }

        public async Task<IEnumerable<Doctor>> GetAllAsync()
        {
            return await doctorRepsitory.GetAll();
        }

        public async Task UpdateAsync(long id, DoctorAddDto doctorAddDto)
        {
            var existingDoctor = await doctorRepsitory.GetById(id);

            if (existingDoctor != null)
            {
                mapper.Map(doctorAddDto, existingDoctor);
                await doctorRepsitory.Update(existingDoctor.Id, existingDoctor);
            }
        }
    }
}

