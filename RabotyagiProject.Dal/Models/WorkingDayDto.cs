namespace RabotyagiProject.Dal.Models;

public class WorkingDayDto
{
    public int Id { get; set; }
    public DateTime Date { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is WorkingDayDto dto &&
               Id == dto.Id &&
               Date == dto.Date;
    }
}