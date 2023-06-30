using Hospital.Domain.Entitys.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface IPictureRepsitory
    {
        public Task Add(Picture picture);
        public Task<IEnumerable<Picture>> GetAll();
        public Task Update(long id, Picture picture); 
        public Task Delete(long id);
        public Task<Picture> GetById(long id);
    }
}
