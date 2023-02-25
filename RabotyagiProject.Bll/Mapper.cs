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
                cfg.CreateMap<BusyTimeOutputModel, BusyTimeInputModel>();
                cfg.CreateMap<BusyTimeInputModel, BusyTimeDto>();

                cfg.CreateMap<ClientDto, ClientOutputModel>();
                cfg.CreateMap<ClientOutputModel, ClientInputModel>();
                cfg.CreateMap<ClientInputModel, ClientDto>();

                cfg.CreateMap<OrderDto, OrderOutputModel>();
                cfg.CreateMap<OrderOutputModel, OrderInputModel>();
                cfg.CreateMap<OrderInputModel, OrderDto>();

                cfg.CreateMap<ServiceDto, ServiceOutputModel>();
                cfg.CreateMap<ServiceOutputModel, ServiceInputModel>();
                cfg.CreateMap<ServiceInputModel, ServiceDto>();

                cfg.CreateMap<ServiceWorkerDto, ServiceWorkerOutputModel>();
                cfg.CreateMap<ServiceWorkerOutputModel, ServiceWorkerInputModel>();
                cfg.CreateMap<ServiceWorkerInputModel, ServiceWorkerDto>();

                cfg.CreateMap<TimetableDto, TimetableOutputModel>();
                cfg.CreateMap<TimetableOutputModel, TimetableInputModel>();
                cfg.CreateMap<TimetableInputModel, TimetableDto>();

                cfg.CreateMap<WorkerDto, WorkerOutputModel>();
                cfg.CreateMap<WorkerOutputModel, WorkerInputModel>();
                cfg.CreateMap<WorkerInputModel, WorkerDto>();

                cfg.CreateMap<WorkingDayDto, WorkingDayOutputModel>();
                cfg.CreateMap<WorkingDayOutputModel, WorkingDayInputModel>();
                cfg.CreateMap<WorkingDayInputModel, WorkingDayDto>();
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

    public ClientDto MapClientInputModelToClientDto(ClientInputModel client)
    {
        return _configuration.CreateMapper().Map<ClientDto>(client);
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

    public BusyTimeDto MapBusyTimeInputModelToBusyTimeDto(BusyTimeInputModel bt)
    {
        return _configuration.CreateMapper().Map<BusyTimeDto>(bt);
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

    public OrderDto MapOrderInputModelToOrderDto(OrderInputModel order)
    {
        return _configuration.CreateMapper().Map<OrderDto>(order);
    }

    public OrderInputModel MapOrderOutputModelToOrderInputModel(OrderOutputModel order)
    {
        return _configuration.CreateMapper().Map<OrderInputModel>(order);
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

    public ServiceDto MapServiceInputModelToServiceDto(ServiceInputModel service)
    {
        return _configuration.CreateMapper().Map<ServiceDto>(service);
    }
    #endregion

    #region Timetable
    public List<TimetableOutputModel> MapTimetableDtoListToTimetableOutputModelList(List<TimetableDto> tts)
    {
        return _configuration.CreateMapper().Map<List<TimetableOutputModel>>(tts);
    }

    public TimetableDto MapTimetableInputModelToTimetableDto(TimetableInputModel tt)
    {
        return _configuration.CreateMapper().Map<TimetableDto>(tt);
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

    public WorkerDto MapWorkerInputModelToWorkerDto(WorkerInputModel worker)
    {
        return _configuration.CreateMapper().Map<WorkerDto>(worker);
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

    public WorkingDayDto MapWorkingDayInputModelToWorkingDayDto(WorkingDayInputModel wd)
    {
        return _configuration.CreateMapper().Map<WorkingDayDto>(wd);
    }
    #endregion

    public ServiceWorkerDto MapServiceWorkerInputModelToServiceWorkerDto(ServiceWorkerInputModel service)
    {
        return _configuration.CreateMapper().Map<ServiceWorkerDto>(service);
    }

    public ServiceInputModel MapServiceOutputModelToServiceInputModel(ServiceOutputModel service)
    {
        return _configuration.CreateMapper().Map<ServiceInputModel>(service);
    }
}