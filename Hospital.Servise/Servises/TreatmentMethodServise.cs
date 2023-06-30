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
        private readonly ITreatmentMethodRepsitory treatmentMethodRepsitory;
        private readonly IMapper mapper;

        public TreatmentMethodServise(IMapper mapper, ITreatmentMethodRepsitory treatmentMethodRepsitory)
        {
            this.mapper = mapper;
            this.treatmentMethodRepsitory = treatmentMethodRepsitory;
        }

        public async Task AddAsync(TreatmentMethodAddDto treatmentMethodAddDto)
        {
            var treatmentMethod = mapper.Map<TreatmentMethod>(treatmentMethodAddDto);
            await treatmentMethodRepsitory.Add(treatmentMethod);
        }

        public async Task DeleteAsync(long id)
        {
            await treatmentMethodRepsitory.Delete(id);
        }

        public async Task<IEnumerable<TreatmentMethod>> GetAllAsync()
        {
            return await treatmentMethodRepsitory.GetAll();
        }

        public async Task UpdateAsync(long id, TreatmentMethodAddDto treatmentMethodAddDto)
        {
            var existingTreatmentMethod = await treatmentMethodRepsitory.GetById(id);
            if (existingTreatmentMethod != null)
            {
                var updatedTreatmentMethod = mapper.Map<TreatmentMethod>(treatmentMethodAddDto);
                await treatmentMethodRepsitory.Update(id, updatedTreatmentMethod);
            }
        }
    }
}
