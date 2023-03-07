using Moq;
using NUnit.Framework;
using RabotyagiProject.Bll;
using RabotyagiProject.Bll.Models;
using RabotygiProject.Bll.Test.TestCaseSourse;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;

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

        [TestCaseSource(typeof(GetBusyTimeByIdTestCaseSourse))]
        public void GetBusyTimeByIdTest(BusyTimeDto dtoBusyTime, BusyTimeOutputModel modelBusyTime, int id)
        {
            _mock.Setup(o => o.GetBusyTimeById(id)).Returns(dtoBusyTime).Verifiable();
            BusyTimeOutputModel actual = _manager.GetBusyTimeById(id);
            BusyTimeOutputModel expected = modelBusyTime;

            _mock.VerifyAll();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(UpdateBusyTimeByIdTestCaseSourse))]
        public void UpdateBusyTimeByIdTest(BusyTimeDto dtoBusyTime, BusyTimeInputModel modelBusyTime)
        {
            BusyTimeDto expected = dtoBusyTime;
            _mock.Setup(o => o.UpdateBusyTimeById(dtoBusyTime)).Verifiable();
            _manager.UpdateBusyTimeById(modelBusyTime);
            _mock.Verify();
        }
        
        [TestCaseSource(typeof(AddNewBusyTimeTestCaseSourse))]
        public void AddNewBusyTimeTest(BusyTimeDto dtoBusyTime, BusyTimeInputModel modelBusyTime)
        {
            BusyTimeDto expected = dtoBusyTime;
            _mock.Setup(o => o.AddNewBusyTime(dtoBusyTime)).Verifiable();
            _manager.AddNewBusyTime(modelBusyTime);
            _mock.Verify();
        }
    }
}