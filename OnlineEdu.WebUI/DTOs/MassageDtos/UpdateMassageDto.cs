using System;

namespace OnlineEdu.WebUI.DTOs.DTOS.MassageDtos;

public class UpdateMassageDto
{


    public int MassageId { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
}
