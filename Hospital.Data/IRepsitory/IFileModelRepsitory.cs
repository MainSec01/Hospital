using Hospital.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface IFileModelRepsitory
    {
        public Task Add(FileModel fileModel);
        public Task<IEnumerable<FileModel>> GetAll();
        public Task Update(int id, FileModel fileModel);
        public Task Delete(int id);
    }
}
