using System;

namespace OnlineEdu.DTO.DTOS.MassageDto;

public class CreateMassageDto
{

    public string Email { get; set; }
    public string Name { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }

}
