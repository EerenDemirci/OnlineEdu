using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOS.BlogsBanner;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers;
//constructer
public class BlogsController(IGenericService<Blog> _blogService,IMapper _mapper) : ControllerBase
//constructer injected
{

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _blogService.TGetById(id);
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _blogService.TDelete(id);
            return Ok("Blog Alanı silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateBlogDto createBlogDto)
        {
            Blog newValues = _mapper.Map<Blog>(createBlogDto);
            _blogService.TCreat(newValues);
            return Ok("Blog alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateBlogDto updateBlogDto)
        {
            var value = _mapper.Map<Blog>(updateBlogDto);
            _blogService.TUpdate(value);
            return Ok("Blog alanı güncelendi");
    }
}
