using Moq;
using NUnit.Framework;
using RabotyagiProject.Bll;
using RabotyagiProject.Dal.Interface;

namespace RabotygiProject.Bll.Test
{
    public class TimetableManagerTests
    {
        private TimetableManager _manager;
        private Mock<ITimetableRepository> _mockTable;

        [SetUp]
        public void SetUp()
        {
            _manager = new TimetableManager(_mock.Object);
            _mockTable = new Mock<ITimetableRepository>();
        }
    }
}

