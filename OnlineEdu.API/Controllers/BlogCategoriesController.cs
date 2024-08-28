using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOS.BlogCategoryDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController(IGenericService<BlogCategory> _blogCategoryService,IMapper _mapper) : ControllerBase
    {
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _blogCategoryService.TGetById(id);
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _blogCategoryService.TDelete(id);
            return Ok("Blog Kategory Alanı silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateBlogCategoryDto createBlogCategoryDto)
        {
            var newValues = _mapper.Map<BlogCategory>(createBlogCategoryDto);
            _blogCategoryService.TCreat(newValues);
            return Ok("Blog Kategory alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(CreateBlogCategoryDto updateBlogCategoryDto)
        {
            var value = _mapper.Map<BlogCategory>(updateBlogCategoryDto);
            _blogCategoryService.TUpdate(value);
            return Ok("Blog Kategory alanı güncelendi");
    }
    }
}
