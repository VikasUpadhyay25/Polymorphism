using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;            // Member OverLoading

namespace Polymorphism       // method overloading  by changing number of parameter
{
   //public class Math
   // {
   //     public int add(int a, int b)   // method 1
   //     {
   //         return a + b;
   //     }

   //     public int add(int a, int b, int c)    // method 2
   //     {
   //         return a + b + c;
   //     }

   //     public class TestMemberOverLoading
   //     {
   //         public static void Main(string[] args)
   //         {
   //             Math myObj = new Math();
   //             Console.WriteLine(myObj.add(5, 7));
   //             Console.WriteLine(myObj.add(1, 9, 17));
   //             Console.ReadLine();
   //         }
   //     }
   // }

    public class Math               // method overloading by changing data type
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public float add(float a, float b)
        {
            return a + b;
        }

        public class TestOverloading
        {
            public static void Main(string[] args)
            {
                Math myObj = new Math();
                Console.WriteLine(myObj.add(5, 9));
                Console.WriteLine(myObj.add(4.3f, 7.6f));
                Console.ReadLine();
            }
        }
    }
}
