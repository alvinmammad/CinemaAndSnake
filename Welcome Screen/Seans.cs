using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_Screen
{
    class Seans
    {
        public static List<Seans> seans = new List<Seans>();
        public string Time;
        public int ID;


        public Seans (string _time, int _id)
        {
            Time = _time;
            ID = _id;
            seans.Add(this);

        }
    }
}
