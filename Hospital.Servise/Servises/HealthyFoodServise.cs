using AutoMapper;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys.HealthyFoods;
using Hospital.Servise.DTOs.HealthyFoodDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Servise.Servises
{
    public class HealthyFoodServise : IHealthyFoodServise
    {
        IHealthyFoodRepsitory healthyFoodRepsitory;
        IMapper mapper;

        public HealthyFoodServise(IMapper mapper, IHealthyFoodRepsitory healthyFoodRepsitory)
        {
            this.mapper = mapper;
            this.healthyFoodRepsitory = healthyFoodRepsitory;
        }

        public async Task AddAsync(HealthyFoodAddDto healthyFoodAddDto)
        {
            var healthyFood = mapper.Map<HealthyFood>(healthyFoodAddDto);
            await healthyFoodRepsitory.Add(healthyFood);
        }

        public async Task DeleteAsync(int id)
        {
        }

        public async Task<IEnumerable<HealthyFood>> GetAllAsync() =>
            await healthyFoodRepsitory.GetAll();

        public async Task UpdateAsync(int id, HealthyFoodAddDto healthyFoodAddDto)
        {
        }
    }
}
