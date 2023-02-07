using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Options;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal;
using AutoMapper;
namespace RabotyagiProject.Bll
{
    public class Manager
    {
        MapperX _mapperX = new MapperX();

        public List<BusyTimeOutputModel> GetAllBusyTime()
        {
            BusyTimeRepository br = new BusyTimeRepository();
            var allBusy = br.GetAllBusyTime();
            var result = _mapperX.MapBusyTimeDtoToListBusyTimeOutputModel(allBusy);
            return result;
        }
        public List<BusyTimeOutputModel> GetAllBusyTimeByTimetableId(int timetableId)
        {
            BusyTimeRepository br = new BusyTimeRepository();
            var allBusy = br.GetAllBusyTimeByTimetableId(timetableId);
            var result = _mapperX.MapBusyTimeDtoToListBusyTimeOutputModel(allBusy);
            return result;
        }

        public List<ClientOutputModel> GetAllClients()
        {
            ClientRepository cr = new ClientRepository();
            var clients = cr.GetAllClients();
            var result = _mapperX.MapClientDtoToListClientOutputModel(clients);
            return result;
        }

        public ClientOutputModel GetClientById(int Id)
        {
            ClientRepository cr = new ClientRepository();
            var client = cr.GetClientById(Id);
            var result = _mapperX.MapClientDtoToClientOutputModelById(client);
            return result;
        }

        public List<OrderOutputModel> GetAllOrders()
        {
            OrderRepository or = new OrderRepository();
            var orders = or.GetAllOrders();
            var result = _mapperX.MapOrderDtoToListOrderOutputModel(orders);
            return result;
        }

        public List<OrderOutputModel> GetAllOrdersByClientId(int id)
        {
            OrderRepository or = new OrderRepository();
            var сlientOrders = or.GetAllOrdersByClientId(id);
            var result = _mapperX.MapOrderDtoToListOrderOutputModelById(сlientOrders);
            return result;
        }

        public List<OrderOutputModel> GetAllCompletedOrders()
        {
            OrderRepository or = new OrderRepository();
            var completedOrders = or.GetAllCompletedOrders();
            var result = _mapperX.MapOrderDtoToListOrderOutputModel(completedOrders);
            return result;
        }

        public List<OrderOutputModel> GetAllNotCompletedOrders()
        {
            OrderRepository or = new OrderRepository();
            var notCompletedOrders = or.GetAllNotCompletedOrders();
            var result = _mapperX.MapOrderDtoToListOrderOutputModel(notCompletedOrders);
            return result;
        }

        public OrderOutputModel GetOrderById(int id)
        {
            OrderRepository or = new OrderRepository();
            var orders = or.GetOrderById(id);
            var result = _mapperX.MapOrderDtoToOrderOutputModelById(orders);
            return result;
        }

        public List<ServiceOutputModel> GetAllServices()
        {
            ServiceRepository sr = new ServiceRepository();
            var services = sr.GetAllServices();
            var result = _mapperX.MapServiceDtoToServiceOutputModel(services);
            return result;
        }

        public ServiceOutputModel GetServiceById(int id)
        {
            ServiceRepository sr = new ServiceRepository();
            var serviceById = sr.GetServiceById(id);
            var result = _mapperX.MapServiceDtoToServiceOutputModelById(serviceById);
            return result;
        }

        public List<TimetableOutputModel> GetAllTimetable()
        {
            TimetableRepository tr = new TimetableRepository();
            var timetable = tr.GetAllTimetable();
            var result = _mapperX.MapTimetableDtoToListTimetableOutputModel(timetable);
            return result;

        }

        public List<TimetableOutputModel> GetAllTimetableByWorkerId(int workerId)
        {
            TimetableRepository tr = new TimetableRepository();
            var timetables = tr.GetAllTimetableByWorkerId(workerId);
            var result = _mapperX.MapTimetableDtoToListTimetableOutputModelById(timetables);
            return result;
        }

        public List<WorkerOutputModel> GetAllWorkers()
        {
            WorkerRepository wr = new WorkerRepository();
            var workers = wr.GetAllWorkers();
            var result = _mapperX.MapWorkerDtoToListWorkerOutputModel(workers);
            return result;
        }

        public WorkerOutputModel GetWorkerById(int Id)
        {
            WorkerRepository wr = new WorkerRepository();
            var workers = wr.GetWorkerById(Id);
            var result = _mapperX.MapWorkerDtoToWorkerOutputModelById(workers);
            return result;
        }

        public List<WorkingDayOutputModel> GetAllWorkingDays()
        {
            WorkingDayRepository wdr = new WorkingDayRepository();
            var workingDays = wdr.GetAllWorkingDays();
            var result = _mapperX.WorkingDayToListWorkingDayOutputModel(workingDays);
            return result;
        }
    }
}