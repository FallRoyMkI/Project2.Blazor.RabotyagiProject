﻿using Moq;
using RabotyagiProject.Bll;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotygiProject.Bll.Test.TestCaseSourse;
using NUnit.Framework;

namespace RabotygiProject.Bll.Test;

public class ServiceManagerTests
{
    private ServiceManager _manager;
    private Mock<IServiceRepository> _mock;

    [SetUp]
    public void SetUp()
    {
        _mock = new Mock<IServiceRepository>();
        _manager = new ServiceManager(_mock.Object);
    }

    [TestCaseSource(typeof(GetAllServicesTestSources))]
    public void GetAllServicesTest(List<ServiceDto> receivedService, List<ServiceOutputModel> expectedService)
    {
        _mock.Setup(o => o.GetAllServices()).Returns(receivedService).Verifiable();
        List<ServiceOutputModel> actual = _manager.GetAllServices();
        List<ServiceOutputModel> expected = expectedService;
        _mock.VerifyAll();
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestCaseSource(typeof(GetServiceByIdTestSources))]
    public void GetServiceByIdTest(int id, ServiceDto receivedService, ServiceOutputModel expectedService)
    {
        _mock.Setup(o => o.GetServiceById(id)).Returns(receivedService).Verifiable();
        ServiceOutputModel actual = _manager.GetServiceById(id);
        ServiceOutputModel expected = expectedService;
        _mock.VerifyAll();
        Assert.AreEqual(expected, actual);
    }

    [TestCaseSource(typeof(UpdateServiceByIdTestCaseSourse))]
    public void UpdateServiceByIdTest(ServiceDto dtoService, ServiceInputModel serviceModel)
    {
        ServiceDto expected = dtoService;
        _mock.Setup(o => o.UpdateServiceById(dtoService)).Verifiable();
        _manager.UpdateServiceById(serviceModel);
        _mock.Verify();
    }

    [TestCaseSource(typeof(AddNewServiceTestCaseSourse))]
    public void AddNewServiceTest(ServiceDto dtoService, ServiceInputModel serviceModel)
    {
        ServiceDto expected = dtoService;
        _mock.Setup(o => o.AddNewService(dtoService)).Verifiable();
        _manager.AddNewService(serviceModel);
        _mock.Verify();
    }
}



