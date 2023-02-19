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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();

        }
        //Button hover
        private void btn_hover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Size = new Size(145, 51);
        }
        //Button leave
        private void btn_leave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Size = new Size(140, 46);

        }
        //Continue button click
        private void button1_Click(object sender, EventArgs e)
        {
            //checking if they entered a valid birthday
                //by text length
            if (textBox1.TextLength > 10 || textBox1.TextLength < 10)
            {
                //error massage
                string message = "Please enter valid birthday.. " + Environment.NewLine + "or make sure to follow right method.  " + Environment.NewLine + " ex:- 1990.01.01 ";
                string title = "Try again";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            else
            {
                //only if the text length ok variables get their values
                int year = int.Parse(textBox1.Text.Substring(0, 4));
                int month = int.Parse(textBox1.Text.Substring(5, 2));
                int day = int.Parse(textBox1.Text.Substring(8, 2));

                //age calculate
                int currentYear = DateTime.Now.Year;
                int value = currentYear - year;

                // again check if the variable values ok with a birthday to check a valid birthday
                if (year > currentYear || year < 1920 || month < 1 || month > 12 || day > 31 || day < 1)
                {
                    //error massage
                    string message = "Please enter valid birthday.. \nor make sure to follow right method.  \nex:- 1990.01.01 ";
                    string title = "Try again";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }

                //check the age validity
                else if (value < 17)
                {
                    //warning message
                    string message = "You cannot use this application. Please leave";
                    string title = "Close the application";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                }

                //if all okay laod next form
                else
                {
                    user_select f3 = new user_select();
                    f3.Show();
                    Hide();
                }
            }
        }
        
        //textbox restrict to use only numbers
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
        
        //close buton
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
