using Hospital.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface IResponseRepsitory
    {
        public Task Add(Response response);
        public Task<IEnumerable<Response>> GetAll();
        public Task Update(int id, Response response);
        public Task Delete(int id);
    }
}
