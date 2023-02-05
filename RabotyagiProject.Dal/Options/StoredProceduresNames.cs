
namespace RabotyagiProject.Dal.Options
{
    public class StoredProceduresNames
    {
        public static string AddNewBusyTime = "BusyTime_AddNew";
        public static string GetAllBusyTime = "BusyTIme_GetAll";
        public static string GetAllBusyTimeByTimetableId = "BusyTime_GetAllByTimetableId";
        public static string UpdateBusyTimeById = "BusyTime_UpdateById";
        public static string AddNewClient = "Client_AddNew";
        public static string GetAllClients = "Client_GetAll";
        public static string GetClientById = "Client_GetById";
        public static string UpdateClientById = "Client_UpdateById";
        public static string AddNewOrder = "Order_AddNew";
        public static string AddNewServiceToOrder = "Order_AddNewService";
        public static string GetAllOrders = "Order_GetAll";
        public static string GetAllOrdersByClientId = "Order_GetAllByClientId";
        public static string GetAllCompletedOrders = "Order_GetAllCompleted";
        public static string GetAllNotCompletedOrders = "Order_GetAllNotCompleted";
        public static string GetOrderById = "Order_GetById";
        public static string GetAllOrderServicesByOrderId = "Order_GetAllServiceByOrderId";
        public static string UpdateOrderById = "Order_UpdateById";
        public static string UpdateOrderServiceById = "Order_UpdateServiceById";
        public static string AddNewService = "Service_AddNew";
        public static string GetAllServices = "Service_GetAll";
        public static string GetServiceById = "Service_GetById";
        public static string UpdateServiceById = "Service_UpdateById";
        public static string AddNewTimetable = "Timetable_AddNew";
        public static string GetAllTimetable = "Timetable_GetAll";
        public static string GetAllTimetableByWorkerId = "Timetable_GetAllByWorkerId";
        public static string UpdateTimetableById = "Timetable_UpdateById";
        public static string AddNewWorker = "Worker_AddNew";
        public static string AddNewServiceToWorker = "Worker_AddNewService";
        public static string GetAllWorkers = "Worker_GetAll";
        public static string GetAllWorkerServicesByWorkerId = "Worker_GetAllServicesByWorkerId";
        public static string GetWorkerById = "Worker_GetById";
        public static string UpdateWorkerById = "Worker_UpdateById";
        public static string UpdateWorkerService = "Worker_UpdateService";
        public static string AddNewWorkingDay = "WorkingDay_AddNew";
        public static string UpdateWorkingDayById = "WorkingDay_UpdateById";
        public static string GetAllWorkingDays = "WorkingDay_GetAll";
    }
}
