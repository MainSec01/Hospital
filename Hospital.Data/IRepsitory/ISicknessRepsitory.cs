using Hospital.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface ISicknessRepsitory
    {
        public Task Add(Sickness sickness);
        public Task<IEnumerable<Sickness>> GetAll();
        public Task Update(long id, Sickness sickness); 
        public Task Delete(long id);
        public Task<Sickness> GetById(long id);
    }
}
