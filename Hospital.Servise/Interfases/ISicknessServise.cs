using Hospital.Domain.Entitys;
using Hospital.Servise.DTOs.SicknesseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface ISicknessServise
    {
        public Task AddAsync(SicknesseAddDto sicknesseAddDto);
        public Task<IEnumerable<Sickness>> GetAllAsync();
        public Task UpdateAsync(long id, SicknesseAddDto sicknesseAddDto); 
        public Task DeleteAsync(long id);
    }
}
