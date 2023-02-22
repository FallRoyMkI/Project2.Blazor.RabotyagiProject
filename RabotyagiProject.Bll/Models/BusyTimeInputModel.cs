namespace RabotyagiProject.Bll.Models
{
    public class BusyTimeInputModel
    {
        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int TimetableId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
