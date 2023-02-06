namespace RabotyagiProject.Dal.Interface;

public interface ITimetableUpdater
{
    public void UpdateTimetableById(int id, int workerId, int workingDayId, bool isDeleted);
}