using System;

namespace OnlineEdu.WebUI.DTOs.ContactsDtos;

public class UpdateContactDto
{
    
    public int ContactId { get; set; }
    public string MapUrl { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

}
