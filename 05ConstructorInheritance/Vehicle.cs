using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritance
{
    public class Vehicle
    {
        public string _registrationNumber { get; set; }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine($"Vehicle is being initialized. {registrationNumber}");
        }
    }
}
