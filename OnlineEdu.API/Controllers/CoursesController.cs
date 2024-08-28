using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOS.ContactsDtos;
using OnlineEdu.DTO.DTOS.CousreDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(IGenericService<Course> _courseService, IMapper _mapper) : ControllerBase
    {
        
        

        [HttpGet]
        public IActionResult Get()
        {
            var values = _courseService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
        var values = _courseService.TGetById(id);
        return Ok(values);
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseService.TDelete(id);
            return Ok("Yeni kurs Alanı silindi"); 

        }
        
        [HttpPost]
        public  IActionResult Create( CreateCourseDto createCourseDto)
        {
            var newValues = _mapper.Map<Course>(createCourseDto);
            _courseService.TCreat(newValues);
            return Ok("Yeni kurs alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateCourseDto updateCourseDto)
        {
            var value =  _mapper .Map<Course>(updateCourseDto);
            _courseService.TUpdate(value);
            return Ok("Yeni kurs alanı güncelendi");

    }
 }
}
