using System;
using OnlineEdu.WebUI.DTOs.CousreDtos;


namespace OnlineEdu.WebUI.DTOs.CourseCategoryDtos;

public class ResultCourseCategoryDto
{
        public int CourseCategoryId { get; set; }
    public string CategoryName {get;   set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    public bool IsShow { get; set; }
    public List<ResultCourseDto> Courses { get; set; }

}

