using AutoMapper;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal.Options;

namespace RabotyagiProject.Bll
{
    public class MapperX
    {
        private MapperConfiguration _configuration;

        public MapperX()
        {
            _configuration = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<ClientDto, ClientOutputModel>();
                    cfg.CreateMap<BusyTimeDto, BusyTimeOutputModel>();
                    cfg.CreateMap<OrderDto, OrderOutputModel>();
                    cfg.CreateMap<ServiceDto, ServiceOutputModel>();
                    cfg.CreateMap<TimetableDto, TimetableOutputModel>();
                    cfg.CreateMap<WorkerDto, WorkerOutputModel>();
                    cfg.CreateMap<WorkingDayDto, WorkingDayOutputModel>();
                    cfg.CreateMap<ServiceWorkerDto, ServiceWorkerOutputModel>();
                });
        }

        public List<ClientOutputModel> MapClientDtoToListClientOutputModel(List<ClientDto> clients)
        {
            return _configuration.CreateMapper().Map<List<ClientOutputModel>>(clients);
        }

        public ClientOutputModel MapClientDtoToClientOutputModelById(ClientDto client)
        {
            return _configuration.CreateMapper().Map<ClientOutputModel>(client);
        }

        public BusyTimeOutputModel MapBusyTimeDtoToBusyTimeOutputModel(BusyTimeDto busy)
        {
            return _configuration.CreateMapper().Map<BusyTimeOutputModel>(busy);
        }

        public List<BusyTimeOutputModel> MapBusyTimeDtoToListBusyTimeOutputModel(List<BusyTimeDto> busy)
        {
            return _configuration.CreateMapper().Map<List<BusyTimeOutputModel>>(busy);
        }

        public List<OrderOutputModel> MapOrderDtoToListOrderOutputModel(List<OrderDto> orders)
        {
            return _configuration.CreateMapper().Map<List<OrderOutputModel>>(orders);
        }

        public List<OrderOutputModel> MapOrderDtoToListOrderOutputModelById(List<OrderDto> id)
        {
            return _configuration.CreateMapper().Map<List<OrderOutputModel>>(id);
        }

        public OrderOutputModel MapOrderDtoToOrderOutputModelById(OrderDto orders)
        {
            return _configuration.CreateMapper().Map<OrderOutputModel>(orders);
        }

        public List<ServiceOutputModel> MapServiceDtoToServiceOutputModel(List<ServiceDto> services)
        {
            return _configuration.CreateMapper().Map<List<ServiceOutputModel>>(services);
        }

        public ServiceOutputModel MapServiceDtoToServiceOutputModelById(ServiceDto id)
        {
            return _configuration.CreateMapper().Map<ServiceOutputModel>(id);
        }

        public List<TimetableOutputModel> MapTimetableDtoToListTimetableOutputModel(List<TimetableDto> timetables)
        {
            return _configuration.CreateMapper().Map<List<TimetableOutputModel>>(timetables);
        }
        
        public List<TimetableOutputModel> MapTimetableDtoToListTimetableOutputModelById(List<TimetableDto> timetables)
        {
            return _configuration.CreateMapper().Map<List<TimetableOutputModel>>(timetables);
        }

        public List<WorkerOutputModel> MapWorkerDtoToListWorkerOutputModel(List<WorkerDto> workers)
        {
            return _configuration.CreateMapper().Map<List<WorkerOutputModel>>(workers);
        }

        public WorkerOutputModel MapWorkerDtoToWorkerOutputModelById(WorkerDto id) 
        {
            return _configuration.CreateMapper().Map<WorkerOutputModel>(id);
        }

        public List<WorkingDayOutputModel> WorkingDayToListWorkingDayOutputModel(List<WorkingDayDto> workingDays)
        {
            return _configuration.CreateMapper().Map<List<WorkingDayOutputModel>>(workingDays);
        }        
    }
}
