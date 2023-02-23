namespace RabotyagiProject.Bll.Models;

public class ServiceWorkerOutputModel
{
    public int ServiceId { get; set; }
    public int? WorkerId { get; set; }
    public int Workload { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is ServiceWorkerOutputModel model &&
               ServiceId == model.ServiceId &&
               WorkerId == model.WorkerId &&
               Workload == model.Workload;
    }
}