using AutoMapper;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys.Files;
using Hospital.Servise.DTOs.FileDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Servise.Servises
{
    public class PictureServise : IPictureServise
    {
        IPictureRepsitory pictureRepsitory;
        IMapper mapper;

        public PictureServise(IMapper mapper, IPictureRepsitory pictureRepsitory)
        {
            this.mapper = mapper;
            this.pictureRepsitory = pictureRepsitory;
        }

        public async Task AddAsync(PictureAddDto pictureAddDto)
        {
            var picture = mapper.Map<Picture>(pictureAddDto);
            await pictureRepsitory.Add(picture);
        }

        public async Task DeleteAsync(int id)
        {
        }

        public async Task<IEnumerable<Picture>> GetAllAsync() =>
            await pictureRepsitory.GetAll();

        public async Task UpdateAsync(int id, PictureAddDto pictureAddDto)
        {
        }
    }
}
