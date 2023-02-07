namespace RabotyagiProject.Bll.Models
{
    public class BusyTimeOutputModel
    {
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int TimetableId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is BusyTimeOutputModel model &&
                   StartTime.Equals(model.StartTime) &&
                   EndTime.Equals(model.EndTime) &&
                   TimetableId == model.TimetableId;
        }
    }
}
