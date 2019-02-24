using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe.ClassandObjects
{
    class Program
    {
        static void Main()
        {
            Book book1 = new Book();

            book1.author = "Fredrick Okereke";
            book1.title = "Beyond the statusquo";
            book1.pages = 900;
            

            Console.WriteLine(book1);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.title);
            Console.WriteLine(book1.pages);

            //2nd way to create an object i.e an instance of a class

            Song song1 = new Song
            {
                album = "Jesus take the wheel",
                artist = "Fredrick kelly",
                duration = 150
            };

            Console.WriteLine(song1.artist);


            Student stdprofile1 = new Student("Fred", "Computer Engineering", 4.9);

            Student stdprofile2 = new Student("ogechi", "CS", 2.8);

            Console.WriteLine(stdprofile1.gpa);
            Console.WriteLine(stdprofile1.hasHonors());



            Movie Avengers = new Movie("The Avengers", "Hanks Anuku", "P-G");

            Console.WriteLine(Avengers.rating);




        }
    }
}
