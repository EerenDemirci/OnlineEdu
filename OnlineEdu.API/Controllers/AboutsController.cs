using System.Reflection.Metadata.Ecma335;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOS.AboutDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IGenericService<About> _aboutService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
        var values = _aboutService.TGetById(id);
        return Ok(values);
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _aboutService.TDelete(id);
            return Ok("Hakkımzıda Alanı silindi"); 

        }
        
        [HttpPost]
        public  IActionResult Create( CreateAboutDto createAboutDto)
        {
            var newValues = _mapper.Map<About>(createAboutDto);
            _aboutService.TCreat(newValues);
            return Ok("Hakkımzıda alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateAboutDto updateAboutDto)
        {
            var value =  _mapper .Map<About>(updateAboutDto);
            _aboutService.TUpdate(value);
            return Ok("Hakkımda alanı güncelendi");
        }
    }
}
