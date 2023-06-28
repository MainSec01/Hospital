using Hospital.Domain.Entitys.Hospitals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface IInfirmaryRepsitory
    {
        public Task Add(Infirmary infirmary);
        public Task<IEnumerable<Infirmary>> GetAll();
        public Task Update(int id, Infirmary infirmary);
        public Task Delete(int id);
    }
}
