using System;
using AutoMapper;
using OnlineEdu.DTO.DTOS.ContactsDtos;
using OnlineEdu.DTO.DTOS.CousreDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping;

public class CourseMapping: Profile 
{
    public CourseMapping()
    {
        CreateMap<CreateCourseDto, Course>().ReverseMap();
        CreateMap<UpdateCourseDto, Course>().ReverseMap();
        CreateMap<ResultCourseDto, Course>().ReverseMap();
    }

}
