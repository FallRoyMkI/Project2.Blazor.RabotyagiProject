using Moq;
using RabotyagiProject.Bll;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotygiProject.Bll.Test.TestCaseSourse;
using NUnit.Framework;

namespace RabotygiProject.Bll.Test
{
    public class TimetableManagerTests
    {
        private TimetableManager _manager;
        private Mock<ITimetableRepository> _mock;

        [SetUp]
        public void SetUp()
        {
            _manager = new TimetableManager(_mock.Object);
            _mock = new Mock<ITimetableRepository>();
        }
    }
}

