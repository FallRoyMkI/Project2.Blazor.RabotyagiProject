using Moq;
using NUnit.Framework;
using RabotyagiProject.Bll;
using RabotyagiProject.Bll.Models;
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

        [TestCaseSource(typeof(GetAllBusyTimeTimeTestCaseSourse))]
        public void GetAllBusyTimeTest(List<BusyTimeDto> dtoBusyTime, List<BusyTimeOutputModel> modelBusyTime)
        {
            _mock.Setup(o => o.GetAllBusyTime()).Returns(dtoBusyTime)/*.Verifiable()*/;
            List <BusyTimeOutputModel> actual = _manager.GetAllBusyTime();
            List<BusyTimeOutputModel> expected = new List<BusyTimeOutputModel>(modelBusyTime);

            //_mock.VerifyAll();
            CollectionAssert.AreEqual(expected, actual);
        }

        //[TestCase(1)] 
        //public void GetAllBusyTimeByTimetableIdTest(int id)

        //{
        //    List<BusyTimeDto> expected = new List<BusyTimeDto>();
        //    _mock.Setup(o => o.GetBusyTimeById(id)).Returns(busyTime);
        //    List<BusyTimeOutputModel> actual = _manager.GetAllBusyTimeByTimetableId(id);

        //    _mock.VerifyAll();
        //    CollectionAssert.AreEqual(expected, actual);
        //}

    }
}
