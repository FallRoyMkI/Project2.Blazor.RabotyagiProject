namespace RabotyagiProject.Dal.Interface;

public interface IOrderAdder
{
    public void AddNewOrder(int clientId, string adress, DateTime date);
}