using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOS.TestimonialDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(IGenericService<Testimonial> _testimonialService, IMapper _mapper) : ControllerBase
    {
                [HttpGet]
        public IActionResult Get()
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
        var values = _testimonialService.TGetById(id);
        return Ok(values);
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _testimonialService.TDelete(id);
            return Ok("Hakkımzıda Alanı silindi"); 

        }
        
        [HttpPost]
        public  IActionResult Create( CreateTestimonialDto createTestimonialDto)
        {
            var newValues = _mapper.Map<Testimonial>(createTestimonialDto);
            _testimonialService.TCreat(newValues);
            return Ok("Hakkımzıda alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateTestimonialDto updateTestimonialDto)
        {
            var value =  _mapper .Map<Testimonial>(updateTestimonialDto);
            _testimonialService.TUpdate(value);
            return Ok("Hakkımda alanı güncelendi");
    }
 }
}
