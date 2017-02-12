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
            try
            {
                Console.Write("Plz input a nuber A:");
                String strNumberA = Console.ReadLine();
                Console.Write("Plz choose an operator + - * / :");
                String strOperate = Console.ReadLine();
                Console.Write("Plz input a nuber B:");
                String strNumberB = Console.ReadLine();
                String strResult = ""; // result


                Operation oper;
                oper = OperationFactory.createOperate(strOperate);
                oper.NumberA = Convert.ToDouble(strNumberA);
                oper.NumberB = Convert.ToDouble(strNumberB);
                strResult = Convert.ToString(oper.GetResult());

                Console.WriteLine("Result is: {0}", strResult);
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: {0}", ex.Message);
            }
        }
    }
}
