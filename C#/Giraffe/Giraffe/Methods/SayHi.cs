using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe.Methods
{
    class SayHi
    {
        static void Main(string[] args)
        {
            Greet();
            Console.ReadLine();
        }

        static void Greet()
        {
            Console.WriteLine("Hello user!");
        }
    }
}
