using AutoMapper;
using Hospital.Data.IRepsitory;
using Hospital.Domain.Entitys;
using Hospital.Servise.DTOs.SymptomDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SymptomServise : ISymptomServise
{
    private readonly ISymptomRepsitory symptomRepsitory;
    private readonly IMapper mapper;

    public SymptomServise(IMapper mapper, ISymptomRepsitory symptomRepsitory)
    {
        this.mapper = mapper;
        this.symptomRepsitory = symptomRepsitory;
    }

    public async Task AddAsync(SymptomAddDto symptomAddDto)
    {
        var symptom = mapper.Map<Symptom>(symptomAddDto);
        await symptomRepsitory.Add(symptom);
    }

    public async Task DeleteAsync(long id)
    {
        await symptomRepsitory.Delete(id);
    }

    public async Task<IEnumerable<Symptom>> GetAllAsync()
    {
        return await symptomRepsitory.GetAll();
    }

    public async Task UpdateAsync(long id, SymptomAddDto symptomAddDto)
    {
        var existingSymptom = await symptomRepsitory.GetById(id);
        if (existingSymptom != null)
        {
            mapper.Map(symptomAddDto, existingSymptom);
            await symptomRepsitory.Update(id, existingSymptom);
        }
    }
}

