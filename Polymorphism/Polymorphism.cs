using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism        // occurs classes realted to each other by inheritance 
{
    public class Shape                    // base class
    {
        public virtual void draw()           // method name
        {
            Console.WriteLine("Drawing");
            Console.ReadLine();
        }
    }
    public class Rectangle : Shape             // derived class : base class
    {
        public override void draw()             // same method name
        {
            Console.WriteLine("Drawing Rectangle");
            Console.ReadLine();
        }
    }
    public class Circle : Shape                     // derived class : base class
    {
        public override void draw()               // same method name
        {
            Console.WriteLine("Drawing Circle");
            Console.ReadLine();
        }
    }

    public class TestPolymorphism
    {
        public static void Main(string[] args)
        {
            Shape s = new Shape();             // create shape object
            Shape s1 = new Rectangle();        // create rectangle object
            Shape s2 = new Circle();            // create circle object
            s.draw();
            s1.draw();
            s2.draw();
        }
    }

}
