using Hospital.Domain.Entitys.Files;
using Hospital.Servise.DTOs.FileDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.IRepsitory
{
    public interface IPictureServise
    {
        public Task AddAsync(PictureAddDto pictureAddDto);
        public Task<IEnumerable<Picture>> GetAllAsync();
        public Task UpdateAsync(long id, PictureAddDto pictureAddDto); 
        public Task DeleteAsync(long id);
    }
}
