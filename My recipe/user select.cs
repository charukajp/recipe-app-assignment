using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_recipe
{
    public partial class user_select : Form
    {
        int carval;
        public user_select()
        {
            InitializeComponent();

        }
        //button load method 
        public void buttonlaod()
        {
            Registerform f4 = new Registerform(label8.Text , carval);
            f4.Show();
            Hide();
        }

        //1st button 
        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "Alto - manual";
            carval = 3000;
            buttonlaod();
        }

        //2nd button
        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = "Alto (Japan) - Automatic";
            carval = 3500;
            buttonlaod();
        }

        //3rd button
        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "Toyota Axio - Automatic";
            carval = 5000;
            buttonlaod();
        }

        //4th button
        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = "Toyota prius - Automatic";
            carval = 5500;
            buttonlaod();
        }

        //5th button
        private void button5_Click(object sender, EventArgs e)
        {
            label8.Text = "Toyota Hiace van - Automatic";
            carval = 7000;
            buttonlaod();
        }

        //6th button
        private void button6_Click(object sender, EventArgs e)
        {
            label8.Text = "Nissan 18seat van - Manual ";
            carval = 6000;
            buttonlaod();
        }

        //close button
        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
