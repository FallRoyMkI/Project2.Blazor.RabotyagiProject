namespace RabotyagiProject.Bll.Models;

public class TimetableInputModel
{
    public int Id { get; set; }
    public int WorkerId { get; set; }
    public int WorkingDayId { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is TimetableInputModel model &&
               Id == model.Id &&
               WorkerId == model.WorkerId &&
               WorkingDayId == model.WorkingDayId;
    }
}