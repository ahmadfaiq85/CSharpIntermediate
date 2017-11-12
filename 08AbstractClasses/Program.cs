using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract states that a class or member misses implementation 
            //We use abstract when implementation of a member doesn't make sense 
            //in the base class. For example Draw doesn't make sense in a Shape class,
            //it is too abstract. But makes sense in Circle which is a derived class. 
            //When a class member is declared abstract, the class needs to be declared
            //abstract as well. That means that the class is not complete. 
            //In the derived class we need to override the abstract members of the base class.
            
            //var shape = new Shape(); Cannot create an instance of abstract class

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();

        }
    }
}
