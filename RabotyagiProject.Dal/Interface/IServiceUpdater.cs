namespace RabotyagiProject.Dal.Interface;

public interface IServiceUpdater
{
    public void UpdateServiceById(int id, string type, bool isDeleted);
}