﻿using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Models;
using System.Collections;

namespace RabotygiProject.Bll.Test.TestCaseSourse;

public class GetAllWorkersTestSources : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        List<WorkerDto> receivedWorkers = new List<WorkerDto>();
        List<WorkerOutputModel> expectedWorkers = new List<WorkerOutputModel>();
        yield return new Object[] { receivedWorkers, expectedWorkers };

        receivedWorkers = new List<WorkerDto>()
        {
            new WorkerDto()
            {
                Id = 1,
                Name = "Name1",
                Mail = "Mail1",
                Phone = "123456789",
                Service = new List<ServiceDto>(),
                IsDeleted = false
            }
        };
        expectedWorkers = new List<WorkerOutputModel>()
        {
            new WorkerOutputModel()
            {
                Id = 1,
                Name = "Name1",
                Mail = "Mail1",
                Phone = "123456789",
                Service = new List<ServiceOutputModel>()
            }
        };
        yield return new Object[] { receivedWorkers, expectedWorkers };

        receivedWorkers = new List<WorkerDto>()
        {
            new WorkerDto()
            {
                Id = 1,
                Name = "Name1",
                Mail = "Mail1",
                Phone = "123456789",
                Service = new List<ServiceDto>(),
                IsDeleted = false
            },
            new WorkerDto()
            {
                Id = 2,
                Name = "Name2",
                Mail = "Mail2",
                Phone = "123456789",
                Service = new List<ServiceDto>()
                {
                    new ServiceDto()
                    {
                        Id = 1,
                        Type = "Type1",
                        Cost = 500
                    }
                },
                IsDeleted = false
            },
            new WorkerDto()
            {
                Id = 3,
                Name = "Name3",
                Mail = "Mail3",
                Phone = "3333333",
                Service = new List<ServiceDto>()
                {
                    new ServiceDto()
                    {
                        Id = 1,
                        Type = "Type1",
                        Cost = 500
                    },
                    new ServiceDto()
                    {
                        Id = 2,
                        Type = "Type2",
                        Cost = 1500
                    },
                    new ServiceDto()
                    {
                        Id = 5,
                        Type = "Type5",
                        Cost = 100
                    }
                },
                IsDeleted = false
            }
        };
        expectedWorkers = new List<WorkerOutputModel>()
        {
            new WorkerOutputModel()
            {
                Id = 1,
                Name = "Name1",
                Mail = "Mail1",
                Phone = "123456789",
                Service = new List<ServiceOutputModel>()
            },
            new WorkerOutputModel()
            {
                Id = 2,
                Name = "Name2",
                Mail = "Mail2",
                Phone = "123456789",
                Service = new List<ServiceOutputModel>()
                {
                    new ServiceOutputModel()
                    {
                        Id = 1,
                        Type = "Type1",
                        Cost = 500
                    }
                },
            },
            new WorkerOutputModel()
            {
                Id = 3,
                Name = "Name3",
                Mail = "Mail3",
                Phone = "3333333",
                Service = new List<ServiceOutputModel>()
                {
                    new ServiceOutputModel()
                    {
                        Id = 1,
                        Type = "Type1",
                        Cost = 500
                    },
                    new ServiceOutputModel()
                    {
                        Id = 2,
                        Type = "Type2",
                        Cost = 1500
                    },
                    new ServiceOutputModel()
                    {
                        Id = 5,
                        Type = "Type5",
                        Cost = 100
                    }
                }
            }
        };
        yield return new Object[] { receivedWorkers, expectedWorkers };
    }
}

