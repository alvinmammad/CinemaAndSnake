using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_Screen
{
    class Hall
    {
        public static List<Hall> halls = new List<Hall>();
        public string HallName;
        public int ID;



            public Hall (string _hallname , int _id)
        {
            HallName = _hallname;
            ID = _id;

            halls.Add(this);
        }
    }
}
