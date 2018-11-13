using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath myResult1 = new MyMath();
            myResult1.Multiply(2, 5);
            Console.WriteLine(myResult1.GetResult());

            myResult1.Divide(10, 5);
            Console.WriteLine(myResult1.GetResult());

            myResult1.Subtract(7, 6);
            Console.WriteLine(myResult1.GetResult());

            myResult1.Add(8, 4);
            Console.WriteLine(myResult1.GetResult());
        }

    }
}
