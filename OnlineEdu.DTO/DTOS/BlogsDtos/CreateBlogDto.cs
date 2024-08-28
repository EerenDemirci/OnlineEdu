using System;
using OnlineEdu.DTO.DTOS.BlogCategoryDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DTO.DTOS.BlogsBanner;

public class CreateBlogDto
{

    public string Title { get; set; }
    public string Content { get; set; }
    public string ImageUrl { get; set; }
    public DateTime BlogDate { get; set; }
    public int BlogCategoryId { get; set; }
    public ResultBlogCategoryDto BlogCategory { get; set; }

}
