using AutoMapper;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys.Files;
using Hospital.Servise.DTOs.FileDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PictureServise : IPictureServise
{
    private readonly IPictureRepsitory pictureRepsitory;
    private readonly IMapper mapper;

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

    public async Task DeleteAsync(long id)
    {
        await pictureRepsitory.Delete(id);
    }

    public async Task<IEnumerable<Picture>> GetAllAsync()
    {
        return await pictureRepsitory.GetAll();
    }

    public async Task UpdateAsync(long id, PictureAddDto pictureAddDto)
    {
        var existingPicture = await pictureRepsitory.GetById(id);

        if (existingPicture != null)
        {
            mapper.Map(pictureAddDto, existingPicture);

            await pictureRepsitory.Update(existingPicture.Id, existingPicture);
        }
    }
}

