using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Models;
using System.Collections;
using RabotyagiProject.Dal.Options;

namespace RabotygiProject.Bll.Test.TestCaseSourse;

public class GetAllOrdersTestSources : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        List<OrderDto> receivedOrders = new List<OrderDto>();
        List<OrderOutputModel> expectedOrders = new List<OrderOutputModel>();
        yield return new Object[] { receivedOrders, expectedOrders };

        receivedOrders = new List<OrderDto>()
        {
            new OrderDto()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerDto>(),
                IsDeleted = false
            }
        };
        expectedOrders = new List<OrderOutputModel>()
        {
            new OrderOutputModel()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerOutputModel>()
            }
        };
        yield return new Object[] { receivedOrders, expectedOrders };

        receivedOrders = new List<OrderDto>()
        {
            new OrderDto()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerDto>(),
                IsDeleted = false
            },
            new OrderDto()
            {
                Id = 2,
                ClientId = 1,
                IsCompleted = true,
                Adress = "Виница",
                Date = DateTime.Parse("09.09.2023"),
                Cost = 1500,
                Rate = (Rate?)4,
                Report = "всё норм",
                Services = new List<ServiceWorkerDto>()
                {
                    new ServiceWorkerDto()
                    {
                        ServiceId = 1,
                        WorkerId = 5,
                        Workload = 50
                    }
                },
                IsDeleted = false
            }
        };
        expectedOrders = new List<OrderOutputModel>()
        {
            new OrderOutputModel()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerOutputModel>()
            },
            new OrderOutputModel()
            {
                Id = 2,
                ClientId = 1,
                IsCompleted = true,
                Adress = "Виница",
                Date = DateTime.Parse("09.09.2023"),
                Cost = 1500,
                Rate = (Rate?)4,
                Report = "всё норм",
                Services = new List<ServiceWorkerOutputModel>()
                {
                    new ServiceWorkerOutputModel()
                    {
                        ServiceId = 1,
                        WorkerId = 5,
                        Workload = 50
                    }
                }
            }
        };
        yield return new Object[] { receivedOrders, expectedOrders };
    }
}

public class GetAllCompletedOrdersTestSources : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        List<OrderDto> receivedOrders = new List<OrderDto>();
        List<OrderOutputModel> expectedOrders = new List<OrderOutputModel>();
        yield return new Object[] { receivedOrders, expectedOrders };

        receivedOrders = new List<OrderDto>()
        {
            new OrderDto()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = true,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerDto>(),
                IsDeleted = false
            }
        };
        expectedOrders = new List<OrderOutputModel>()
        {
            new OrderOutputModel()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = true,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerOutputModel>()
            }
        };
        yield return new Object[] { receivedOrders, expectedOrders };

        receivedOrders = new List<OrderDto>()
        {
            new OrderDto()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = true,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerDto>(),
                IsDeleted = false
            },
            new OrderDto()
            {
                Id = 2,
                ClientId = 1,
                IsCompleted = true,
                Adress = "Виница",
                Date = DateTime.Parse("09.09.2023"),
                Cost = 1500,
                Rate = (Rate?)4,
                Report = "всё норм",
                Services = new List<ServiceWorkerDto>()
                {
                    new ServiceWorkerDto()
                    {
                        ServiceId = 1,
                        WorkerId = 5,
                        Workload = 50
                    }
                },
                IsDeleted = false
            }
        };
        expectedOrders = new List<OrderOutputModel>()
        {
            new OrderOutputModel()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = true,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerOutputModel>()
            },
            new OrderOutputModel()
            {
                Id = 2,
                ClientId = 1,
                IsCompleted = true,
                Adress = "Виница",
                Date = DateTime.Parse("09.09.2023"),
                Cost = 1500,
                Rate = (Rate?)4,
                Report = "всё норм",
                Services = new List<ServiceWorkerOutputModel>()
                {
                    new ServiceWorkerOutputModel()
                    {
                        ServiceId = 1,
                        WorkerId = 5,
                        Workload = 50
                    }
                }
            }
        };
        yield return new Object[] { receivedOrders, expectedOrders };
    }
}

