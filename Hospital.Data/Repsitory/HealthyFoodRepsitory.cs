using Hospital.Data.HospitalDBContext;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys.HealthyFoods;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Repsitory
{
    public class HealthyFoodRepsitory : IHealthyFoodRepsitory
    {
        private readonly AppDbContext dbContext;

        public HealthyFoodRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(HealthyFood healthyFood)
        {
            await dbContext.HealthyFoods.AddAsync(healthyFood);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var healthyFood = await GetById(id);
            if (healthyFood != null)
            {
                dbContext.HealthyFoods.Remove(healthyFood);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<HealthyFood>> GetAll()
        {
            return await dbContext.HealthyFoods.ToListAsync();
        }

        public async Task<HealthyFood> GetById(long id)
        {
            return await dbContext.HealthyFoods.FindAsync(id);
        }

        public async Task Update(long id, HealthyFood healthyFood)
        {
            var existingHealthyFood = await GetById(id);
            if (existingHealthyFood != null)
            {
                existingHealthyFood.Name = healthyFood.Name;
                // Update other properties as needed

                await dbContext.SaveChangesAsync();
            }
        }
    }

}
