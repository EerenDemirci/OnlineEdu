using System;

namespace OnlineEdu.DTO.DTOS.ContactsDtos;

public class CreateContactDto
{
    public string MapUrl { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}
