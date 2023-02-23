namespace RabotyagiProject.Bll.Models;

public class ClientInputModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public List<OrderInputModel> Orders { get; set; } = new();

    public override bool Equals(object? obj)
    {
        return obj is ClientInputModel model &&
               Id == model.Id &&
               Name == model.Name &&
               Phone == model.Phone &&
               Mail == model.Mail &&
               Orders.SequenceEqual(model.Orders);
    }
}