using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOS.MassageDto;
using OnlineEdu.DTO.DTOS.MassageDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MassagesController(IGenericService<Massage> _massageService,IMapper _mapper) : ControllerBase
    {
                [HttpGet]
        public IActionResult Get()
        {
            var values = _massageService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
        var values = _massageService.TGetById(id);
        return Ok(values);
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _massageService.TDelete(id);
            return Ok("Hakkımzıda Alanı silindi"); 

        }
        
        [HttpPost]
        public  IActionResult Create( CreateMassageDto createMassageDto)
        {
            var newValues = _mapper.Map<Massage>(createMassageDto);
            _massageService.TCreat(newValues);
            return Ok("Hakkımzıda alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateMassageDto updateMassageDto)
        {
            var value =  _mapper .Map<Massage>(updateMassageDto);
            _massageService.TUpdate(value);
            return Ok("Hakkımda alanı güncelendi");

    }
 }
}
