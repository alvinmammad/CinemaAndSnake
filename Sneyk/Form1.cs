using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;


namespace Sneyk
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Width = 900;
            Height = 900;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            timer1.Interval = 100;
            timer1.Start();
            btn.Height = 25;
            btn.Width = 25;
            btn.Left = b;
            btn.Top = c;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Orange;

            this.Controls.Add(textBox1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tail();
            snakesound();
        }

        public void snake()
        {
            this.Controls.Add(parts[bodycount - 1]);
        }
        public void snakesound()
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\P106\Downloads\snake.wav");
            sp.Play();
        }


        public static Random a = new Random();
        public int b = a.Next(1, 600);
        public int c = a.Next(1, 700);
        public List<Button> parts = new List<Button>();
        public int x;
        public int y;
        public int count=0;
        public int bodycount = 1;
   
        public void tail()
        {
            for (int i = 0; i < bodycount; i++)
            {
                Button tail = new Button();
                tail.Width = 25;
                tail.Height = 25;
                tail.Top = 100;
                tail.Left = 120 - (i * 20);
                tail.FlatAppearance.BorderSize = 0;
                tail.FlatStyle = FlatStyle.Flat;
                tail.BackColor = Color.Red;
                parts.Add(tail);
                Controls.Add(tail);
            }
            parts[0].BackColor = Color.Blue;  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = bodycount-1; i >=0 ; i--)
            {
                if (i == 0)
                {
                    parts[i].Location = new Point(parts[i].Location.X + x, parts[i].Location.Y);

                    parts[i].Location = new Point(parts[i].Location.X, parts[i].Location.Y + y);
                }
                else
                {
                    parts[i].Location = new Point(parts[i - 1].Location.X, parts[i - 1].Location.Y);

                }
            }
            if (parts[0].Left < btn.Left + 20 && parts[0].Left > btn.Left - 20 && parts[0].Top > btn.Top - 20 && parts[0].Top < btn.Top + 20)
            {

                btn.Location = new Point(a.Next(1, 580), a.Next(1, 650));
                count++;
                textBox1.Text = "Say: " + count;
                Button added = new Button();
                added.Top = -20;
                added.Left = -20;
                added.BackColor = Color.Red;
                bodycount++;
                parts.Add(added);
                added.Width = 25;
                added.Height = 25;

                added.FlatStyle = FlatStyle.Flat;
                added.FlatAppearance.BorderSize = 0;

                //SoundPlayer s = new SoundPlayer();

                //while (true)
                //{

                //    s.PlayAndWait("FileName");

                //}
                snake();
                //System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\P106\source\repos\Sneyk\Sneyk\bin\Debug");

                ////sp.PlayLooping();

                //sp.Play();

            }
            for (int i = 1; i < bodycount; i++)
            {
                if (parts[0].Left == parts[i].Left && parts[0].Top == parts[i].Top)
                {
                    timer1.Stop();
                    MessageBox.Show("Game over qaqa . Result is : " + count );
                    Application.Exit();
                }

            }
            if (parts[0].Top > 740)
            {
                parts[0].Location = new Point(parts[0].Location.X, 740);
                timer1.Stop();
                MessageBox.Show("Game over qaqa . Result is : " + count);
                Application.Exit();
            }
            if (parts[0].Left > 770)
            {
                parts[0].Location = new Point(770, parts[0].Location.Y);
                timer1.Stop();
                MessageBox.Show("Game over qaqa . Result is : " + count);
                Application.Exit();
            }
            if (parts[0].Left < 0)
            {
                parts[0].Location = new Point(0, parts[0].Location.Y);
                timer1.Stop();
                MessageBox.Show("Game over qaqa . Result is : " + count);
                Application.Exit();
            }
            if (parts[0].Top < 0)
            {
                parts[0].Location = new Point(parts[0].Location.X, 0);
                timer1.Stop();
                MessageBox.Show("Game over qaqa . Result is : " + count);

                Application.Exit();
            }
        }
        public Keys keys = Keys.U;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            x = 0;
            y = 0;
            Keys newArrow = e.KeyCode;
            if (keys == Keys.Up && newArrow == Keys.Down)
            {
                newArrow = Keys.Up;
            }
            if (keys == Keys.Down && newArrow == Keys.Up)
            {
                newArrow = Keys.Down;
            }
            if (keys == Keys.Left && newArrow == Keys.Right)
            {
                newArrow = Keys.Left;
            }
            if (keys == Keys.Right && newArrow == Keys.Left)
            {
                newArrow = Keys.Right;
            }
            if (newArrow == Keys.Up)
            {
                y = -20;
                keys = Keys.Up;
            }
            if (newArrow == Keys.Down)
            {
                y = 20;
                keys = Keys.Down;
            }
            if (newArrow == Keys.Left)
            {
                x = -20;
                keys = Keys.Left;
            }
            if (newArrow == Keys.Right)
            {
                x = 20;
                keys = Keys.Right;

            }




        }
    }
}
