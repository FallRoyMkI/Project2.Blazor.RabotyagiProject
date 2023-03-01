using System.Collections;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Models;

public class GetAllBusyTimeTimeTestCaseSourse : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        List<BusyTimeDto> dtoBusyTime = new List<BusyTimeDto>();
        List<BusyTimeOutputModel> modelBusyTime = new List<BusyTimeOutputModel>();
        dtoBusyTime = new List<BusyTimeDto>()
            {
                new BusyTimeDto()
                {
                    Id = 1,
                    StartTime = new TimeSpan(12, 30, 0),
                    EndTime = new TimeSpan( 13, 30, 0),
                    TimetableId = 1,
                    IsDeleted = false
                }
            };

        modelBusyTime = new List<BusyTimeOutputModel>()
            {
                new BusyTimeOutputModel()
                {
                    Id = 1,
                    StartTime = new TimeSpan(12, 30, 0),
                    EndTime = new TimeSpan( 13, 30, 0),
                    TimetableId = 1,
                    IsDeleted = false
                }
            };
        yield return new Object[] { dtoBusyTime, modelBusyTime };


        yield return new Object[]
        {
            dtoBusyTime = new List<BusyTimeDto>(),
            modelBusyTime = new List<BusyTimeOutputModel>()
        };

        dtoBusyTime = new List<BusyTimeDto>()
                {
                    new BusyTimeDto()
                    {
                        Id = 1,
                        StartTime = new TimeSpan(12, 30, 0),
                        EndTime = new TimeSpan( 13, 30, 0),
                        TimetableId = 1,
                        IsDeleted = false
                    },
                    new BusyTimeDto()
                    {
                        Id = 1,
                        StartTime = new TimeSpan(11, 40, 1),
                        EndTime = new TimeSpan( 11, 50, 1),
                        TimetableId = 4,
                        IsDeleted = false
                    }
                };

        modelBusyTime= new List<BusyTimeOutputModel>()
                {
                    new BusyTimeOutputModel()
                    {
                        Id = 1,
                        StartTime = new TimeSpan(12, 30, 0),
                        EndTime = new TimeSpan( 13, 30, 0),
                        TimetableId = 1,
                        IsDeleted = false
                    },
                    new BusyTimeOutputModel()
                    {
                        Id = 1,
                        StartTime = new TimeSpan(11, 40, 1),
                        EndTime = new TimeSpan( 11, 50, 1),
                        TimetableId = 4,
                        IsDeleted = false
                    }
                };
        yield return new Object[] { dtoBusyTime, modelBusyTime };

    }
}

//List<OrderDto> receivedOrders = new List<OrderDto>();
//List<OrderOutputModel> expectedOrders = new List<OrderOutputModel>();
//yield return new Object[] { receivedOrders, expectedOrders };

//receivedOrders = new List<OrderDto>()
//        {
//            new OrderDto()
//            {
//                Id = 1,
//                ClientId = 1,
//                IsCompleted = false,
//                Adress = "Виница",
//                Date = DateTime.Parse("10.10.2023"),
//                Cost = null,
//                Rate = null,
//                Report = null,
//                Services = new List<ServiceWorkerDto>(),
//                IsDeleted = false
//            }
//        };