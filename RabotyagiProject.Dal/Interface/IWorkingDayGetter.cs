using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface IWorkingDayGetter
{
    public List<WorkingDayDto> GetAllWorkingDays();
}