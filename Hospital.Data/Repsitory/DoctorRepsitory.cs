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
    public class DoctorRepsitory : IDoctorRepsitory
    {
        AppDbContext dbContext;

        public DoctorRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Doctor doctor)
        {
            await dbContext.Doctors.AddAsync(doctor);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
        }

        public async Task<IEnumerable<Doctor>> GetAll() =>
            await dbContext.Doctors.ToListAsync();

        public async Task Update(int id, Doctor doctor)
        {
        }
    }
}
