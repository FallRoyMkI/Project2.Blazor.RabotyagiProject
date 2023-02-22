namespace RabotyagiProject.Bll.Models;

public class BusyTimeInputModel
{
    public int Id { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public int TimetableId { get; set; }
    public bool IsDeleted { get; set; } = false;

    public override bool Equals(object? obj)
    {
        return obj is BusyTimeInputModel model &&
               Id == model.Id &&
               StartTime.Equals(model.StartTime) &&
               EndTime.Equals(model.EndTime) &&
               TimetableId == model.TimetableId &&
               IsDeleted == model.IsDeleted;
    }
}