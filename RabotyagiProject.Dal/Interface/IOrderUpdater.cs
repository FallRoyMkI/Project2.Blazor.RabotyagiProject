namespace RabotyagiProject.Dal.Interface;

public interface IOrderUpdater
{
    public void UpdateOrderById(int id, int clientId, bool isCompleted, string adress, DateTime date, int cost,
        Options.Rate rate, string report, bool isDeleted);
}