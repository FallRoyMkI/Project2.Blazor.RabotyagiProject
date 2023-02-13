namespace RabotyagiProject.Dal.Models;

public class ClientDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public List<OrderDto> Orders { get; set; } = new List<OrderDto>();
    public bool IsDeleted { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is ClientDto dto &&
               Id == dto.Id &&
               Name == dto.Name &&
               Phone == dto.Phone &&
               Mail == dto.Mail &&
               Orders.SequenceEqual(dto.Orders)&&
               IsDeleted == dto.IsDeleted;
    }
}