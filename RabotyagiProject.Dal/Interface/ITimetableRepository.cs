using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface ITimetableRepository
{
    public List<TimetableDto> GetAllTimetable();
    public List<TimetableDto> GetAllTimetableByWorkerId(int workerId);
    public void AddNewTimetable(TimetableDto newDto);
    public void UpdateTimetableById(TimetableDto updatedDto);
}