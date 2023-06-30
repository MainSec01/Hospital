using Hospital.Domain.Entitys;
using Hospital.Servise.DTOs.SymptomDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface ISymptomServise
    {
        public Task AddAsync(SymptomAddDto symptomAddDto);
        public Task<IEnumerable<Symptom>> GetAllAsync();
        public Task UpdateAsync(long id, SymptomAddDto symptomAddDto); 
        public Task DeleteAsync(long id);
    }
}
