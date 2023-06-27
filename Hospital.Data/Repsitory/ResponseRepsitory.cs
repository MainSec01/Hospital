using Hospital.Data.HospitalDBContext;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Repsitory
{
    public class ResponseRepsitory : IResponseRepsitory
    {
        AppDbContext dbContext;
        public async Task Add(Response response)
        {
        }

        public async Task Delete(int id)
        {
        }

        public async Task<IEnumerable<Response>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task Update(int id, Response response)
        {
        }
    }
}
