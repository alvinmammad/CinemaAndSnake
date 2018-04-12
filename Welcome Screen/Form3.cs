using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Welcome_Screen
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                foreach (var item in Movie.movies)
                {
                    
                    var user = new User(textBox1.Text ,  textBox2.Text, item.Name, item.Hall, item.Seans, Form1.SeatCount, item.Price);
                    
                    user.Seatnumbers = Form2.Oturacaghlar.Count();
                    user.Price = item.Price * user.Seatnumbers;
                    MessageBox.Show(user.Name + " " +  user.Surname + "\n" +  "Filmin adı : " + user.Movie + "\n" +  "Zalın adı : " + user.Seanstime + "\n"  + "Seans vaxtı : " + user.Hall  +  "\n" + "Sifariş etdiyiniz yerlerin sayı : "  +   user.Seatnumbers + "\n"  + "Biletin ümumi qiyməti :" + user.Price);
                    this.Hide();

                }
            }
        }

        
    }
}
