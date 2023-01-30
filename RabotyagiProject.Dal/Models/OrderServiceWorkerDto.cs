namespace RabotyagiProject.Dal.Models;

public class OrderServiceWorkerDto
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ServiceId { get; set; }
    public int? WorkerId { get; set; }
    public int Workload { get; set; }
}