using System;

using OnlineEdu.WebUI.DTOs.CourseCategoryDtos;

namespace OnlineEdu.WebUI.DTOs.CousreDtos;

public class ResultCourseDto
{
        public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string ImageUrl { get; set; }
    public int CourseCategoryId { get; set; }
    public ResultCourseCategoryDto Category { get; set; }
    public decimal Price { get; set; }
    public bool IsShow { get; set; }

}
