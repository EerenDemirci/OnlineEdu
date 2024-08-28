using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOS.ContactsDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController(IGenericService<Contact> _contactService, IMapper _mapper): ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
        var values = _contactService.TGetById(id);
        return Ok(values);
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _contactService.TDelete(id);
            return Ok("iletişim alanı Alanı silindi"); 

        }
        
        [HttpPost]
        public  IActionResult Create( CreateContactDto createContactDto)
        {
            var newValues = _mapper.Map<Contact>(createContactDto);
            _contactService.TCreat(newValues);
            return Ok("iletişim alanı alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateContactDto updateContactDto)
        {
            var value =  _mapper .Map<Contact>(updateContactDto);
            _contactService.TUpdate(value);
            return Ok("iletişim alanı alan güncelendi");
    }
   }
}
