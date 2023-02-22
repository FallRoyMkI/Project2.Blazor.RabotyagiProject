using AutoMapper;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Bll;

public class MapperX
{
    private readonly MapperConfiguration _configuration;

    public MapperX()
    {
        _configuration = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<BusyTimeDto, BusyTimeOutputModel>();
                cfg.CreateMap<ClientDto, ClientOutputModel>();
                cfg.CreateMap<OrderDto, OrderOutputModel>();
                cfg.CreateMap<ServiceDto, ServiceOutputModel>();
                cfg.CreateMap<ServiceInputModel, ServiceDto>();
                cfg.CreateMap<ServiceWorkerDto, ServiceWorkerOutputModel>();
                cfg.CreateMap<TimetableDto, TimetableOutputModel>();
                cfg.CreateMap<WorkerDto, WorkerOutputModel>();
                cfg.CreateMap<WorkingDayDto, WorkingDayOutputModel>();
            });
    }


    #region Client
    public List<ClientOutputModel> MapClientDtoListToClientOutputModelList(List<ClientDto> clients)
    {
        return _configuration.CreateMapper().Map<List<ClientOutputModel>>(clients);
    }

    public ClientOutputModel MapClientDtoToClientOutputModel(ClientDto client)
    {
        return _configuration.CreateMapper().Map<ClientOutputModel>(client);
    }
    #endregion

    #region BusyTime
    public BusyTimeOutputModel MapBusyTimeDtoToBusyTimeOutputModel(BusyTimeDto bt)
    {
        return _configuration.CreateMapper().Map<BusyTimeOutputModel>(bt);
    }

    public List<BusyTimeOutputModel> MapBusyTimeDtoListToBusyTimeOutputModelList(List<BusyTimeDto> bts)
    {
        return _configuration.CreateMapper().Map<List<BusyTimeOutputModel>>(bts);
    }
    #endregion

    #region Order
    public List<OrderOutputModel> MapOrderDtoListToOrderOutputModelList(List<OrderDto> orders)
    {
        return _configuration.CreateMapper().Map<List<OrderOutputModel>>(orders);
    }

    public OrderOutputModel MapOrderDtoToOrderOutputModel(OrderDto order)
    {
        return _configuration.CreateMapper().Map<OrderOutputModel>(order);
    }
    #endregion

    #region Service
    public List<ServiceOutputModel> MapServiceDtoListToServiceOutputModelList(List<ServiceDto> services)
    {
        return _configuration.CreateMapper().Map<List<ServiceOutputModel>>(services);
    }

    public ServiceOutputModel MapServiceDtoToServiceOutputModel(ServiceDto service)
    {
        return _configuration.CreateMapper().Map<ServiceOutputModel>(service);
    }

    public ServiceDto MapServiceInputModelToServiceDto(ServiceInputModel model)
    {
        return _configuration.CreateMapper().Map<ServiceDto>(model);
    }
    #endregion

    #region Timetable
    public List<TimetableOutputModel> MapTimetableDtoListToTimetableOutputModelList(List<TimetableDto> tts)
    {
        return _configuration.CreateMapper().Map<List<TimetableOutputModel>>(tts);
    }
    #endregion

    #region Worker
    public List<WorkerOutputModel> MapWorkerDtoListToWorkerOutputModelList(List<WorkerDto> workers)
    {
        return _configuration.CreateMapper().Map<List<WorkerOutputModel>>(workers);
    }

    public WorkerOutputModel MapWorkerDtoToWorkerOutputModel(WorkerDto worker)
    {
        return _configuration.CreateMapper().Map<WorkerOutputModel>(worker);
    }
    #endregion

    #region WorkingDay
    public List<WorkingDayOutputModel> MapWorkingDayDtoListToWorkingDayOutputModelList(List<WorkingDayDto> wds)
    {
        return _configuration.CreateMapper().Map<List<WorkingDayOutputModel>>(wds);
    }

    public WorkingDayOutputModel MapWorkingDayDtoToWorkingDayOutputModel(WorkingDayDto wd)
    {
        return _configuration.CreateMapper().Map<WorkingDayOutputModel>(wd);
    }
    #endregion

    public BusyTimeDto MapBusyTimeInputModelToBusyTimeDto(BusyTimeInputModel busyTimeModel)
    {
        return new BusyTimeDto();
    }

    public ClientDto MapClientInputModelToClientDto(ClientInputModel clientModel)
    {
        return new ClientDto();
    }

    public OrderDto MapOrderInputModelToOrderDto(OrderInputModel clientModel)
    {
        return new OrderDto();
    }
    
    public ServiceWorkerDto MapServiceWorkerInputModelToServiceWorkerDto(ServiceWorkerInputModel clientModel)
    {
        return new ServiceWorkerDto();
    }

    public TimetableDto MapTimetableInputModelToTimetableDto(TimetableInputModel timetableModel)
    {
        return new TimetableDto();
    }

    public WorkerDto MapWorkerInputModelToWorkerDto(WorkerInputModel workerModel)
    {
        return new WorkerDto();
    }

    public WorkingDayDto MapWorkingDayInputModelToWorkingDayDto(WorkingDayInputModel workingDayModel)
    {
        return new WorkingDayDto();
    }
}