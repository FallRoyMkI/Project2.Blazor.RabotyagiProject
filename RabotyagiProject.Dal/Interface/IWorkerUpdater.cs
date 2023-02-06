namespace RabotyagiProject.Dal.Interface;

public interface IWorkerUpdater
{
    public void UpdateWorkerById(int id, string name, string phone, string mail, bool isDeleted);
}