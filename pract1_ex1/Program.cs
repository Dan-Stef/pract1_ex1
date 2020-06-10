using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter triangle side a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter triangle side b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double S = (a + b) / 2;
            Console.WriteLine("Triangle square is: " + S);
            Console.ReadKey();
        }
    }
}
