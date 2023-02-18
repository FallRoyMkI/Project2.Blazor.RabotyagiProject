using RabotyagiProject.Dal.Options;
using System.Reflection;

namespace RabotyagiProject.Dal.Models;

public class OrderDto
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public bool IsCompleted { get; set; }
    public string Adress { get; set; }
    public DateTime Date { get; set; }
    public int? Cost { get; set; }
    public Rate? Rate { get; set; }
    public string? Report { get; set; }
    public List<ServiceWorkerDto> Services { get; set; } = new List<ServiceWorkerDto>();
    public bool IsDeleted { get; set; } = false;

    public override bool Equals(object? obj)
    {
        return obj is OrderDto dto &&
               Id == dto.Id &&
               ClientId == dto.ClientId &&
               IsCompleted == dto.IsCompleted &&
               Adress == dto.Adress &&
               Date == dto.Date &&
               Cost == dto.Cost &&
               Rate == dto.Rate &&
               Report == dto.Report &&
               Services.SequenceEqual(dto.Services) &&
               IsDeleted == dto.IsDeleted;
    }
}