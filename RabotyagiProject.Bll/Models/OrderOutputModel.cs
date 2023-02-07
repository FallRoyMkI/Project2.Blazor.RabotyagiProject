using RabotyagiProject.Bll.Options;
namespace RabotyagiProject.Bll.Models;


public class OrderOutputModel
{
    public int ClientId { get; set; }
    public bool IsCompleted { get; set; }
    public string Adress { get; set; }
    public DateTime Date { get; set; }
    public int? Cost { get; set; }
    public Rate Rate { get; set; }
    public string Report { get; set; }
    public List<ServiceWorkerOutputModel> Services { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is OrderOutputModel model &&
               ClientId == model.ClientId &&
               IsCompleted == model.IsCompleted &&
               Adress == model.Adress &&
               Date == model.Date &&
               Cost == model.Cost &&
               Rate == model.Rate &&
               Report == model.Report &&
               EqualityComparer<List<ServiceWorkerOutputModel>>.Default.Equals(Services, model.Services);
    }
}

