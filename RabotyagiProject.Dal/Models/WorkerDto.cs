﻿namespace RabotyagiProject.Dal.Models;

public class WorkerDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public List<ServiceDto> Service { get; set; } = new List<ServiceDto>();
    public bool IsDeleted { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is WorkerDto dto &&
               Id == dto.Id &&
               Name == dto.Name &&
               Phone == dto.Phone &&
               Mail == dto.Mail &&
               EqualityComparer<List<ServiceDto>>.Default.Equals(Service, dto.Service) &&
               IsDeleted == dto.IsDeleted;
    }
}