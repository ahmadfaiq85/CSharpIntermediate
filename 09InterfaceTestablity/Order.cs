using System;

namespace InterfaceTestablity
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; internal set; }
        public Shipment Shipment { get; set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }
    }
}