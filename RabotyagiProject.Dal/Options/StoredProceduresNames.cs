namespace RabotyagiProject.Dal.Options;

public static class StoredProceduresNames
{
    public const string AddNewBusyTime = "BusyTime_AddNew";
    public const string GetAllBusyTime = "BusyTIme_GetAll";
    public const string GetBusyTimeById = "BusyTIme_GetById";
    public const string GetAllBusyTimeByTimetableId = "BusyTime_GetAllByTimetableId";
    public const string UpdateBusyTimeById = "BusyTime_UpdateById";
    public const string AddNewClient = "Client_AddNew";
    public const string GetAllClients = "Client_GetAll";
    public const string GetClientById = "Client_GetById";
    public const string UpdateClientById = "Client_UpdateById";
    public const string AddNewOrder = "Order_AddNew";
    public const string AddNewServiceToOrder = "Order_AddNewService";
    public const string GetAllOrders = "Order_GetAll";
    public const string GetAllOrdersByClientId = "Order_GetAllByClientId";
    public const string GetAllCompletedOrders = "Order_GetAllCompleted";
    public const string GetAllNotCompletedOrders = "Order_GetAllNotCompleted";
    public const string GetOrderById = "Order_GetById";
    public const string GetAllOrderServicesByOrderId = "Order_GetAllServiceByOrderId";
    public const string UpdateOrderById = "Order_UpdateById";
    public const string UpdateOrderServiceById = "Order_UpdateServiceById";
    public const string AddNewService = "Service_AddNew";
    public const string GetAllServices = "Service_GetAll";
    public const string GetServiceById = "Service_GetById";
    public const string UpdateServiceById = "Service_UpdateById";
    public const string AddNewTimetable = "Timetable_AddNew";
    public const string GetAllTimetable = "Timetable_GetAll";
    public const string GetAllTimetableByWorkerId = "Timetable_GetAllByWorkerId";
    public const string UpdateTimetableById = "Timetable_UpdateById";
    public const string AddNewWorker = "Worker_AddNew";
    public const string AddNewServiceToWorker = "Worker_AddNewService";
    public const string GetAllWorkers = "Worker_GetAll";
    public const string GetAllWorkerServicesByWorkerId = "Worker_GetAllServicesByWorkerId";
    public const string GetWorkerById = "Worker_GetById";
    public const string UpdateWorkerById = "Worker_UpdateById";
    public const string UpdateWorkerService = "Worker_UpdateService";
    public const string AddNewWorkingDay = "WorkingDay_AddNew";
    public const string UpdateWorkingDayById = "WorkingDay_UpdateById";
    public const string GetAllWorkingDays = "WorkingDay_GetAll";
    public const string GetWorkingDayById = "WorkingDay_GetById";
}
