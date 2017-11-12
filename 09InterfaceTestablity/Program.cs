using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestablity
{
    class Program
    {
        //An interface is a language construct similar to a class in terms of syntax
        //But fundamentally different.
        //An interface is purely a declaration and the members are not declared
        //An interface can only declare methods and properties, but not fields 
        //(because fields are about implementation detail)
        //Members of interface do not have access modifier
        //Interfaces help with building loosely coupled applications.
        //We reduce coupling between two classes by putting an interface between them.
        //This way if a class changes, it will have no impact on the class that is dependant
        //on it, as long as the interface implementation is kept the same.

        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}
