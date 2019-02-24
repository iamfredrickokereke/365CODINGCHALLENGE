using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe.ClassandObjects
{
    class Song
    {

        // creating datatypes/attributes of a class

        public string artist;
        public string album;
        public int duration;

        // creating a constructor of a class
        public Song()
        {
            Console.WriteLine("playing a song");
        }
    }
}
