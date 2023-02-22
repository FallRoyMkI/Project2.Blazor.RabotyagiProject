using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Bll;

public class BusyTimeManager
{
    private readonly MapperX _mapperX = new();
    private readonly IBusyTimeRepository _repository;

    public BusyTimeManager(IBusyTimeRepository? repository = null)
    {
        _repository = repository ?? new BusyTimeRepository();
    }


    public List<BusyTimeOutputModel> GetAllBusyTime()
    {
        return _mapperX.MapBusyTimeDtoListToBusyTimeOutputModelList(_repository.GetAllBusyTime());
    }

    public List<BusyTimeOutputModel> GetAllBusyTimeByTimetableId(int timetableId)
    {
        return _mapperX.MapBusyTimeDtoListToBusyTimeOutputModelList(
            _repository.GetAllBusyTimeByTimetableId(timetableId));
    }

    public BusyTimeOutputModel GetBusyTimeById(int id)
    {
        return _mapperX.MapBusyTimeDtoToBusyTimeOutputModel(_repository.GetBusyTimeById(id));
    }

    public void AddNewBusyTime(BusyTimeInputModel model)
    {
        _repository.AddNewBusyTime(_mapperX.MapBusyTimeInputModelToBusyTimeDto(model));
    }

    public void UpdateBusyTimeById(BusyTimeInputModel model)
    {
        _repository.UpdateBusyTimeById(_mapperX.MapBusyTimeInputModelToBusyTimeDto(model));
    }
}