namespace RabotyagiProject.Dal.Models;

public class WorkerDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public List<ServiceDto> Service { get; set; } = new List<ServiceDto>();
    public bool IsDeleted { get; set; }
}