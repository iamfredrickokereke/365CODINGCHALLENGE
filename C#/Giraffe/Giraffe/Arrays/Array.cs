using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe.Arrays
{
    class Array
    {
        static void Main()
        {
            int[] luckyNumbers = { 2, 4, 6, 8 };
            luckyNumbers[2] = 20;

            string[] foodItems = { "rice", "beans", "yam" };

            string[] friends = new string[4];

            friends[0] = "meat";
            friends[1] = "salad";

            Console.WriteLine(luckyNumbers[2]);
            Console.WriteLine(foodItems[2]);
            Console.WriteLine(friends[1]);

            /*
            int answer = GetMax2(34, 40);

            Console.WriteLine(answer);

            int answer2 = Getmax3(23, 67, 90);

            Console.WriteLine(answer2);

           */
        }

           /*
        static int GetMax2(int num1, int num2)
        {
            int result;
            
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }

        // method used to check max value between 3 values

        static int Getmax3(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1>= num3) { result = num1; }

            else if( num2 >= num1 && num2 >= num3) { result = num2; }

            else { result = num3; }

            return result;
        }

       */
    }
}
