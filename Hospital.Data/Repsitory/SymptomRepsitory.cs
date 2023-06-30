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
    public class SymptomRepsitory : ISymptomRepsitory
    {
        private readonly AppDbContext dbContext;

        public SymptomRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Symptom symptom)
        {
            await dbContext.Symptoms.AddAsync(symptom);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var symptom = await dbContext.Symptoms.FindAsync(id);
            if (symptom != null)
            {
                dbContext.Symptoms.Remove(symptom);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Symptom>> GetAll()
        {
            return await dbContext.Symptoms.ToListAsync();
        }

        public async Task<Symptom> GetById(long id)
        {
            return await dbContext.Symptoms.FindAsync(id);
        }

        public async Task Update(long id, Symptom symptom)
        {
            var existingSymptom = await dbContext.Symptoms.FindAsync(id);
            if (existingSymptom != null)
            {
                existingSymptom.Name = symptom.Name;
                existingSymptom.sickness = symptom.sickness;
                existingSymptom.UpdatedAt = DateTime.UtcNow;

                await dbContext.SaveChangesAsync();
            }
        }
    }

}
