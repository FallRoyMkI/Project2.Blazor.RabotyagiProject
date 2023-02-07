namespace RabotyagiProject.Bll.Models
{
    public class TimetableOutputModel
    {
        public int WorkerId { get; set; }
        public int WorkingDayId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is TimetableOutputModel model &&
                   WorkerId == model.WorkerId &&
                   WorkingDayId == model.WorkingDayId;
        }
    }
}
