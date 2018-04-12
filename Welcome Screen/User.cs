using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_Screen
{
    class User
    {
        public List<User> users = new List<User>();
        public string Name;
        public string Surname;
        public string Movie;
        public string Hall;
        public string Seanstime;
        public int Seatnumbers;
        public double Price;

        public User(string _name, string _surname, string _movie, string _hall, string _seanstime, int _seatnumbers, double _price)
        {

            Name = _name;
            Surname = _surname;
            Movie = _movie;
            Hall = _hall;
            Seanstime = _seanstime;
            Seatnumbers = _seatnumbers;
            Price = _price;
            users.Add(this);
        }
    }
}
