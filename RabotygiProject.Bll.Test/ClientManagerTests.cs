using Moq;
using NUnit.Framework;
using RabotyagiProject.Bll;
using RabotyagiProject.Bll.Models;
using RabotygiProject.Bll.Test.TestCaseSourse;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;

namespace RabotygiProject.Bll.Test
{
    public class ClientManagerTests
    {
        private ClientManager _manager;
        private Mock<IClientRepository> _mock;
        [SetUp]
        public void SetUp()
        {
            _mock = new Mock<IClientRepository>();
            _manager = new ClientManager(_mock.Object);
        }

        [TestCaseSource(typeof(GetAllClientsTestCaseSourse))]
        public void GetAllClientsTest(List<ClientDto> clientDto, List<ClientOutputModel> modelClient)
        {
            _mock.Setup(o => o.GetAllClients()).Returns(clientDto).Verifiable();
            List<ClientOutputModel> actual = _manager.GetAllClients();
            List<ClientOutputModel> expected = new List<ClientOutputModel>(modelClient);
            _mock.VerifyAll();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(GetClientByIdTestCaseSourse))]
        public void GetClientByIdTest(ClientDto clientDto, ClientOutputModel modelClient, int id)
        {
            _mock.Setup(o => o.GetClientById(id)).Returns(clientDto).Verifiable();
            ClientOutputModel actual = _manager.GetClientById(id);
            ClientOutputModel expected = modelClient;

            _mock.VerifyAll();
            Assert.AreEqual(expected, actual);
        }

        //[TestCaseSource(typeof(UpdateBusyTimeByIdTestCaseSourse))]
        //public void UpdateBusyTimeByIdTest(BusyTimeDto dtoBusyTime, BusyTimeInputModel modelBusyTime)
        //{
        //    BusyTimeDto expected = dtoBusyTime;
        //    _mock.Setup(o => o.UpdateBusyTimeById(dtoBusyTime)).Verifiable();
        //    _manager.UpdateBusyTimeById(modelBusyTime);
        //    _mock.Verify();
        //}

        //[TestCaseSource(typeof(AddNewBusyTimeTestCaseSourse))]
        //public void AddNewBusyTimeTest(BusyTimeDto dtoBusyTime, BusyTimeInputModel modelBusyTime)
        //{
        //    BusyTimeDto expected = dtoBusyTime;
        //    _mock.Setup(o => o.AddNewBusyTime(dtoBusyTime)).Verifiable();
        //    _manager.AddNewBusyTime(modelBusyTime);
        //    _mock.Verify();
        //}
    }
}

