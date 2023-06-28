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
        AppDbContext dbContext;

        public DiseaseCauseRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(DiseaseCause diseaseCause)
        {
            await dbContext.DiseaseCauses.AddAsync(diseaseCause);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {

        }

        public async Task<IEnumerable<DiseaseCause>> GetAll()=>
            await dbContext.DiseaseCauses.ToListAsync();

        public async Task Update(int id, DiseaseCause diseaseCause)
        {

        }
    }
}
