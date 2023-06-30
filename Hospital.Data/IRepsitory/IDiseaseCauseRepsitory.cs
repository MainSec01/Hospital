using Hospital.Domain.Entitys.DiseaseCauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface IDiseaseCauseRepsitory
    {
        public Task Add(DiseaseCause diseaseCause);
        public Task<IEnumerable<DiseaseCause>> GetAll();
        public Task Update(long id, DiseaseCause diseaseCause);
        public Task Delete(long id);
        public Task<DiseaseCause> GetById(long id);
    }
}
