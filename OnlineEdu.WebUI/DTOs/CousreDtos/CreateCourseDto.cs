using System;

namespace OnlineEdu.WebUI.DTOs.ContactsDtos;

public class CreateCourseDto
{
    public string CourseName { get; set; }
    public string ImageUrl { get; set; }
    public int CourseCategoryId { get; set; }
    public decimal Price { get; set; }
    public bool IsShow { get; set; }

}
