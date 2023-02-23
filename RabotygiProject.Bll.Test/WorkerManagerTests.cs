using Moq;
using RabotyagiProject.Bll;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotygiProject.Bll.Test.TestCaseSourse;
using NUnit.Framework;

namespace RabotygiProject.Bll.Test;

public class WorkerManagerTests
{
    private WorkerManager _manager;
    private Mock<IWorkerRepository> _mock;

    [SetUp]
    public void SetUp()
    {
        _mock = new Mock<IWorkerRepository>();
        _manager = new WorkerManager(_mock.Object);
    }

    [TestCaseSource(typeof(GetAllWorkersTestSources))]
    public void GetAllWorkers(List<WorkerDto> receivedWorkers, List<WorkerOutputModel> expectedWorkers)
    {
        _mock.Setup(o => o.GetAllWorkers()).Returns(receivedWorkers).Verifiable();
        List<WorkerOutputModel> actual = _manager.GetAllWorkers();
        List<WorkerOutputModel> expected = expectedWorkers;
        _mock.VerifyAll();
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestCaseSource(typeof(GetWorkerByIdTestSources))]
    public void GetWorkerById(int id, WorkerDto receivedWorker, WorkerOutputModel expectedWorker)
    {
        _mock.Setup(o => o.GetWorkerById(id)).Returns(receivedWorker).Verifiable();
        WorkerOutputModel actual = _manager.GetWorkerById(id);
        WorkerOutputModel expected = expectedWorker;
        _mock.VerifyAll();
        Assert.AreEqual(expected, actual);
    }
}