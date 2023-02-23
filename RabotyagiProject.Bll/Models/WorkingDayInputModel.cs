namespace RabotyagiProject.Bll.Models;

public class WorkingDayInputModel
{
    public int Id { get; set; }
    public DateTime Date { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is WorkingDayInputModel model
               && Id == model.Id &&
               Date == model.Date;
    }
}