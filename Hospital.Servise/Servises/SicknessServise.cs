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
        ISicknessRepsitory sicknessRepsitory;
        IMapper mapper;

        public SicknessServise(IMapper mapper, ISicknessRepsitory sicknessRepsitoryc)
        {
            this.mapper = mapper;
            this.sicknessRepsitory = sicknessRepsitory;
        }

        public async Task AddAsync(SicknesseAddDto sicknesseAddDto)
        {
            var sicknesse = mapper.Map<Sickness>(sicknesseAddDto);
            await sicknessRepsitory.Add(sicknesse);
        }

        public async Task DeleteAsync(int id)
        {
        }

        public async Task<IEnumerable<Sickness>> GetAllAsync() =>
            await sicknessRepsitory.GetAll();

        public async Task UpdateAsync(int id, SicknesseAddDto sicknesseAddDto)
        {
        }
    }
}
