using Hospital.Data.HospitalDBContext;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys.Files;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Repsitory
{
    public class PictureRepsitory : IPictureRepsitory
    {
        AppDbContext dbContext;
        public PictureRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Picture picture)
        {
            await dbContext.Pictures.AddAsync(picture);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
        }

        public async Task<IEnumerable<Picture>> GetAll() =>
            await dbContext.Pictures.ToListAsync();

        public async Task Update(int id, Picture picture)
        {
            throw new NotImplementedException();
        }
    }
}
