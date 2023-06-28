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
        AppDbContext dbContext;
        public SicknessRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Sickness sickness)
        {
            await dbContext.Sickness.ToListAsync();
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
        }

        public async Task<IEnumerable<Sickness>> GetAll()=>
            await dbContext.Sickness.ToListAsync();

        public async Task Update(int id, Sickness sickness)
        {
        }
    }
}
