using System;

namespace OnlineEdu.WebUI.DTOs.MassageDtos;

public class ResultMassageDto
{
    
    public int MassageId { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }

}
