using System;
using AutoMapper;
using OnlineEdu.DTO.DTOS.BlogCategoryDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping;

public class BlogCategoryMapping: Profile

{
    public BlogCategoryMapping()
    {
        CreateMap<CreateBlogCategoryDto, Blog>().ReverseMap();
        CreateMap<UpdateBlogCategoryDto, Blog>().ReverseMap();
        CreateMap<ResultBlogCategoryDto, Blog>().ReverseMap();
    }

}
