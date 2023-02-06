using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface ITimetableGetter
{
    public List<TimetableDto> GetAllTimetable();
    public List<TimetableDto> GetAllTimetableByWorkerId(int workerId);
}