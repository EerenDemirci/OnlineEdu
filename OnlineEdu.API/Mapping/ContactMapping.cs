using System;
using AutoMapper;
using OnlineEdu.DTO.DTOS.ContactsDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping;

public class ContactMapping: Profile
{
    public ContactMapping()
    {
        CreateMap<CreateContactDto, Contact>().ReverseMap();
        CreateMap<UpdateContactDto, Contact>().ReverseMap();
        
        
    }
}


