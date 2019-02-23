using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe.Switch
{
    class UsingSwitch
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Hello Dear, Enter a number to check the Day: ");
            int input = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Today is {0}", CheckDay(input) );

        }

        static string CheckDay(int getNum)
        {
            string getDay;

            switch (getNum)
            {
                case 0:
                    getDay = "Sunday";
                    break;
                case 1:
                    getDay = "Monday";
                    break;
                case 2:
                    getDay = "Tuesday";
                    break;
                case 3:
                    getDay = "Wednesday";
                    break;
                case 4:
                    getDay = "Thursday";
                    break;
                case 5:
                    getDay = "Friday";
                    break;
                case 6:
                    getDay = "Saturday";
                    break;

                default:
                    getDay = "invalid number";
                    break;


            }

            return getDay;
        }
    }
}
