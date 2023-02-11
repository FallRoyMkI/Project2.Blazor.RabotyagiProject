using Moq;
using RabotyagiProject.Bll;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotygiProject.Bll.Test.TestCaseSourse;

namespace RabotygiProject.Bll.Test;

public class OrderManagerTests
{
    private OrderManager _manager;
    private Mock<IOrderRepository> _mock;

    [SetUp]
    public void SetUp()
    {
        _mock = new Mock<IOrderRepository>();
        _manager = new OrderManager(_mock.Object);
    }

    [TestCaseSource(typeof(GetAllOrdersTestSources))]
    public void GetAllOrders(List<OrderDto> receivedOrders, List<OrderOutputModel> expectedOrders)
    {
        _mock.Setup(o => o.GetAllOrders()).Returns(receivedOrders).Verifiable();
        List<OrderOutputModel> actual = _manager.GetAllOrders();
        List<OrderOutputModel> expected = expectedOrders;
        _mock.VerifyAll();
        CollectionAssert.AreEqual(expected, actual);
    }
}