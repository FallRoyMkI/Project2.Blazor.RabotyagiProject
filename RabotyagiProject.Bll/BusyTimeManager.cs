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
        return _mapperX.MapBusyTimeDtoListToBusyTimeOutputModelList(_repository.GetAllBusyTimeByTimetableId(timetableId));
    }

    public BusyTimeOutputModel GetBusyTimeById(int id)
    {
        return _mapperX.MapBusyTimeDtoToBusyTimeOutputModel(_repository.GetBusyTimeById(id));
    }

    public void AddNewBusyTime(BusyTimeInputModel model)
    {
        if (model.StartTime >= TimeSpan.Parse("00:00:00.0000000") &&
            model.StartTime <= TimeSpan.Parse("23:59:59.9999999") &&
            model.EndTime >= TimeSpan.Parse("00:00:00.0000000") &&
            model.EndTime <= TimeSpan.Parse("23:59:59.9999999") &&
            model.StartTime < model.EndTime)
        {
            var isCrossOtherTime = false;
            var timeDelay = TimeSpan.Parse("00:30:00");
            foreach (var time in GetAllBusyTimeByTimetableId(model.TimetableId).
                         Where(time => !(model.StartTime - timeDelay > time.EndTime || model.EndTime + timeDelay < time.StartTime)))
            {
                isCrossOtherTime = true;
            }

            if (!isCrossOtherTime)
            {
                _repository.AddNewBusyTime(_mapperX.MapBusyTimeInputModelToBusyTimeDto(model));
            }
        }
    }

    public void UpdateBusyTimeById(BusyTimeInputModel model)
    {
        _repository.UpdateBusyTimeById(_mapperX.MapBusyTimeInputModelToBusyTimeDto(model));
    }
}