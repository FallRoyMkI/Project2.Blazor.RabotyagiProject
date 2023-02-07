namespace RabotyagiProject.Dal.Models;

public class BusyTimeDto
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int TimetableId { get; set; }
    public bool IsDeleted { get; set; }
}