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
        private readonly AppDbContext dbContext;

        public PictureRepsitory(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Picture picture)
        {
            await dbContext.Pictures.AddAsync(picture);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var picture = await dbContext.Pictures.FindAsync(id);
            if (picture != null)
            {
                dbContext.Pictures.Remove(picture);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Picture>> GetAll() =>
            await dbContext.Pictures.ToListAsync();

        public async Task<Picture> GetById(long id) =>
            await dbContext.Pictures.FindAsync(id);

        public async Task Update(long id, Picture picture)
        {
            var existingPicture = await dbContext.Pictures.FindAsync(id);
            if (existingPicture != null)
            {
                existingPicture.FilePath = picture.FilePath;
                existingPicture.FileName = picture.FileName;

                await dbContext.SaveChangesAsync();
            }
        }
    }

}
