using System;
using AutoMapper;
using OnlineEdu.DTO.DTOS.AboutDtos;
using OnlineEdu.DTO.DTOS.BannerDtos;
using OnlineEdu.Entity.Entities;


namespace OnlineEdu.API.Mapping;

public class BannerMapping: Profile
{
    public BannerMapping()
    {
        CreateMap<CreateBannerDto, Banner>().ReverseMap();
        CreateMap<UpdateBannerDto, Banner>().ReverseMap();


    }

}

