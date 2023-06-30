using Hospital.Data.HospitalDBContext;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys.DiseaseCauses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Repsitory
{
    public class DiseaseCauseRepsitory : IDiseaseCauseRepsitory
    {
        private readonly AppDbContext dbContext;

        public DiseaseCauseRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(DiseaseCause diseaseCause)
        {
            await dbContext.DiseaseCauses.AddAsync(diseaseCause);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var diseaseCause = await dbContext.DiseaseCauses.FindAsync(id);
            dbContext.DiseaseCauses.Remove(diseaseCause);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<DiseaseCause>> GetAll() =>
            await dbContext.DiseaseCauses.ToListAsync();

        public async Task<DiseaseCause> GetById(long id) =>
            await dbContext.DiseaseCauses.FindAsync(id);

        public async Task Update(long id, DiseaseCause updatedDiseaseCause)
        {
            var diseaseCause = await dbContext.DiseaseCauses.FindAsync(id);
            diseaseCause.Name = updatedDiseaseCause.Name;

            await dbContext.SaveChangesAsync();
        }
    }

}
