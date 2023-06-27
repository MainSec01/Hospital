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
        AppDbContext dbContext;
        public InfirmaryRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Infirmary infirmary)
        {
            await dbContext.Infirations.AddAsync(infirmary);
            await dbContext.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Infirmary>> GetAll() =>
            await dbContext.Infirations.ToListAsync();

        public async Task Update(int id, Infirmary infirmary)
        {
        }
    }
}
