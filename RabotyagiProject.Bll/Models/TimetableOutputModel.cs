namespace RabotyagiProject.Bll.Models;

public class TimetableOutputModel
{
    public int Id { get; set; }
    public int WorkerId { get; set; }
    public int WorkingDayId { get; set; }
    public bool? IsDeleted { get; set; } = false;

    public override bool Equals(object? obj)
    {
        return obj is TimetableOutputModel model &&
               Id == model.Id &&
               WorkerId == model.WorkerId &&
               WorkingDayId == model.WorkingDayId &&
               IsDeleted == model.IsDeleted;
    }
}