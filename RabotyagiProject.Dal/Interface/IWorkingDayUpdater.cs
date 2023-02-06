namespace RabotyagiProject.Dal.Interface;

public interface IWorkingDayUpdater
{
    public void UpdateWorkingDayById(int id, DateTime date);
}