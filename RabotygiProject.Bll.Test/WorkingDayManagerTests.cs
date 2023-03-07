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
            _mock = new Mock<IWorkingDayRepository>();
            _manager = new WorkingDayManager(_mock.Object);
        }

        //public List<WorkingDayDto> GetAllWorkingDays();
        //public WorkingDayDto GetWorkingDayById(int id);
        //public void UpdateWorkingDayById(WorkingDayDto updatedDto);
        //public void AddNewWorkingDay(DateTime date);

        [TestCaseSource(typeof(GetAllWorkingDaysTestCaseSourse))]
        public void GetAllWorkingDaysTest(List<WorkingDayDto> dtoWorkingDay, List<WorkingDayOutputModel> workingDayOutputModels)
        {
            _mock.Setup(o => o.GetAllWorkingDays()).Returns(dtoWorkingDay).Verifiable();
            List<WorkingDayOutputModel> actual = _manager.GetAllWorkingDays();
            List<WorkingDayOutputModel> expected = new List<WorkingDayOutputModel>(workingDayOutputModels);
            _mock.VerifyAll();
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestCaseSource(typeof(GetWorkingDayByIdTestCaseSourse))]
        public void GetWorkingDayByIdTest(int id, WorkingDayDto dtoWorkingDay, WorkingDayOutputModel workingDayOutputModel)
        {
            _mock.Setup(o => o.GetWorkingDayById(id)).Returns(dtoWorkingDay).Verifiable();
            WorkingDayOutputModel actual = _manager.GetWorkingDayById(id);
            WorkingDayOutputModel expected = workingDayOutputModel;

            _mock.VerifyAll();
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(UpdateWorkingDayByIdTestCaseSourse))]
        public void UpdateWorkingDayByIdTest(int id, WorkingDayDto dtoWorkingDay, WorkingDayInputModel workingDayInputModel)
        {
            WorkingDayDto expected = dtoWorkingDay;
            _mock.Setup(o => o.UpdateWorkingDayById(dtoWorkingDay)).Verifiable();
            _manager.UpdateWorkingDayById(workingDayInputModel);
            _mock.Verify();
        }
        

        //List<WorkingDayDto> dtoWorkingDay= new List<WorkingDayDto>();
        //List<WorkingDayOutputModel> workingDayOutputModels = new List<WorkingDayOutputModel>();
        

        [TestCaseSource(typeof(AddNewWorkingDayTestCaseSourse))]
        public void AddNewWorkingDayTest(WorkingDayDto dtoWorkingDay, WorkingDayInputModel workingDayInputModel, DateTime date)
        {
            WorkingDayDto expected = dtoWorkingDay;
            _mock.Setup(o => o.AddNewWorkingDay(date)).Verifiable();
            _manager.AddNewWorkingDay(date);
            _mock.Verify();
        }
    }
}
