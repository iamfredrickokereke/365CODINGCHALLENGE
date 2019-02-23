using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe.Methods
{
    class RootOfaNumber
    {

        static void Main()
        {
            Console.WriteLine("Enter the number to be cubed: ");
            int cubedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( CubeRoot(cubedNumber));
            Console.ReadLine();

        }

        static int CubeRoot(int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}
