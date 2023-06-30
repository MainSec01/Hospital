using Hospital.Domain.Entitys.Hospitals;
using Hospital.Servise.DTOs.HospitalDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface IInfirmaryServise
    {
        public Task AddAsync(InfirmaryAddDto infirmaryAddDto);
        public Task<IEnumerable<Infirmary>> GetAllAsync();
        public Task UpdateAsync(long id, InfirmaryAddDto infirmaryAddDto); 
        public Task DeleteAsync(long id);
    }
}
