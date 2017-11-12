using System;

namespace AbstractClasses
{
    public class Circle : Shape
    {
        public Circle()
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
}