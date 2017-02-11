using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Plz input a nuber A:");
            String A = Console.ReadLine();
            Console.Write("Plz choose an operator + - * / :");
            String B = Console.ReadLine();
            Console.Write("Plz input a nuber B:");
            String C = Console.ReadLine();
            String D = ""; // result

            if (B == "+")
            {
                D = Convert.ToString(Convert.ToDouble(A) + Convert.ToDouble(C));
            }

            if (B == "-")
            {
                D = Convert.ToString(Convert.ToDouble(A) - Convert.ToDouble(C));
            }

            if (B == "*")
            {
                D = Convert.ToString(Convert.ToDouble(A) * Convert.ToDouble(C));
            }

            if (B == "/")
            {
                D = Convert.ToString(Convert.ToDouble(A) / Convert.ToDouble(C));
            }

            Console.WriteLine("Result is: {0}", D);
            Console.Read();
        }
    }
}
