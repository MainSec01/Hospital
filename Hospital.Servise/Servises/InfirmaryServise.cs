using AutoMapper;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys.Hospitals;
using Hospital.Servise.DTOs.HospitalDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Servise.Servises
{
    public class InfirmaryServise : IInfirmaryServise
    {
        IInfirmaryRepsitory infirmaryRepsitory;
        IMapper mapper;

        public InfirmaryServise(IMapper mapper, IInfirmaryRepsitory infirmaryRepsitory)
        {
            this.mapper = mapper;
            this.infirmaryRepsitory = infirmaryRepsitory;
        }

        public async Task AddAsync(InfirmaryAddDto infirmaryAddDto)
        {
            var infirmary = mapper.Map<Infirmary>(infirmaryAddDto);
            await infirmaryRepsitory.Add(infirmary);
        }

        public async Task DeleteAsync(int id)
        {
        }

        public async Task<IEnumerable<Infirmary>> GetAllAsync() =>
            await infirmaryRepsitory.GetAll();

        public async Task UpdateAsync(int id, InfirmaryAddDto infirmaryAddDto)
        {
        }
    }
}
