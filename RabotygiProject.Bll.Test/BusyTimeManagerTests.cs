using Moq;
using RabotyagiProject.Bll;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotygiProject.Bll.Test.TestCaseSourse;
using NUnit.Framework;

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
        public void GetAllBusyTimeTest(List<BusyTimeDto> busyTime)
        {
            _mock.Setup(o => o.GetAllBusyTime()).Returns(busyTime).Verifiable();
            List<BusyTimeDto> expected = new List<BusyTimeDto>();
            List<BusyTimeOutputModel> actual = _manager.GetAllBusyTime();

            _mock.VerifyAll();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
