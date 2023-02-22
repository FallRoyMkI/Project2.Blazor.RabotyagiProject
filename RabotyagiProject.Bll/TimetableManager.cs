using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Bll;

public class TimetableManager
{
    private readonly MapperX _mapperX = new();
    private readonly ITimetableRepository _repository;

    public TimetableManager(ITimetableRepository? repository = null)
    {
        _repository = repository ?? new TimetableRepository();
    }


    public List<TimetableOutputModel> GetAllTimetable()
    {
        return _mapperX.MapTimetableDtoListToTimetableOutputModelList(_repository.GetAllTimetable());
    }

    public List<TimetableOutputModel> GetAllTimetableByWorkerId(int workerId)
    {
        return _mapperX.MapTimetableDtoListToTimetableOutputModelList(_repository.GetAllTimetableByWorkerId(workerId));
    }

    public void AddNewTimetable(TimetableInputModel model)
    {
        _repository.AddNewTimetable(_mapperX.MapTimetableInputModelToTimetableDto(model));
    }

    public void UpdateTimetableById(TimetableInputModel model)
    {
        _repository.UpdateTimetableById(_mapperX.MapTimetableInputModelToTimetableDto(model));
    }
}