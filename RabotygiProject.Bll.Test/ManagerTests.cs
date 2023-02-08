using Moq;
using RabotyagiProject.Bll;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotygiProject.Bll.Test.TestCaseSourse;

namespace RabotygiProject.Bll.Test
{
    public class ManagerTests
    {
        private Manager _manager;
        private Mock<IBusyTimeRepository> _mockBusy;
        private Mock<IClientRepository> _mockClient;
        private Mock<IOrderRepository> _mockOrder;
        private Mock<IServiceRepository> _mockService;
        private Mock<ITimetableRepository> _mockTable;
        private Mock<IWorkerRepository> _mockWorker;
        private Mock<IWorkingDayRepository> _mockWorkingDay;

        [SetUp]

        public void SetUp()
        {
            //_manager = new Manager(_mockBusy.Object);
            _mockBusy = new Mock<IBusyTimeRepository>();
            _mockClient = new Mock<IClientRepository>();
            _mockOrder = new Mock<IOrderRepository>();
            _mockService = new Mock<IServiceRepository>();
            _mockTable = new Mock<ITimetableRepository>();
            _mockWorker = new Mock<IWorkerRepository>();
            _mockWorkingDay = new Mock<IWorkingDayRepository>();
            _manager.BusyTimeRepository = _mockBusy.Object;

        }

        [TestCaseSource(typeof(GetAllBusyTimeTimeTestCaseSourse))]
        public void GetAllBusyTimeTest(List<BusyTimeDto> busyTime)
        {
            _mockBusy.Setup(o => o.GetAllBusyTime()).Returns(busyTime).Verifiable();
            List<BusyTimeDto> expected = new List<BusyTimeDto>();
            List<BusyTimeOutputModel> actual = _manager.GetAllBusyTime();

            _mockBusy.VerifyAll();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}