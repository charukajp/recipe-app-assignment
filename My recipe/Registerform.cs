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
    public partial class Registerform : Form
    {

        public String cartype;
        public int carval;
        public int cost;
        public Registerform(String cartype, int carval)
        {
            InitializeComponent();
            this.cartype = cartype;
            this.carval = carval;
        }

        private void Registerform_Load(object sender, EventArgs e)
        {
            //load with labels and cartype
            label1.Text = " Welcome.. ";
            label7.Text = "You have selected " + cartype;
            
        }

        //back button
        private void back_button(object sender, EventArgs e)
        {
            user_select f5 = new user_select();
            f5.Show();
            Hide();
        }

        //method to calculate cost
        public void costdet()
        {
            //if driver want select 5000 added
            int drivcost = 0;
            if (radioButton3.Checked == true)
            {
                drivcost = 5000;
            }
            if (radioButton4.Checked == true)
            {
                drivcost = 0;
            }
            //and shows in the label in runtime
            cost = (carval * (int)numericUpDown1.Value) + drivcost;
            label12.Text = cost.ToString();
        }

        //submit button 
        private void button2_Click(object sender, EventArgs e)
        {
            //assign values to variables 
            String fname = textBox1.Text;
            String lname = textBox2.Text;
            String nic = textBox5.Text;
            String mobile = textBox3.Text;
            String address = textBox4.Text;
            String gender = "";
            String driver = "";
            String bday = dateTimePicker1.Value.ToString();
            int days = (int)numericUpDown1.Value;

            if (radioButton1.Checked == true)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked == true)
            {
                gender = "Female";
            }
            if (radioButton3.Checked == true)
            {
                driver = "Need a driver";
            }
            else if (radioButton4.Checked == true)
            {
                driver = "Dont need a driver";
            }

            //check if user didnt complete all information

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(driver) || string.IsNullOrEmpty(bday) || string.IsNullOrEmpty(address) || days == 0)
            {
                //sends and erro message if bot completed

                string message = "Did you enter all the details? Please complete everything.";
                string title = "Try again";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            }
            else
            {
                //load next form only if everything complete

                finalform f6 = new finalform(fname, lname, nic, mobile, address, gender, label12.Text, bday , days , cartype , carval );
                f6.Show();
                this.Hide();

            }
        }

        //when user change numeric keys cost changes auto
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            costdet();
        }

        //when user change driver radios keys cost changes auto
        private void radioButton3_Click(object sender, EventArgs e)
        {
            costdet();
        }

        //driver radio key
        private void radioButton4_Click(object sender, EventArgs e)
        {
            costdet();
        }

        //restrict mobile number textbox to only numbers
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        //close button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
