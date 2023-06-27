using Hospital.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface ISymptomRepsitory
    {
        public Task Add(Symptom symptom);
        public Task<IEnumerable<Symptom>> GetAll();
        public Task Update(int id, Symptom symptom);
        public Task Delete(int id);
    }
}
