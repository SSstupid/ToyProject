using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };

            // Polymorphism at work #2: the virtual method Draw is
            // invoked on each of the derived classes, not the base class.
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }

        public class Shape
        {
            // A few example members
            public int X { get; private set; }
            public int Y { get; private set; }
            public int Height { get; set; }
            public int Width { get; set; }

            // Virtual method
            public virtual void Draw()
            {
                Console.WriteLine("Performing base class drawing tasks");
            }
        }

        public class Circle : Shape
        {
            public override void Draw()
            {
                // Code to draw a circle...
                Console.WriteLine("Drawing a circle");
               // base.Draw();
            }
        }
        public class Rectangle : Shape
        {
            public override void Draw()
            {
                // Code to draw a rectangle...
                Console.WriteLine("Drawing a rectangle");
                //base.Draw();
            }
        }
        public class Triangle : Shape
        {
            public override void Draw()
            {
                // Code to draw a triangle...
                Console.WriteLine("Drawing a triangle");
               // base.Draw();
            }
        }
    }
}
