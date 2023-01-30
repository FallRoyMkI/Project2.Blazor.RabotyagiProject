namespace RabotyagiProject.Dal.Models;

public class ClientDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public List<OrderDto> Orders { get; set; }
}