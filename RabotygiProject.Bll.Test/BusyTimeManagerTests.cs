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
        private Mock<IBusyTimeRepository> _mockBusy;

        public void SetUp()
        {
            _mockBusy = new Mock<IBusyTimeRepository>();
            _manager = new BusyTimeManager(_mock.Object);

        }

    }
}
