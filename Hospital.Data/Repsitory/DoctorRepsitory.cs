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
        private readonly AppDbContext dbContext;

        public DoctorRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Doctor doctor)
        {
            await dbContext.Doctors.AddAsync(doctor);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var doctor = await GetById(id);
            if (doctor != null)
            {
                dbContext.Doctors.Remove(doctor);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Doctor>> GetAll()
        {
            return await dbContext.Doctors.ToListAsync();
        }

        public async Task<Doctor> GetById(long id)
        {
            return await dbContext.Doctors.FindAsync(id);
        }

        public async Task Update(long id, Doctor doctor)
        {
            var existingDoctor = await GetById(id);
            if (existingDoctor != null)
            {
                existingDoctor.First_name = doctor.First_name;
                existingDoctor.Last_name = doctor.Last_name;
                existingDoctor.price = doctor.price;
                existingDoctor.Worklocation = doctor.Worklocation;
                existingDoctor.Direction = doctor.Direction;
                existingDoctor.UpdatedAt = DateTime.UtcNow;
                await dbContext.SaveChangesAsync();
            }
        }
    }

}
