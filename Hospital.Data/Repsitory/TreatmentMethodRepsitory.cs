using Hospital.Data.HospitalDBContext;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys.TreatmentMethods;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Data.Repsitory
{
    public class TreatmentMethodRepsitory : ITreatmentMethodRepsitory
    {
        private readonly AppDbContext dbContext;

        public TreatmentMethodRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(TreatmentMethod treatmentMethod)
        {
            await dbContext.TreatmentMethods.AddAsync(treatmentMethod);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var treatmentMethod = await dbContext.TreatmentMethods.FindAsync(id);
            if (treatmentMethod != null)
            {
                dbContext.TreatmentMethods.Remove(treatmentMethod);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<TreatmentMethod>> GetAll() =>
            await dbContext.TreatmentMethods.ToListAsync();

        public async Task<TreatmentMethod> GetById(long id) =>
            await dbContext.TreatmentMethods.FindAsync(id);

        public async Task Update(long id, TreatmentMethod treatmentMethod)
        {
            var existingTreatmentMethod = await dbContext.TreatmentMethods.FindAsync(id);
            if (existingTreatmentMethod != null)
            {
                existingTreatmentMethod.Name = treatmentMethod.Name;
                await dbContext.SaveChangesAsync();
            }
        }
    }

}
