using AutoMapper;
using Hospital.Data.IRepsitory;
using Hospital.Data.Repsitory;
using Hospital.Domain.Entitys.DiseaseCauses;
using Hospital.Servise.DTOs.DiseaseCauseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Servise.Servises
{
    public class DiseaseCauseServise : IDiseaseCauseServise
    {
        IDiseaseCauseRepsitory diseaseCauseRepsitory;
        IMapper mapper;

        public DiseaseCauseServise(IMapper mapper, IDiseaseCauseRepsitory diseaseCauseRepsitory)
        {
            this.mapper = mapper;
            this.diseaseCauseRepsitory = diseaseCauseRepsitory;
        }

        public async Task AddAsync(DiseaseCauseAddDto diseaseCauseAddDto)
        {
            var diseaseCause = mapper.Map<DiseaseCause>(diseaseCauseAddDto);
            await diseaseCauseRepsitory.Add(diseaseCause);
        }

        public async Task DeleteAsync(int id)
        {
        }

        public async Task<IEnumerable<DiseaseCause>> GetAllAsync() =>
            await diseaseCauseRepsitory.GetAll();

        public async Task UpdateAsync(int id, DiseaseCauseAddDto diseaseCauseAddDto)
        {
        }
    }
}
