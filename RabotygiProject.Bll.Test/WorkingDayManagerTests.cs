using Moq;
using RabotyagiProject.Bll;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotygiProject.Bll.Test.TestCaseSourse;
using NUnit.Framework;

namespace RabotygiProject.Bll.Test
{
    public class WorkingDayManagerTests
    {
        private WorkingDayManager _manager;
        private Mock<IWorkingDayRepository> _mock;
        [SetUp]
        public void SetUp()
        {
            _manager = new WorkingDayManager(_mock.Object);
            _mock = new Mock<IWorkingDayRepository>();
        }
    }
}
