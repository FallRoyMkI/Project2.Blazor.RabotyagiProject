namespace RabotyagiProject.Dal.Models;

public class ServiceWorkerDto
{
    public int ServiceId { get; set; }
    public int? WorkerId { get; set; }
    public int Workload { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is ServiceWorkerDto dto &&
               ServiceId == dto.ServiceId &&
               WorkerId == dto.WorkerId &&
               Workload == dto.Workload;
    }
}