public class GetAllNotCompletedOrdersTestSources : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        List<OrderDto> receivedOrders = new List<OrderDto>();
        List<OrderOutputModel> expectedOrders = new List<OrderOutputModel>();
        yield return new Object[] { receivedOrders, expectedOrders };

        receivedOrders = new List<OrderDto>()
        {
            new OrderDto()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerDto>(),
                IsDeleted = false
            }
        };
        expectedOrders = new List<OrderOutputModel>()
        {
            new OrderOutputModel()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerOutputModel>()
            }
        };
        yield return new Object[] { receivedOrders, expectedOrders };

        receivedOrders = new List<OrderDto>()
        {
            new OrderDto()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerDto>(),
                IsDeleted = false
            },
            new OrderDto()
            {
                Id = 2,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("09.09.2023"),
                Cost = 1500,
                Rate = (Rate?)4,
                Report = "всё норм",
                Services = new List<ServiceWorkerDto>()
                {
                    new ServiceWorkerDto()
                    {
                        ServiceId = 1,
                        WorkerId = 5,
                        Workload = 50
                    }
                },
                IsDeleted = false
            }
        };
        expectedOrders = new List<OrderOutputModel>()
        {
            new OrderOutputModel()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerOutputModel>()
            },
            new OrderOutputModel()
            {
                Id = 2,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("09.09.2023"),
                Cost = 1500,
                Rate = (Rate?)4,
                Report = "всё норм",
                Services = new List<ServiceWorkerOutputModel>()
                {
                    new ServiceWorkerOutputModel()
                    {
                        ServiceId = 1,
                        WorkerId = 5,
                        Workload = 50
                    }
                }
            }
        };
        yield return new Object[] { receivedOrders, expectedOrders };
    }
}

public class GetAllOrdersByClientIdTestSources : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        int id = 1;
        List<OrderDto> receivedOrders = new List<OrderDto>();
        List<OrderOutputModel> expectedOrders = new List<OrderOutputModel>();
        yield return new Object[] { id, receivedOrders, expectedOrders };

        id = 1;
        receivedOrders = new List<OrderDto>()
        {
            new OrderDto()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerDto>(),
                IsDeleted = false
            }
        };
        expectedOrders = new List<OrderOutputModel>()
        {
            new OrderOutputModel()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerOutputModel>()
            }
        };
        yield return new Object[] { id, receivedOrders, expectedOrders };

        id = 1;
        receivedOrders = new List<OrderDto>()
        {
            new OrderDto()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerDto>(),
                IsDeleted = false
            },
            new OrderDto()
            {
                Id = 2,
                ClientId = 1,
                IsCompleted = true,
                Adress = "Виница",
                Date = DateTime.Parse("09.09.2023"),
                Cost = 1500,
                Rate = (Rate?)4,
                Report = "всё норм",
                Services = new List<ServiceWorkerDto>()
                {
                    new ServiceWorkerDto()
                    {
                        ServiceId = 1,
                        WorkerId = 5,
                        Workload = 50
                    }
                },
                IsDeleted = false
            }
        };
        expectedOrders = new List<OrderOutputModel>()
        {
            new OrderOutputModel()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerOutputModel>()
            },
            new OrderOutputModel()
            {
                Id = 2,
                ClientId = 1,
                IsCompleted = true,
                Adress = "Виница",
                Date = DateTime.Parse("09.09.2023"),
                Cost = 1500,
                Rate = (Rate?)4,
                Report = "всё норм",
                Services = new List<ServiceWorkerOutputModel>()
                {
                    new ServiceWorkerOutputModel()
                    {
                        ServiceId = 1,
                        WorkerId = 5,
                        Workload = 50
                    }
                }
            }
        };
        yield return new Object[] { id, receivedOrders, expectedOrders };
    }
}

public class GetOrderByIdTestSources : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        int id = 1;
        OrderDto receivedOrder = new OrderDto();
        OrderOutputModel expectedOrder = new OrderOutputModel();
        yield return new Object[] { id, receivedOrder, expectedOrder };

        id = 1;
        receivedOrder = new OrderDto()
        {
            Id = 1,
            ClientId = 1,
            IsCompleted = false,
            Adress = "Виница",
            Date = DateTime.Parse("10.10.2023"),
            Cost = null,
            Rate = null,
            Report = null,
            Services = new List<ServiceWorkerDto>(),
            IsDeleted = false
        };
        expectedOrder = new OrderOutputModel()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = false,
                Adress = "Виница",
                Date = DateTime.Parse("10.10.2023"),
                Cost = null,
                Rate = null,
                Report = null,
                Services = new List<ServiceWorkerOutputModel>()
            };
        yield return new Object[] { id ,receivedOrder, expectedOrder };

        id = 1;
        receivedOrder = new OrderDto()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = true,
                Adress = "Виница",
                Date = DateTime.Parse("09.09.2023"),
                Cost = 1500,
                Rate = (Rate?)4,
                Report = "всё норм",
                Services = new List<ServiceWorkerDto>()
                {
                    new ServiceWorkerDto()
                    {
                        ServiceId = 1,
                        WorkerId = 5,
                        Workload = 50
                    }
                },
                IsDeleted = false
            };
        expectedOrder = new OrderOutputModel()
            {
                Id = 1,
                ClientId = 1,
                IsCompleted = true,
                Adress = "Виница",
                Date = DateTime.Parse("09.09.2023"),
                Cost = 1500,
                Rate = (Rate?)4,
                Report = "всё норм",
                Services = new List<ServiceWorkerOutputModel>()
                {
                    new ServiceWorkerOutputModel()
                    {
                        ServiceId = 1,
                        WorkerId = 5,
                        Workload = 50
                    }
                }
            };
        yield return new Object[] { id, receivedOrder, expectedOrder };
    }
}