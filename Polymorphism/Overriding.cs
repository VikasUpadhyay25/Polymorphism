using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism       // Method Overriding
//{
//    public class Animal        // base class
//    {
//        public virtual void eat()
//        {
//            Console.WriteLine("Eating");
//            Console.ReadLine();
//        }
//    }
//    public class Dog : Animal       // derived class 
//    {
//        public override void eat()       // same base class name
//        {
//            Console.WriteLine("Eating bread");
//            Console.ReadLine();
//        }
//    }
//    public class Overriding
//    {
//        public static void Main(string[] args)
//        {
//            Dog d1 = new Dog();
//            d1.eat();
//        }
//    }
//}


    // Using Base keyword - we can access base class fields , methods & constructor
{
    public class Animal
    {
        public string color = "Black";
    }
    public class Dog : Animal
    {
        string color = "Golden";
        public void showColor()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }
    }

    public class TestBase
    {
        public static void Main(string[] args)
        {
            Dog d = new Dog();
            d.showColor();
        }
    }
}