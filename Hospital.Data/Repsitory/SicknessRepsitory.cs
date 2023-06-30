using Hospital.Data.HospitalDBContext;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Repsitory
{
    public class SicknessRepsitory : ISicknessRepsitory
    {
        private readonly AppDbContext dbContext;

        public SicknessRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Sickness sickness)
        {
            await dbContext.Sickness.AddAsync(sickness);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var sickness = await dbContext.Sickness.FindAsync(id);
            if (sickness != null)
            {
                dbContext.Sickness.Remove(sickness);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Sickness>> GetAll()
        {
            return await dbContext.Sickness.ToListAsync();
        }

        public async Task<Sickness> GetById(long id)
        {
            return await dbContext.Sickness.FindAsync(id);
        }

        public async Task Update(long id, Sickness sickness)
        {
            var existingSickness = await dbContext.Sickness.FindAsync(id);
            if (existingSickness != null)
            {
                existingSickness.Name = sickness.Name;
                existingSickness.Description = sickness.Description;
                existingSickness.TreatmentMethod = sickness.TreatmentMethod;
                existingSickness.DiseaseCause = sickness.DiseaseCause;
                existingSickness.HealthyFood = sickness.HealthyFood;
                existingSickness.Symptom = sickness.Symptom;
                existingSickness.UpdatedAt = DateTime.UtcNow;
                await dbContext.SaveChangesAsync();
            }
        }
    }

}
