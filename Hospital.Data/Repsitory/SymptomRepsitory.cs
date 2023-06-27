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
        AppDbContext dbContext;
        public async Task Add(Symptom symptom)
        {
            await dbContext.Symptoms.AddAsync(symptom);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
        }

        public async Task<IEnumerable<Symptom>> GetAll() =>
            await dbContext.Symptoms.ToListAsync();

        public async Task Update(int id, Symptom symptom)
        {
        }
    }
}
