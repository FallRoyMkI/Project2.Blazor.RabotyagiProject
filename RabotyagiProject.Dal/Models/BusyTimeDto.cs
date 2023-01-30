namespace RabotyagiProject.Dal.Models;

public class BusyTimeDto
{
    public int Id { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public int TimetableId { get; set; }
}