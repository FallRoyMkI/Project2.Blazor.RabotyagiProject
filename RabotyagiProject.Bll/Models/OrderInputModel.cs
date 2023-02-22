using RabotyagiProject.Dal.Options;
namespace RabotyagiProject.Bll.Models;

public class OrderInputModel
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public bool IsCompleted { get; set; }
    public string Adress { get; set; }
    public DateTime Date { get; set; }
    public int? Cost { get; set; }
    public Rate? Rate { get; set; }
    public string Report { get; set; }
    public List<ServiceWorkerInputModel> Services { get; set; } = new();

    public override bool Equals(object? obj)
    {
        return obj is OrderInputModel model &&
               Id == model.Id &&
               ClientId == model.ClientId &&
               IsCompleted == model.IsCompleted &&
               Adress == model.Adress &&
               Date == model.Date &&
               Cost == model.Cost &&
               Rate == model.Rate &&
               Report == model.Report &&
               EqualityComparer<List<ServiceWorkerInputModel>>.Default.Equals(Services, model.Services);
    }
}