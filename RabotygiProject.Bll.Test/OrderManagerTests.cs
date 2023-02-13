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
    public void GetAllOrdersTest(List<OrderDto> receivedOrders, List<OrderOutputModel> expectedOrders)
    {
        _mock.Setup(o => o.GetAllOrders()).Returns(receivedOrders).Verifiable();
        List<OrderOutputModel> actual = _manager.GetAllOrders();
        List<OrderOutputModel> expected = expectedOrders;
        _mock.VerifyAll();
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestCaseSource(typeof(GetAllCompletedOrdersTestSources))]
    public void GetAllCompletedOrdersTest(List<OrderDto> receivedOrders, List<OrderOutputModel> expectedOrders)
    {
        _mock.Setup(o => o.GetAllCompletedOrders()).Returns(receivedOrders).Verifiable();
        List<OrderOutputModel> actual = _manager.GetAllCompletedOrders();
        List<OrderOutputModel> expected = expectedOrders;
        _mock.VerifyAll();
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestCaseSource(typeof(GetAllNotCompletedOrdersTestSources))]
    public void GetAllNotCompletedOrdersTest(List<OrderDto> receivedOrders, List<OrderOutputModel> expectedOrders)
    {
        _mock.Setup(o => o.GetAllNotCompletedOrders()).Returns(receivedOrders).Verifiable();
        List<OrderOutputModel> actual = _manager.GetAllNotCompletedOrders();
        List<OrderOutputModel> expected = expectedOrders;
        _mock.VerifyAll();
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestCaseSource(typeof(GetAllOrdersByClientIdTestSources))]
    public void GetAllOrdersByClientIdTest(int id, List<OrderDto> receivedOrders, List<OrderOutputModel> expectedOrders)
    {
        _mock.Setup(o => o.GetAllOrdersByClientId(id)).Returns(receivedOrders).Verifiable();
        List<OrderOutputModel> actual = _manager.GetAllOrdersByClientId(id);
        List<OrderOutputModel> expected = expectedOrders;
        _mock.VerifyAll();
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestCaseSource(typeof(GetOrderByIdTestSources))]
    public void GetOrderByIdTest(int id, OrderDto receivedOrder, OrderOutputModel expectedOrder)
    {
        _mock.Setup(o => o.GetOrderById(id)).Returns(receivedOrder).Verifiable();
        OrderOutputModel actual = _manager.GetOrderById(id);
        OrderOutputModel expected = expectedOrder;
        _mock.VerifyAll();
        Assert.AreEqual(expected, actual);
    }
}