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
        Task AddAsync(TreatmentMethodAddDto treatmentMethodAddDto);
        Task DeleteAsync(long id);
        Task<IEnumerable<TreatmentMethod>> GetAllAsync();
        Task UpdateAsync(long id, TreatmentMethodAddDto treatmentMethodAddDto);
    }
}
