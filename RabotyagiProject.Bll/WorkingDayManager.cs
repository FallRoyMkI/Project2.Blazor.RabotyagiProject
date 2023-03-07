using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal;
using RabotyagiProject.Dal.Interface;
using System.Linq;

namespace RabotyagiProject.Bll;

public class WorkingDayManager
{
    private readonly MapperX _mapperX = new();
    private readonly IWorkingDayRepository _repository;

    public WorkingDayManager(IWorkingDayRepository? repository = null)
    {
        _repository = repository ?? new WorkingDayRepository();
    }


    public List<WorkingDayOutputModel> GetAllWorkingDays()
    {
        return _mapperX.MapWorkingDayDtoListToWorkingDayOutputModelList(_repository.GetAllWorkingDays());
    }

    public WorkingDayOutputModel GetWorkingDayById(int id)
    {
        return _mapperX.MapWorkingDayDtoToWorkingDayOutputModel(_repository.GetWorkingDayById(id));
    }

    public void AddNewWorkingDay(DateTime date)
    {
        if (!new WorkingDayManager().GetAllWorkingDays()
                .Contains(new WorkingDayManager().GetAllWorkingDays().Find(x => x.Date == date)))
        {
            _repository.AddNewWorkingDay(date);
        }
    }

    public void UpdateWorkingDayById(WorkingDayInputModel model)
    {
        _repository.UpdateWorkingDayById(_mapperX.MapWorkingDayInputModelToWorkingDayDto(model));
    }
}