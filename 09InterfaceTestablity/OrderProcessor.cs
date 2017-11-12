using System;

namespace InterfaceTestablity
{
    public  class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
              
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("Order is already shipping");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(2)
            };
        }
    }
}