namespace RabotyagiProject.Bll.Models
{
    public class WorkingDayOutputModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is WorkingDayOutputModel model
                   && Id == model.Id &&
                   Date == model.Date;
        }
    }
}
