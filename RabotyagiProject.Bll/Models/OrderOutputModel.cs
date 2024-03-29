﻿using RabotyagiProject.Dal.Options;

namespace RabotyagiProject.Bll.Models;

public class OrderOutputModel
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public bool IsCompleted { get; set; }
    public string Adress { get; set; }
    public DateTime Date { get; set; }
    public int? Cost { get; set; }
    public Rate? Rate { get; set; }
    public string? Report { get; set; }
    public List<ServiceWorkerOutputModel> Services { get; set; } = new();

    public override bool Equals(object? obj)
    {
        return obj is OrderOutputModel model &&
               Id == model.Id &&
               ClientId == model.ClientId &&
               IsCompleted == model.IsCompleted &&
               Adress == model.Adress &&
               Date == model.Date &&
               Cost == model.Cost &&
               Rate == model.Rate &&
               Report == model.Report &&
               Services.SequenceEqual(model.Services);
        
    }
}