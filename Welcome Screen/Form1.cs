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
    public partial class Form1 : Form
    {
        public static int SeatCount;
       
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Welcome_Screen.Seans.seans)
            {
                comboBox1.Items.Add(item.Time);
                comboBox3.Items.Add(item.Time);
                comboBox5.Items.Add(item.Time);
                comboBox7.Items.Add(item.Time);
            }
            foreach (var item in Welcome_Screen.Hall.halls)
            {
                comboBox2.Items.Add(item.HallName);
                comboBox4.Items.Add(item.HallName);
                comboBox6.Items.Add(item.HallName);
                comboBox8.Items.Add(item.HallName);
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
          
            
            Form1 form1 = new Form1();

            if (comboBox1.SelectedItem !=null && comboBox2.SelectedItem != null)
            {
                switch (comboBox2.SelectedItem.ToString())
                {
                    case "French Hall":
                        SeatCount = 9;
                        break;

                    case "Indian Hall":
                        SeatCount = 6;
                        break;

                    case "British Hall":
                        SeatCount = 10;
                        break;

                    case "American Hall":
                        SeatCount = 12;
                        break;

                       
                }
                var Film = new Movie("Allied", 6.30, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose hall and seans !");
            }
            



        }
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if (comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
            {
                switch (comboBox6.SelectedItem.ToString())
                {
                    case "French Hall":
                        SeatCount = 9;
                        break;

                    case "Indian Hall":
                        SeatCount = 6;
                        break;

                    case "British Hall":
                        SeatCount = 10;
                        break;

                    case "American Hall":
                        SeatCount = 12;
                        break;


                }
                var Film = new Movie("Iron Man", 7.35, comboBox5.SelectedItem.ToString(), comboBox6.SelectedItem.ToString());
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose hall and seans !");
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
            {
                switch (comboBox4.SelectedItem.ToString())
                {
                    case "French Hall":
                        SeatCount = 9;
                        break;

                    case "Indian Hall":
                        SeatCount = 6;
                        break;

                    case "British Hall":
                        SeatCount = 10;
                        break;

                    case "American Hall":
                        SeatCount = 12;
                        break;


                }
                var Film = new Movie("Lion", 5.90, comboBox3.SelectedItem.ToString(), comboBox4.SelectedItem.ToString());
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose hall and seans !");
            }
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if (comboBox7.SelectedItem != null && comboBox8.SelectedItem != null)
            {
                switch (comboBox8.SelectedItem.ToString())
                {
                    case "French Hall":
                        SeatCount = 9;
                        break;

                    case "Indian Hall":
                        SeatCount = 6;
                        break;

                    case "British Hall":
                        SeatCount = 10;
                        break;

                    case "American Hall":
                        SeatCount = 12;
                        break;

                       
                }
                var Film = new Movie("Thor Ragnarok", 12.20, comboBox7.SelectedItem.ToString(), comboBox8.SelectedItem.ToString());
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose hall and seans !");
            }
        }

       
    }
}
