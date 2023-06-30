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
        private readonly IHealthyFoodRepsitory healthyFoodRepsitory;
        private readonly IMapper mapper;

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

        public async Task DeleteAsync(long id)
        {
            await healthyFoodRepsitory.Delete(id);
        }

        public async Task<IEnumerable<HealthyFood>> GetAllAsync()
        {
            return await healthyFoodRepsitory.GetAll();
        }

        public async Task UpdateAsync(long id, HealthyFoodAddDto healthyFoodAddDto)
        {
            var existingHealthyFood = await healthyFoodRepsitory.GetById(id);

            if (existingHealthyFood != null)
            {
                mapper.Map(healthyFoodAddDto, existingHealthyFood);
                await healthyFoodRepsitory.Update(id, existingHealthyFood);
            }
        }
    }
}

