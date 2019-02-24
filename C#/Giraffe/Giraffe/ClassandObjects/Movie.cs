using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe.ClassandObjects
{
    class Movie
    {
        //creating attributes of the class

        public string title;
        public string director;
        public string rating;


        //create a movie constructor

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            rating = aRating;
        }

    }
}
