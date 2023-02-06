namespace RabotyagiProject.Dal.Interface;

public interface IBusyTimeUpdater
{
    public void UpdateBusyTimeById(int id, TimeSpan startTime, TimeSpan endTime, int timetableId, bool isDeleted);
}