using System;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DTO.DTOS.BlogCategoryDtos;

public class ResultBlogCategoryDto
{
  public int BlogCategoryId { get; set; }
    public string Name { get; set; }
    public List<ResultBlogDto> Blogs { get; set; }
}
