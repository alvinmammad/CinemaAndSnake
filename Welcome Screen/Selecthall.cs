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
    public partial class Selecthall : Form
    {
        public List<Button>buttons  = new List<Button>();
        public Button btn;
        public int top = 0;
        public int left = 0;
        public int seatNumber = 1;
        public int count = Form1.SeatCount;
        public Selecthall()
        {
            InitializeComponent();
            for (int i = 0; i < Form1.SeatCount / 2; i++)
            {
                left = 50 * i;

                for (int j = 0; j < count; j++)
                {
                    btn = new Button();
                    btn.Height = 40;
                    btn.Width = 50;
                    btn.Left = left;
                    btn.Top = top;
                    btn.Text = seatNumber.ToString();
                    btn.BackColor = Color.Yellow;
                    btn.Click += new EventHandler(this.BtnClick);
                    Controls.Add(btn);
                    seatNumber++;
                    left += 50;

                }
                count -= 2;
                top += 50;
                left = 0;
            }
        }

                
            
        void BtnClick(object obj , EventArgs args)
        {
            string A = " ";
            string B = " ";
            int count = 0;
            Button Button = obj as Button;
            Button.BackColor = Color.PaleTurquoise;
            buttons.Add(Button);
            foreach (var item in buttons)
            {
                if (Button.Text == item.Text)
                {
                    count++;
                }
            }
            if (count == 1)
            {
                textBox3.Text += " " + Button.Text;
            }
            else
            {
                A = Button.Text;
                buttons.Remove(Button);
                foreach (var item in buttons)
                {
                    if (A == item.Text)
                    {
                        item.BackColor = Color.Green;
                        buttons.Remove(item);
                        break;
                    }
                }
                foreach (var item in buttons)
                {

                    B += " " + item.Text;
                    textBox3.Text = B;


                }
                if (buttons.Count == 0)
                {
                    textBox3.Text = " ";
                }
            }
        }

       

       
    }
}
