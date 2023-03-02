using Moq;
using NUnit.Framework;
using RabotyagiProject.Bll;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotygiProject.Bll.Test.TestCaseSourse;


namespace RabotygiProject.Bll.Test
{
    public class BusyTimeManagerTests
    {
        private BusyTimeManager _manager;
        private Mock<IBusyTimeRepository> _mock;

        [SetUp]
        public void SetUp()
        {
            _mock = new Mock<IBusyTimeRepository>();
            _manager = new BusyTimeManager(_mock.Object);
        }

        [TestCaseSource(typeof(GetAllBusyTimeTestCaseSourse))]
        public void GetAllBusyTimeTest(List<BusyTimeDto> dtoBusyTime, List<BusyTimeOutputModel> modelBusyTime)
        {
            _mock.Setup(o => o.GetAllBusyTime()).Returns(dtoBusyTime).Verifiable();
            List<BusyTimeOutputModel> actual = _manager.GetAllBusyTime();
            List<BusyTimeOutputModel> expected = new List<BusyTimeOutputModel>(modelBusyTime);

            _mock.VerifyAll();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetAllBusyTimeByTimetableIdTestCaseSourse))]
        public void GetAllBusyTimeByTimetableIdTest(List<BusyTimeDto> dtoBusyTime, List<BusyTimeOutputModel> modelBusyTime, int tableId)

        {
            _mock.Setup(o => o.GetAllBusyTimeByTimetableId(tableId)).Returns(dtoBusyTime).Verifiable();
            List<BusyTimeOutputModel> actual = _manager.GetAllBusyTimeByTimetableId(tableId);
            List<BusyTimeOutputModel> expected = new List<BusyTimeOutputModel>(modelBusyTime);

            _mock.VerifyAll();
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}