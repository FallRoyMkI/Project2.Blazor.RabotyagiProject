namespace RabotyagiProject.Bll.Models
{
    public class BusyTimeOutputModel
    {
        public int Id { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int TimetableId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is BusyTimeOutputModel model &&
                   Id == model.Id &&
                   StartTime.Equals(model.StartTime) &&
                   EndTime.Equals(model.EndTime) &&
                   TimetableId == model.TimetableId;
        }
    }
}
