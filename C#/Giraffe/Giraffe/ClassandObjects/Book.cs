using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe.ClassandObjects
{
    /* how to create a class without () acessing 
     * in another class using the keyword public
     * specifying its datatype and method
     */
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {
            Console.WriteLine("Create a book");
        }

    }
}
