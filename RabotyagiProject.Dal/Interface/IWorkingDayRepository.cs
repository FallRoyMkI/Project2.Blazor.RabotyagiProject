using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface IWorkingDayRepository
{
    public List<WorkingDayDto> GetAllWorkingDays();
    public void AddNewWorkingDay(DateTime date);
    public void UpdateWorkingDayById(WorkingDayDto updatedDto);
}