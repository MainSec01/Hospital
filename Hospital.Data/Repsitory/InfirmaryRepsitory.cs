using Hospital.Data.HospitalDBContext;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys.Hospitals;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Repsitory
{
    public class InfirmaryRepsitory : IInfirmaryRepsitory
    {
        private readonly AppDbContext dbContext;

        public InfirmaryRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Infirmary infirmary)
        {
            await dbContext.Infirations.AddAsync(infirmary);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var infirmary = await GetById(id);
            if (infirmary != null)
            {
                dbContext.Infirations.Remove(infirmary);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Infirmary>> GetAll()
        {
            return await dbContext.Infirations.ToListAsync();
        }

        public async Task<Infirmary> GetById(long id)
        {
            return await dbContext.Infirations.FindAsync(id);
        }

        public async Task Update(long id, Infirmary infirmary)
        {
            var existingInfirmary = await GetById(id);
            if (existingInfirmary != null)
            {
                existingInfirmary.Name = infirmary.Name;
                existingInfirmary.location = infirmary.location;

                await dbContext.SaveChangesAsync();
            }
        }
    }

}
