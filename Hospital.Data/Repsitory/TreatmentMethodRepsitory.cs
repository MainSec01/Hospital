using Hospital.Data.HospitalDBContext;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys.TreatmentMethods;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Repsitory
{
    public class TreatmentMethodRepsitory : ITreatmentMethodRepsitory
    {
        AppDbContext dbContext;
        public TreatmentMethodRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(TreatmentMethod treatmentMethod)
        {
            await dbContext.TreatmentMethods.AddAsync(treatmentMethod);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
        }

        public async Task<IEnumerable<TreatmentMethod>> GetAll() =>
            await dbContext.TreatmentMethods.ToListAsync();

        public async Task Update(int id, TreatmentMethod treatmentMethod)
        {
        }
    }
}
