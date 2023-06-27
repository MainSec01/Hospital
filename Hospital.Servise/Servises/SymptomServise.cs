using AutoMapper;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys;
using Hospital.Servise.DTOs.SymptomDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Servise.Servises
{
    public class SymptomServise : ISymptomServise
    {
        ISymptomRepsitory symptomRepsitory;
        IMapper mapper;

        public SymptomServise(IMapper mapper, ISymptomRepsitory symptomRepsitory)
        {
            this.mapper = mapper;
            this.symptomRepsitory = symptomRepsitory;
        }

        public async Task AddAsync(SymptomAddDto symptomAddDto)
        {
            var symptom = mapper.Map<Symptom>(symptomAddDto);
            await symptomRepsitory.Add(symptom);
        }

        public async Task DeleteAsync(int id)
        {
        }

        public async Task<IEnumerable<Symptom>> GetAllAsync() =>
            await symptomRepsitory.GetAll();

        public async Task UpdateAsync(int id, SymptomAddDto symptomAddDto)
        {
        }
    }
}
