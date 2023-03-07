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
        //public List<TimetableDto> GetAllTimetable();
        //public List<TimetableDto> GetAllTimetableByWorkerId(int workerId);
        //public void AddNewTimetable(int workerId, int workingDayId);
        //public void UpdateTimetableById(TimetableDto updatedDto);


        [TestCaseSource(typeof(GetAllTimetableTestCaseSourse))]
        public void GetAllTimetableTest(List<TimetableDto> dtoTimetable, List<TimetableOutputModel> timetableModel)
        {
            _mock.Setup(o => o.GetAllTimetable()).Returns(dtoTimetable).Verifiable();
            List<TimetableOutputModel> actual = _manager.GetAllTimetable();
            List<TimetableOutputModel> expected = new List<TimetableOutputModel>(timetableModel);
            _mock.VerifyAll();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetAllTimetableByWorkerIdTestCaseSourse))]
        public void GetAllTimetableByWorkerIdTest(List<TimetableDto> dtoTimetable, List<TimetableOutputModel> timetableModel, int workerId)
        {
            _mock.Setup(o => o.GetAllTimetableByWorkerId(workerId)).Returns(dtoTimetable).Verifiable();
            List<TimetableOutputModel> actual = _manager.GetAllTimetableByWorkerId(workerId);
            List<TimetableOutputModel> expected = new List<TimetableOutputModel>(timetableModel);

            _mock.VerifyAll();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(UpdateTimetableByIdTestCaseSourse))]
        public void UpdateTimetableByIdTest(TimetableDto dtoTimetable, TimetableInputModel timetableModel)
        {
            TimetableDto expected = dtoTimetable;
            _mock.Setup(o => o.UpdateTimetableById(dtoTimetable)).Verifiable();
            _manager.UpdateTimetableById(timetableModel);
            _mock.Verify();
        }

        //[TestCaseSource(typeof(AddNewTimetableTestCaseSourse))]
        //public void AddNewTimetableTest(int workerId, int workingDayId)
        //{
        //    BusyTimeDto expected = dtoBusyTime;
        //    _mock.Setup(o => o.AddNewTimetable(dtoBusyTime)).Verifiable();
        //    _manager.AddNewTimetable(modelBusyTime);
        //    _mock.Verify();
        //}

    }
}

