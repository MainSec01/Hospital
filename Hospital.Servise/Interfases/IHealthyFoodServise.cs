using Hospital.Domain.Entitys.HealthyFoods;
using Hospital.Servise.DTOs.HealthyFoodDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface IHealthyFoodServise
    {
        public Task AddAsync(HealthyFoodAddDto healthyFoodAddDto);
        public Task<IEnumerable<HealthyFood>> GetAllAsync();
        public Task UpdateAsync(long id, HealthyFoodAddDto healthyFoodAddDto); 
        public Task DeleteAsync(long id);
    }
}