public class GetWorkerByIdTestSources : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        int id = 1;
        WorkerDto receivedWorker = new WorkerDto();
        WorkerOutputModel expectedWorker = new WorkerOutputModel();
        yield return new Object[] { id, receivedWorker, expectedWorker };

        id = 1;
        receivedWorker = new WorkerDto()
        {
            Id = 1,
            Name = "Name1",
            Mail = "Mail1",
            Phone = "123456789",
            Service = new List<ServiceDto>(),
            IsDeleted = false
        };
        expectedWorker = new WorkerOutputModel()
        {
            Id = 1,
            Name = "Name1",
            Mail = "Mail1",
            Phone = "123456789",
            Service = new List<ServiceOutputModel>()
        };
        yield return new Object[] { id, receivedWorker, expectedWorker };

        id = 1;
        receivedWorker = new WorkerDto()
        {
            Id = 3,
            Name = "Name3",
            Mail = "Mail3",
            Phone = "3333333",
            Service = new List<ServiceDto>()
                {
                    new ServiceDto()
                    {
                        Id = 1,
                        Type = "Type1",
                        Cost = 500
                    },
                    new ServiceDto()
                    {
                        Id = 2,
                        Type = "Type2",
                        Cost = 1500
                    },
                    new ServiceDto()
                    {
                        Id = 5,
                        Type = "Type5",
                        Cost = 100
                    }
                },
            IsDeleted = false
        };
        expectedWorker = new WorkerOutputModel()
        {
            Id = 3,
            Name = "Name3",
            Mail = "Mail3",
            Phone = "3333333",
            Service = new List<ServiceOutputModel>()
                {
                    new ServiceOutputModel()
                    {
                        Id = 1,
                        Type = "Type1",
                        Cost = 500
                    },
                    new ServiceOutputModel()
                    {
                        Id = 2,
                        Type = "Type2",
                        Cost = 1500
                    },
                    new ServiceOutputModel()
                    {
                        Id = 5,
                        Type = "Type5",
                        Cost = 100
                    }
                }
        };
        yield return new Object[] { id, receivedWorker, expectedWorker };
    }
}
public class AddNewWorkerTestCaseSourse : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        WorkerDto receivedWorkers = new WorkerDto();
        WorkerInputModel expectedWorkers = new WorkerInputModel();
        yield return new Object[] { receivedWorkers, expectedWorkers };
        receivedWorkers = new WorkerDto()
        {
                Id = 1,
                Name = "Name1",
                Mail = "Mail1",
                Phone = "123456789",
                Service = new List<ServiceDto>(),
                IsDeleted = false
        };
        expectedWorkers = new WorkerInputModel()
        {
                Id = 1,
                Name = "Name1",
                Mail = "Mail1",
                Phone = "123456789",
                Service = new List<ServiceInputModel>()
        };
        yield return new Object[] { receivedWorkers, expectedWorkers };
    }
}

public class UpdateWorkerByIdTestCaseSourse : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        WorkerDto workerDto = new WorkerDto()
        {
            Id = 1,
            Name = "Name1",
            Mail = "Mail1",
            Phone = "123456789",
            Service = new List<ServiceDto>(),
            IsDeleted = false
        };
        WorkerInputModel workerInputModel = new WorkerInputModel()
        {
            Id = 1,
            Name = "Name1",
            Mail = "Mail1",
            Phone = "123456789",
            Service = new List<ServiceInputModel>()
        };
        yield return new Object[] { workerDto, workerInputModel };
    }
}

public class UpdateWorkerServiceTestCaseSourse : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        int workerId = 2;
        ServiceDto serviceDto = new ServiceDto()
        {
            Id = 2,
            Type = "Хотьба по потолоку",
            Cost = 1999,
            IsDeleted = false
        };
        ServiceInputModel serviceInputModel = new ServiceInputModel()
        {
            Id = 2,
            Type = "Хотьба по потолоку",
            Cost = 1999,
        };

        WorkerDto dtoWorker = new WorkerDto()
        {
            Id = workerId,
            Name = "Name1",
            Mail = "Mail1",
            Phone = "123456789",
            Service = new List<ServiceDto>()
            {
                serviceDto,
            },
            IsDeleted = false
        };
        WorkerInputModel workerInputModel = new WorkerInputModel()
        {
            Id = workerId,
            Name = "Name1",
            Mail = "Mail1",
            Phone = "123456789",
            Service = new List<ServiceInputModel>()
            {
                serviceInputModel
            }
        };
        yield return new Object[] {workerId, serviceDto, dtoWorker, serviceInputModel };
    }
}

public class AddNewServiceToWorkerTestCaseSourse : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        int workerId = 2;
        ServiceDto serviceDto = new ServiceDto()
        {
            Id = 2,
            Type = "Хотьба по потолоку",
            Cost = 1999,
            IsDeleted = false
        };
        ServiceInputModel serviceInputModel = new ServiceInputModel()
        {
            Id = 2,
            Type = "Хотьба по потолоку",
            Cost = 1999,
        };

        WorkerDto dtoWorker = new WorkerDto()
        {
            Id = workerId,
            Name = "Name1",
            Mail = "Mail1",
            Phone = "123456789",
            Service = new List<ServiceDto>()
            {
                serviceDto,
            },
            IsDeleted = false
        };
        WorkerInputModel workerInputModel = new WorkerInputModel()
        {
            Id = workerId,
            Name = "Name1",
            Mail = "Mail1",
            Phone = "123456789",
            Service = new List<ServiceInputModel>()
            {
                serviceInputModel
            }
        };
        yield return new Object[] { workerId, serviceDto, dtoWorker, serviceInputModel };
    }
}