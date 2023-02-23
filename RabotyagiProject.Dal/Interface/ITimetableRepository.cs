using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface ITimetableRepository
{
    public List<TimetableDto> GetAllTimetable();
    public List<TimetableDto> GetAllTimetableByWorkerId(int workerId);
    public void AddNewTimetable(int workerId, int workingDayId);
    public void UpdateTimetableById(TimetableDto updatedDto);
}