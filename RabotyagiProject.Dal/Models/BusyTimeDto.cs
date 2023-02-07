namespace RabotyagiProject.Dal.Models;

public class BusyTimeDto
{
    public int Id { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public int TimetableId { get; set; }
    public bool IsDeleted { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is BusyTimeDto dto &&
               Id == dto.Id &&
               StartTime.Equals(dto.StartTime) &&
               EndTime.Equals(dto.EndTime) &&
               TimetableId == dto.TimetableId &&
               IsDeleted == dto.IsDeleted;
    }
}