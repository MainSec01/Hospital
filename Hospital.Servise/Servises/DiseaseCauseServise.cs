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
        private readonly IDiseaseCauseRepsitory diseaseCauseRepsitory;
        private readonly IMapper mapper;

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

        public async Task DeleteAsync(long id)
        {
            await diseaseCauseRepsitory.Delete(id);
        }

        public async Task<IEnumerable<DiseaseCause>> GetAllAsync()
        {
            return await diseaseCauseRepsitory.GetAll();
        }

        public async Task UpdateAsync(long id, DiseaseCauseAddDto diseaseCauseAddDto)
        {
            var existingDiseaseCause = await diseaseCauseRepsitory.GetById(id);

            mapper.Map(diseaseCauseAddDto, existingDiseaseCause);

            await diseaseCauseRepsitory.Update(existingDiseaseCause.Id, existingDiseaseCause);
        }
    }
}

