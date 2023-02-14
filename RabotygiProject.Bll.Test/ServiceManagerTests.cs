using Moq;
using RabotyagiProject.Bll;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotygiProject.Bll.Test.TestCaseSourse;

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
}

