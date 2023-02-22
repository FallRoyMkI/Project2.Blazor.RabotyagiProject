using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface IBusyTimeRepository
{
    public List<BusyTimeDto> GetAllBusyTime();
    public List<BusyTimeDto> GetAllBusyTimeByTimetableId(int timetableId);
    public BusyTimeDto GetBusyTimeById(int id);
    public void AddNewBusyTime(BusyTimeDto newDto);
    public void UpdateBusyTimeById(BusyTimeDto updatedDto);
}