using System;

namespace OnlineEdu.DTO.DTOS.CourseCategoryDtos;

public class UpdateCourseCategoryDto
{
        public int CourseCategoryId { get; set; }
    public string CategoryName {get;   set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    public bool IsShow { get; set; }

}
