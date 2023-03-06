using System.Collections;
//using System.Collections.Generic;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Models;

public class GetAllClientsTestCaseSourse : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        List<ClientDto> clientDto = new List<ClientDto>();
        List<ClientOutputModel> modelClient = new List<ClientOutputModel>();
        List<ServiceWorkerOutputModel> Services;
        List<OrderDto> OrderDto = new List<OrderDto>()
        {
            new OrderDto()
            {
                Id=2,
                ClientId = 2,
                IsCompleted =true,
                Adress = "Ulitsa 1905 goda, 5, 2, 121",
                Date = DateTime.Parse("10.02.2023"),
                Cost = 120001,
                Rate = (RabotyagiProject.Dal.Options.Rate?)4,
                Report = "klass",
                Services = new List <ServiceWorkerDto>()
                {
                    new ServiceWorkerDto()
                    {
                        ServiceId=1,
                        WorkerId =null,
                        Workload =3
                    },
                    new ServiceWorkerDto()
                    {
                        ServiceId =1,
                        WorkerId =2,
                        Workload =3
                    }
                },
            },
            new OrderDto()
            {
                    Id=2,
                    ClientId = 2,
                    IsCompleted =false,
                    Adress = "Ulitsa Lenina, 3, 10, 1",
                    Date = DateTime.Parse("15.10.2023"),
                    Cost = 30000,
                    Rate = null,
                    Report = null,

            }
        };
        List<OrderOutputModel> OrderModel = new List<OrderOutputModel>()
        {
            new OrderOutputModel()
            {
                Id=2,
                ClientId = 2,
                IsCompleted =true,
                Adress = "Ulitsa 1905 goda, 5, 2, 121",
                Date = DateTime.Parse("10.02.2023"),
                Cost = 120001,
                Rate = (RabotyagiProject.Dal.Options.Rate?)4,
                Report = "klass",
                Services = new List <ServiceWorkerOutputModel>()
                {
                    new ServiceWorkerOutputModel()
                    {
                        ServiceId=1,
                        WorkerId =null,
                        Workload =3
                    },
                    new ServiceWorkerOutputModel()
                    {
                        ServiceId =1,
                        WorkerId =2,
                        Workload =3
                    }
                },
            },
            new OrderOutputModel()
            {
                    Id=2,
                    ClientId = 2,
                    IsCompleted =false,
                    Adress = "Ulitsa Lenina, 3, 10, 1",
                    Date = DateTime.Parse("15.10.2023"),
                    Cost = 30000,
                    Rate = null,
                    Report = null,
                    Services = new List<ServiceWorkerOutputModel>(),
            }
        };

        clientDto = new List<ClientDto>()
            {
                new ClientDto()
                {
                Id = 1,
                Name = "Ivanov Ivan Ivanovich",
                Phone = "79159999999",
                Mail = "iii@gmail.ru",
                IsDeleted = false,
                Orders =OrderDto
                }
        };

        modelClient = new List<ClientOutputModel>()
            {
                new ClientOutputModel()
                {
                Id = 1,
                Name = "Ivanov Ivan Ivanovich",
                Phone = "79159999999",
                Mail = "iii@gmail.ru",
                Orders = OrderModel
                }
            };
        yield return new Object[] { clientDto, modelClient };

        yield return new Object[]
        {
            clientDto = new List<ClientDto>(),
            modelClient = new List<ClientOutputModel>()
        };

        clientDto = new List<ClientDto>()
                {
                    new ClientDto()
                    {
                     Id = 1,
                     Name = "Ivanov Ivan Ivanovich",
                     Phone = "79159999999",
                     Mail = "iii@gmail.ru",
                     IsDeleted =false
                    },
                    new ClientDto()
                    {
                        Id = 2,
                        Name = "Petrov Petr Petrovich",
                        Phone = "79111111111",
                        Mail = "ppp@gmail.ru",
                        IsDeleted=false
                    }
        };
        modelClient = new List<ClientOutputModel>()
                {
                    new ClientOutputModel()
                    {
                     Id = 1,
                     Name = "Ivanov Ivan Ivanovich",
                     Phone = "79159999999",
                     Mail = "iii@gmail.ru",
                    },
                    new ClientOutputModel()
                    {
                        Id = 2,
                        Name = "Petrov Petr Petrovich",
                        Phone = "79111111111",
                        Mail = "ppp@gmail.ru",
                    }
                };
        yield return new Object[] { clientDto, modelClient };
    }
}

public class GetClientByIdTestCaseSourse : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        ClientDto clientDto = new ClientDto();
        ClientOutputModel modelClient = new ClientOutputModel();
        List<ServiceWorkerOutputModel> Services;
        List<OrderDto> OrderDto1 = new List<OrderDto>()
        {
            new OrderDto()
            {
                Id=2,
                ClientId = 2,
                IsCompleted =true,
                Adress = "Ulitsa 1905 goda, 5, 2, 121",
                Date = DateTime.Parse("10.02.2023"),
                Cost = 120001,
                Rate = (RabotyagiProject.Dal.Options.Rate?)4,
                Report = "klass",
                Services = new List <ServiceWorkerDto>()
                {
                    new ServiceWorkerDto()
                    {
                        ServiceId=1,
                        WorkerId =null,
                        Workload =3
                    },
                    new ServiceWorkerDto()
                    {
                        ServiceId =1,
                        WorkerId =2,
                        Workload =3
                    }
                }
            }
        };
        List<OrderOutputModel> OrderModel1 = new List<OrderOutputModel>()
        {
            new OrderOutputModel()
            {
                Id=2,
                ClientId = 2,
                IsCompleted =true,
                Adress = "Ulitsa 1905 goda, 5, 2, 121",
                Date = DateTime.Parse("10.02.2023"),
                Cost = 120001,
                Rate = (RabotyagiProject.Dal.Options.Rate?)4,
                Report = "klass",
                Services = new List <ServiceWorkerOutputModel>()
                {
                    new ServiceWorkerOutputModel()
                    {
                        ServiceId=1,
                        WorkerId =null,
                        Workload =3
                    },
                    new ServiceWorkerOutputModel()
                    {
                        ServiceId =1,
                        WorkerId =2,
                        Workload =3
                    }
                },
            }
        };

        int Id = 1;
        clientDto = new ClientDto()
        {
            Id = 1,
            Name = "Ivanov Ivan Ivanovich",
            Phone = "79159999999",
            Mail = "iii@gmail.ru",
            IsDeleted = false,
            Orders = OrderDto1
        };
        ClientOutputModel clientOutputModel = new ClientOutputModel()
        {
            Id = 1,
            Name = "Ivanov Ivan Ivanovich",
            Phone = "79159999999",
            Mail = "iii@gmail.ru",
            Orders = OrderModel1
        };
        yield return new Object[] { clientDto, clientOutputModel, Id };

        int Id2 = 2;
        ClientDto clientDto2 = new ClientDto();
        ClientOutputModel сlientOutputModel2 = new ClientOutputModel();
        yield return new Object[] { clientDto2, сlientOutputModel2, Id2 };
    }
}

public class AddNewClientTestCaseSourse : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        ClientDto clientDto = new ClientDto()
        {
            Id = 1,
            Name = "Ivanov Ivan Ivanovich",
            Phone = "79159999999",
            Mail = "iii@gmail.ru",
            IsDeleted = false
        };

        ClientInputModel modelClient = new ClientInputModel()
        {
            Id = 1,
            Name = "Ivanov Ivan Ivanovich",
            Phone = "79159999999",
            Mail = "iii@gmail.ru"

        };
        yield return new Object[] { clientDto, modelClient };
    }
}