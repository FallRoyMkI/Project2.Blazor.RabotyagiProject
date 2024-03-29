﻿namespace RabotyagiProject.Bll.Models;

public class WorkerInputModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public List<ServiceInputModel> Service { get; set; } = new();
    public bool IsDeleted { get; set; } = false;

    public override bool Equals(object? obj)
    {
        return obj is WorkerInputModel model &&
               Id == model.Id &&
               Name == model.Name &&
               Phone == model.Phone &&
               Mail == model.Mail &&
               Service.SequenceEqual(model.Service) &&
               IsDeleted == model.IsDeleted;
    }
}