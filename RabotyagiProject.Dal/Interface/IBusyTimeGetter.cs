using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface IBusyTimeGetter
{
    public List<BusyTimeDto> GetAllBusyTime();
    public List<BusyTimeDto> GetAllBusyTimeByTimetableId(int timetableId);
}