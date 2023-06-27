using Hospital.Data.HospitalDBContext;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Repsitory
{
    public class FileModelRepsitory : IFileModelRepsitory
    {
        AppDbContext dbContext;

        public FileModelRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(FileModel fileModel)
        {
            
        }

        public async Task Delete(int id)
        {
        }

        public async Task<IEnumerable<FileModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task Update(int id, FileModel fileModel)
        {
        }
    }
}
