using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe.Exponent
{
    class Exponent
    {
        static void Main()
        {
            Console.WriteLine(Getpower(2,5));
        }

        static int Getpower(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;

            }

            return result;

        }
    }
}
