using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_Screen
{
    class Movie
    {
        public static List<Movie> movies = new List<Movie>();
        public double Price;
        public string Hall;
        public string Seans;
        public string Name;

            public Movie(string _name , double _price , string _hall , string _seans)
        {
            Name = _name;
            Price = _price;
            Hall = _hall;
            Seans = _seans;
            movies.Add(this);
        }
    }
}
