using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterfaceTestablity;

namespace InterfaceTestability.Tests
{
    [TestClass]
    public class OrderProcessorTests
    {
        //Unit test is part of automated practice which helps improve the quality of our code
        //with automated test we write code to automatically test our own code.
        //This helps catch bugs early on as we change our code.
        //In order to unit test a class, we need to isolate it. This means: we need to assume
        //that all the other classes in our application is working properly and see
        //that the class under test is working as expected.
        //A class that has tight dependencies to other class cannot be isolated.

        //METHODNAME_CONDITION_EXPECTATION

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipping_ThrowsAnException()
        {
            OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(2), order.Shipment.ShippingDate);

        }

        public class FakeShippingCalculator : IShippingCalculator
        {
            public float CalculateShipping(Order order)
            {
                return 1;
            }
        }
    }
}
