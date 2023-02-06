namespace RabotyagiProject.Dal.Interface;

public interface ITimetableAdder
{
    public void AddNewTimetable(int workerId, int workingDayId);
}