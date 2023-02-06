namespace RabotyagiProject.Dal.Models;

public class BusyTimeDto
{
    public int Id { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public int TimetableId { get; set; }
    public bool IsDeleted { get; set; }
}