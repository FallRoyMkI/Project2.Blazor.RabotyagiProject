namespace RabotyagiProject.Dal.Models;

public class ServiceDto
{
    public int Id { get; set; }
    public string Type { get; set; }
    public int? Cost { get; set; }
    public bool? IsDeleted { get; set; } = false;

    public override bool Equals(object? obj)
    {
        return obj is ServiceDto dto &&
               Id == dto.Id &&
               Type == dto.Type &&
               Cost == dto.Cost &&
               IsDeleted == dto.IsDeleted;
    }
}