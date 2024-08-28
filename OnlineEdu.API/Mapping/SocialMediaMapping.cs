using System;
using AutoMapper;
using OnlineEdu.DTO.DTOS.SocialMediaDto;
using OnlineEdu.DTO.DTOS.SocialMediaDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping;

public class SocialMediaMapping: Profile
{
    public SocialMediaMapping()
    {
        CreateMap<CreateSocialMediaDto, SocialMedia>().ReverseMap();
        CreateMap<UpdateSocialMediaDto, SocialMedia>().ReverseMap();
    }

}
