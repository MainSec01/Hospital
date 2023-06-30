using AutoMapper;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys.Hospitals;
using Hospital.Servise.DTOs.HospitalDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InfirmaryServise : IInfirmaryServise
{
    private readonly IInfirmaryRepsitory infirmaryRepsitory;
    private readonly IMapper mapper;

    public InfirmaryServise(IMapper mapper, IInfirmaryRepsitory infirmaryRepsitory)
    {
        this.mapper = mapper;
        this.infirmaryRepsitory = infirmaryRepsitory;
    }

    public async Task AddAsync(InfirmaryAddDto infirmaryAddDto)
    {
        var infirmary = mapper.Map<Infirmary>(infirmaryAddDto);
        await infirmaryRepsitory.Add(infirmary);
    }

    public async Task DeleteAsync(long id)
    {
        await infirmaryRepsitory.Delete(id);
    }

    public async Task<IEnumerable<Infirmary>> GetAllAsync()
    {
        return await infirmaryRepsitory.GetAll();
    }

    public async Task UpdateAsync(long id, InfirmaryAddDto infirmaryAddDto)
    {
        var existingInfirmary = await infirmaryRepsitory.GetById(id);

        if (existingInfirmary != null)
        {
            mapper.Map(infirmaryAddDto, existingInfirmary);

            await infirmaryRepsitory.Update(existingInfirmary.Id, existingInfirmary);
        }
    }
}

