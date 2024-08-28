using System;
using AutoMapper;
using OnlineEdu.DTO.DTOS.MassageDto;
using OnlineEdu.DTO.DTOS.MassageDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping;

public class MassageMapper: Profile
{
    public MassageMapper()
    {
        CreateMap<CreateMassageDto, Massage>().ReverseMap();
        CreateMap<UpdateMassageDto, Massage>().ReverseMap();
    }

}
