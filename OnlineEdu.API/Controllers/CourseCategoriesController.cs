using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOS.CourseCategoryDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController(IGenericService<CourseCategory> _courseCategoryService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _courseCategoryService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
        var values = _courseCategoryService.TGetById(id);
        return Ok(values);
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseCategoryService.TDelete(id);
            return Ok("Yeni kurs kategory Alanı silindi"); 

        }
        
        [HttpPost]
        public  IActionResult Create(CreateCourseCategoryDto createCourseCategoryDto)
        {
            var newValues = _mapper.Map<CourseCategory>(createCourseCategoryDto);
            _courseCategoryService.TCreat(newValues);
            return Ok("Yeni kurs kategory alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateCourseCategoryDto updateCourseCategoryDto)
        {
            var value =  _mapper .Map<CourseCategory>(updateCourseCategoryDto);
            _courseCategoryService.TUpdate(value);
            return Ok("Yeni kurs kategory alanı güncelendi");
        }
    }
}
