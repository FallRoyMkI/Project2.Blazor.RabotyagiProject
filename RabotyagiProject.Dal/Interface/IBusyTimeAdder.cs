namespace RabotyagiProject.Dal.Interface;

public interface IBusyTimeAdder
{
    public void AddNewBusyTime(TimeSpan startTime, TimeSpan endTime, int timetableId);
}