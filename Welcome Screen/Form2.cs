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
    public partial class Form2 : Form
    {

        public static List<Button> Oturacaghlar = new List<Button>();
        public Button btn;
        public int TopPos = 0;
        public int LeftPos = 0;
        public static int Seatnumber = 0;
        public int CounT = Form1.SeatCount;

        public Form2()
        {
            InitializeComponent();
            for (int i = 0; i < Form1.SeatCount / 2; i++)
            {
                LeftPos = 50 * i;

                for (int j = 0; j < CounT; j++)
                {
                    btn = new Button();
                    btn.Height = 30;
                    btn.Width = 40;
                    btn.Left = LeftPos;
                    btn.Top = TopPos;
                    btn.Text = Seatnumber.ToString();
                    btn.BackColor = Color.Yellow;
                    btn.Click += new EventHandler(this.Button_CLick);
                    Controls.Add(btn);
                    Seatnumber++;
                    LeftPos += 50;

                }
                CounT -= 2;
                TopPos += 50;
                LeftPos = 0;
            }

        }
        void Button_CLick(object sender, EventArgs e)
        {
            string X = "";
            string Y = "";
            int count = 0;
            Button bTn = sender as Button;
            bTn.BackColor = Color.PaleTurquoise;
            Oturacaghlar.Add(bTn);
            foreach (var item in Oturacaghlar)
            {
                if (bTn.Text==item.Text)
                {


                    count++;
                }  
                    

                
            }
           

            if (count == 1)
            {
                textBox1.Text += " " + bTn.Text;
            }
            else
            {
                X = bTn.Text;
                Oturacaghlar.Remove(bTn);
                foreach (var item in Oturacaghlar)
                {
                    if (X == item.Text)
                    {
                        item.BackColor = Color.Green;
                        Oturacaghlar.Remove(item);
                        break;
                    }
                }
                foreach (var item in Oturacaghlar)
                {

                    Y += " " + item.Text;
                    textBox1.Text = Y;


                }
                if (Oturacaghlar.Count == 0)
                {
                    textBox1.Text = "";
                }
            }



        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.ShowDialog();
            
        }
    }
}
