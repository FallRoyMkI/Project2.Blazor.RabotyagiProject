namespace RabotyagiProject.Bll.Models
{
    public class OrderServiceWorkerOutputModel
    {
        public int OrderId { get; set; }
        public int ServiceId { get; set; }
        public int? WorkerId { get; set; }
        public int Workload { get; set; }
    }
}
