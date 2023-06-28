using Hospital.Domain.Entitys.DiseaseCauses;
using Hospital.Servise.DTOs.DiseaseCauseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface IDiseaseCauseServise
    {
        public Task AddAsync(DiseaseCauseAddDto diseaseCauseAddDto);
        public Task<IEnumerable<DiseaseCause>> GetAllAsync();
        public Task UpdateAsync(int id, DiseaseCauseAddDto diseaseCauseAddDto);
        public Task DeleteAsync(int id);
    }
}
