using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe.Ifstatements
{
    class Ifstatements
    {
        static void Main()
        {
            Console.WriteLine("Welcome to a simple calculator...");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.Write("Enter the preferred Operator: ");
            string op = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            int result;

            if (op.Equals("+")){ result = num1 + num2;}
            else if (op.Equals("-")) { result = num1 - num2; Console.WriteLine(result); }
            else if (op.Equals("*")) { result = num1 * num2; Console.WriteLine(result); }
            else if (op.Equals("/")) { result = num1 / num2; Console.WriteLine(result); }
            else { Console.Write("Invalid Operator used"); }

        }
    }
}
