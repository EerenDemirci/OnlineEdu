using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOS.SubscriberDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController(IGenericService<Subscriber> _subscriberService,IMapper _mapper) : ControllerBase
    {
                [HttpGet]
        public IActionResult Get()
        {
            var values = _subscriberService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
        var values = _subscriberService.TGetById(id);
        return Ok(values);
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _subscriberService.TDelete(id);
            return Ok("Hakkımzıda Alanı silindi"); 

        }
        
        [HttpPost]
        public  IActionResult Create( CreateSubcriberDto createSubcriberDto)
        {
            var newValues = _mapper.Map<Subscriber>(createSubcriberDto);
            _subscriberService.TCreat(newValues);
            return Ok("Hakkımzıda alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateSubcriberDto updateSubscriberDto)
        {
            var value =  _mapper .Map<Subscriber>(updateSubscriberDto);
            _subscriberService.TUpdate(value);
            return Ok("Hakkımda alanı güncelendi");

    }
 }
}
