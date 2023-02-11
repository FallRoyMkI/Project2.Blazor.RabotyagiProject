using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Options;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal;
using AutoMapper;
namespace RabotyagiProject.Bll
{
    public class Manager
    {
        MapperX _mapperX = new MapperX();

        public IBusyTimeRepository BusyTimeRepository { get; set; }
        public IClientRepository ClientRepository { get; set; }
        public IServiceRepository ServiceRepository { get; set; }
        public ITimetableRepository TimetableRepository { get; set; }
        public IWorkerRepository WorkerRepository { get; set; }
        public IWorkingDayRepository WorkingDayRepository { get; set; }

        //public Manager(IBusyTimeRepository repository = null)
        //{
        //    if (repository == null)
        //    {
        //        BusyTimeRepository = new BusyTimeRepository();
        //    }
        //    else
        //    {
        //        BusyTimeRepository = repository;
        //    }

        //    _mapperX = new MapperX();
        //}

        public List<BusyTimeOutputModel> GetAllBusyTime()
        {
            var allBusy = BusyTimeRepository.GetAllBusyTime();
            var result = _mapperX.MapBusyTimeDtoToListBusyTimeOutputModel(allBusy);
            return result;
        }

        public List<BusyTimeOutputModel> GetAllBusyTimeByTimetableId(int timetableId)
        {
            var allBusy = BusyTimeRepository.GetAllBusyTimeByTimetableId(timetableId);
            var result = _mapperX.MapBusyTimeDtoToListBusyTimeOutputModel(allBusy);
            return result;
        }

        public List<ClientOutputModel> GetAllClients()
        {
            var clients = ClientRepository.GetAllClients();
            var result = _mapperX.MapClientDtoToListClientOutputModel(clients);
            return result;
        }

        public ClientOutputModel GetClientById(int Id)
        {
            var client = ClientRepository.GetClientById(Id);
            var result = _mapperX.MapClientDtoToClientOutputModelById(client);
            return result;
        }

        public List<ServiceOutputModel> GetAllServices()
        {
            var services = ServiceRepository.GetAllServices();
            var result = _mapperX.MapServiceDtoToServiceOutputModel(services);
            return result;
        }

        public ServiceOutputModel GetServiceById(int id)
        {
            var serviceById = ServiceRepository.GetServiceById(id);
            var result = _mapperX.MapServiceDtoToServiceOutputModelById(serviceById);
            return result;
        }

        public List<TimetableOutputModel> GetAllTimetable()
        {
            var timetable = TimetableRepository.GetAllTimetable();
            var result = _mapperX.MapTimetableDtoToListTimetableOutputModel(timetable);
            return result;

        }

        public List<TimetableOutputModel> GetAllTimetableByWorkerId(int workerId)
        {
            var timetables = TimetableRepository.GetAllTimetableByWorkerId(workerId);
            var result = _mapperX.MapTimetableDtoToListTimetableOutputModelById(timetables);
            return result;
        }

        public List<WorkerOutputModel> GetAllWorkers()
        {
            var workers = WorkerRepository.GetAllWorkers();
            var result = _mapperX.MapWorkerDtoToListWorkerOutputModel(workers);
            return result;
        }

        public WorkerOutputModel GetWorkerById(int Id)
        {
            var workers = WorkerRepository.GetWorkerById(Id);
            var result = _mapperX.MapWorkerDtoToWorkerOutputModelById(workers);
            return result;
        }

        public List<WorkingDayOutputModel> GetAllWorkingDays()
        {
            var workingDays = WorkingDayRepository.GetAllWorkingDays();
            var result = _mapperX.WorkingDayToListWorkingDayOutputModel(workingDays);
            return result;
        }
    }
}