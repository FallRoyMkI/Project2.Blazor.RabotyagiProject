namespace RabotyagiProject.Bll.Models
{
    public class WorkingDayOutputModel
    {
        public DateTime Date { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is WorkingDayOutputModel model &&
                   Date == model.Date;
        }
    }
}
