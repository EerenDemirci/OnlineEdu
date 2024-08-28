using System;
using AutoMapper;
using OnlineEdu.DTO.DTOS.SubscriberDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping;

public class SubscriberMapper:Profile
{
    public SubscriberMapper()
    {
        CreateMap<CreateSubcriberDto, Subscriber>().ReverseMap();
        CreateMap<UpdateSubcriberDto, Subscriber>().ReverseMap();
    }

}
