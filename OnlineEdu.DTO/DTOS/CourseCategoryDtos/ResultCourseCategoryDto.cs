using System;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DTO.DTOS.CourseCategoryDtos;

public class ResultCourseCategoryDto
{
        public int CourseCategoryId { get; set; }
    public string CategoryName {get;   set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    public bool IsShow { get; set; }
    public List<Course> Courses { get; set; }

}
