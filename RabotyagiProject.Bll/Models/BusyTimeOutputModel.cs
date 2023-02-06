namespace RabotyagiProject.Bll.Models
{
    public class BusyTimeOutputModel
    {
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int TimetableId { get; set; }
    }
}
