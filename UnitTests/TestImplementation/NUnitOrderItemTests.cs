namespace UnitTesting.TestImplementation
{
    using NUnit.Framework;
    using HomeTaskSimpleOrderApp.Orders;

    [TestFixture]
    public class NUnitOrderItemsTests
    {
        private OrderItem orderItem;

        [SetUp]
        public void TestInit()
        {
            orderItem = new OrderItem("Order Item Name", 15, 10);
        }

        [Test]
        public void VerifyingOrderItemAmountCalculation()
        {
            Assert.True(orderItem.Amount.Equals(150));
        }

        [Test]
        public void VerifyingOrderItemAmountRecalculationCalculationByQuantityChange()
        {
            orderItem.Quantity++;
            Assert.AreEqual(orderItem.Amount, 165);
            orderItem.Quantity--;
            Assert.AreEqual(orderItem.Amount, 150);
        }

        [Test]
        public void VerifyingOrderItemAmountRecalculationCalculationByPriceChange()
        {
            orderItem.Price ++;
            Assert.AreEqual(orderItem.Amount, 160);
            orderItem.Price--;
            Assert.AreEqual(orderItem.Amount, 150);
        }

    }
}
