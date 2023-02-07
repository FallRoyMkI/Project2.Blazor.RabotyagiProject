namespace RabotyagiProject.Dal.Models;

public class TimetableDto
{
    public int Id { get; set; }
    public int WorkerId { get; set; }
    public int WorkingDayId { get; set; }
    public bool IsDeleted { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is TimetableDto dto &&
               Id == dto.Id &&
               WorkerId == dto.WorkerId &&
               WorkingDayId == dto.WorkingDayId &&
               IsDeleted == dto.IsDeleted;
    }
}