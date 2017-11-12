using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method overriding the changing the implementation of an inherited method
            //If we declare a method in the base class, we can override it in the derived class
            //This technic allows us to achieve polymorphism that is object is a shape but have different
            //draw implementation

            List<Shape> shapes = new List<Shape>
            {
                new Circle { Width = 10, Height = 20 },
                new Rectangle { Width = 20, Height = 30 },
                new Triangle {Width = 50, Height = 50 }
            };

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
