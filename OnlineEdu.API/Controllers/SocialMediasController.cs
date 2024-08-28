using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOS.SocialMediaDto;
using OnlineEdu.DTO.DTOS.SocialMediaDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController(IGenericService<SocialMedia> _socialMediaService, IMapper _mapper) : ControllerBase
    {
                [HttpGet]
        public IActionResult Get()
        {
            var values = _socialMediaService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
        var values = _socialMediaService.TGetById(id);
        return Ok(values);
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _socialMediaService.TDelete(id);
            return Ok("Hakkımzıda Alanı silindi"); 

        }
        
        [HttpPost]
        public  IActionResult Create( CreateSocialMediaDto createSocialMediaDto)
        {
            var newValues = _mapper.Map<SocialMedia>(createSocialMediaDto);
            _socialMediaService.TCreat(newValues);
            return Ok("Hakkımzıda alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var value =  _mapper .Map<SocialMedia>(updateSocialMediaDto);
            _socialMediaService.TUpdate(value);
            return Ok("Hakkımda alanı güncelendi");
    }
 }
}