using AutoMapper;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys;
using Hospital.Servise.DTOs.SicknesseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Servise.Servises
{
    public class SicknessServise : ISicknessServise
    {
        private readonly ISicknessRepsitory sicknessRepsitory;
        private readonly IMapper mapper;

        public SicknessServise(IMapper mapper, ISicknessRepsitory sicknessRepsitory)
        {
            this.mapper = mapper;
            this.sicknessRepsitory = sicknessRepsitory;
        }

        public async Task AddAsync(SicknesseAddDto sicknesseAddDto)
        {
            var sickness = mapper.Map<Sickness>(sicknesseAddDto);
            await sicknessRepsitory.Add(sickness);
        }

        public async Task DeleteAsync(long id)
        {
            await sicknessRepsitory.Delete(id);
        }

        public async Task<IEnumerable<Sickness>> GetAllAsync()
        {
            return await sicknessRepsitory.GetAll();
        }

        public async Task UpdateAsync(long id, SicknesseAddDto sicknesseAddDto)
        {
            var existingSickness = await sicknessRepsitory.GetById(id);
            if (existingSickness != null)
            {
                mapper.Map(sicknesseAddDto, existingSickness);
                await sicknessRepsitory.Update(id, existingSickness);
            }
        }
    }
}

