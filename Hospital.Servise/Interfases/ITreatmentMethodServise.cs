using Hospital.Domain.Entitys.TreatmentMethods;
using Hospital.Servise.DTOs.TreatmentMethodDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface ITreatmentMethodServise
    {
        public Task AddAsync(TreatmentMethodAddDto treatmentMethodAddDto);
        public Task<IEnumerable<TreatmentMethod>> GetAllAsync();
        public Task UpdateAsync(int id, TreatmentMethodAddDto treatmentMethodAddDto);
        public Task DeleteAsync(int id);
    }
}
