namespace RabotyagiProject.Dal.Interface;

public interface IClientUpdater
{
    public void UpdateClientById(int id, string name, string phone, string mail, bool isDeleted);
}