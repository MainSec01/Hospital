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
        AppDbContext dbContext;
        public HealthyFoodRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public  async Task Add(HealthyFood healthyFood)
        {
            await dbContext.HealthyFoods.AddAsync(healthyFood);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
        }

        public async Task<IEnumerable<HealthyFood>> GetAll() =>
            await dbContext.HealthyFoods.ToListAsync();

        public async Task Update(int id, HealthyFood healthyFood)
        {
        }
    }
}
