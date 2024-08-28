using System;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DTO.DTOS.CourseCategoryDtos;

public class CreateCourseCategoryDto
{    public string CategoryName {get;   set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    public bool IsShow { get; set; }
}


