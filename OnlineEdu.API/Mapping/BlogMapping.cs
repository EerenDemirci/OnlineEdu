using System;
using AutoMapper;
using OnlineEdu.DTO.DTOS.BlogCategoryDtos;
using OnlineEdu.DTO.DTOS.BlogsBanner;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping;

public class BlogMapping: Profile
{
    public BlogMapping()
    {
        CreateMap<CreateBlogDto, Blog>().ReverseMap();
        CreateMap<UpdateBlogDto, Blog>().ReverseMap();
        CreateMap<ResultBlogDto, Blog>().ReverseMap();
    }


}
