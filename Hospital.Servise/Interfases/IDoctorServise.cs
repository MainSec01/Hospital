using Hospital.Domain.Entitys;
using Hospital.Servise.DTOs.DoctorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface IDoctorServise
    {
        public Task AddAsync(DoctorAddDto doctorAddDto);
        public Task<IEnumerable<Doctor>> GetAllAsync();
        public Task UpdateAsync(int id, DoctorAddDto doctorAddDto);
        public Task DeleteAsync(int id);
    }
}
