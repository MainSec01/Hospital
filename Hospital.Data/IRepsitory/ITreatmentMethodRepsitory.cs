using Hospital.Domain.Entitys.TreatmentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface ITreatmentMethodRepsitory
    {
        public Task Add(TreatmentMethod treatmentMethod);
        public Task<IEnumerable<TreatmentMethod>> GetAll();
        public Task Update(int id, TreatmentMethod treatmentMethod);
        public Task Delete(int id);
    }
}
