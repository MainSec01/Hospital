using AutoMapper;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys.TreatmentMethods;
using Hospital.Servise.DTOs.TreatmentMethodDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Servise.Servises
{
    public class TreatmentMethodServise : ITreatmentMethodServise
    {
        ITreatmentMethodRepsitory treatmentMethodRepsitory;
        Mapper mapper;

        public TreatmentMethodServise(Mapper mapper, ITreatmentMethodRepsitory treatmentMethodRepsitory)
        {
            this.mapper = mapper;
            this.treatmentMethodRepsitory = treatmentMethodRepsitory;
        }

        public async Task AddAsync(TreatmentMethodAddDto treatmentMethodAddDto)
        {
            var treatmentMethod = mapper.Map<TreatmentMethod>(treatmentMethodAddDto);
            await treatmentMethodRepsitory.Add(treatmentMethod);
        }

        public async Task DeleteAsync(int id)
        {
        }

        public async Task<IEnumerable<TreatmentMethod>> GetAllAsync() =>
            await treatmentMethodRepsitory.GetAll();

        public async Task UpdateAsync(int id, TreatmentMethodAddDto treatmentMethodAddDto)
        {
        }
    }
}
