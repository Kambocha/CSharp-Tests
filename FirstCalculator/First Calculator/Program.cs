using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Enter the first number: ");
            num = Convert.ToDouble(Console.ReadLine());

            int symbol;
            Console.WriteLine("Enter the Symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());

            double numtwo;
            Console.WriteLine("Enter the second number: ");
            numtwo = Convert.ToDouble(Console.ReadLine());

            if (symbol == '+')
            {
                Console.WriteLine(num + numtwo);
            }
            else if (symbol == '-')
            {
                Console.WriteLine(num - numtwo);
            }
            else if (symbol == '/')
            {
                Console.WriteLine(num / numtwo);
            }
            else if (symbol == '*')
            {
                Console.WriteLine(num * numtwo);
            }
        }
    }
}
