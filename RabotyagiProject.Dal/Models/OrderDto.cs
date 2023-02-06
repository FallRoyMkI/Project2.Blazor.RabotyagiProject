using RabotyagiProject.Dal.Options;

namespace RabotyagiProject.Dal.Models;

public class OrderDto
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public bool IsCompleted { get; set; }
    public string Adress { get; set; }
    public DateTime Date { get; set; }
    public int? Cost { get; set; }
    public Rate Rate { get; set; }
    public string Report { get; set; }
    public List<ServiceWorkerDto> Services { get; set; } = new List<ServiceWorkerDto>();
    public bool IsDeleted { get; set; }

}