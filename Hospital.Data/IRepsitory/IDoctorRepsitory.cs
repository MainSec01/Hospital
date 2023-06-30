using Hospital.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface IDoctorRepsitory
    {
        public Task Add(Doctor doctor);
        public Task<IEnumerable<Doctor>> GetAll();
        public Task Update(long id, Doctor doctor);
        public Task Delete(long id);
        public Task<Doctor> GetById(long id);
    }
}
