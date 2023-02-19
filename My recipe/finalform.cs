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
    public partial class finalform : Form
    {
        String fname;
        String lname;
        String nic;
        String mobile;
        String address;
        String gender;
        String bday;
        String costlabel;
        String cartype;
        int days;
        int carval;

        public finalform()
        {
        }

        //parameters added to all values from last form
        public finalform(String fname, String lname, String nic, String mobile ,String address, String gender, String costlabel, String bday , int days , String cartype, int carval)
        {
            this.fname = fname;
            this.lname = lname;
            this.nic = nic;
            this.mobile = mobile;
            this.address = address;
            this.gender = gender;
            this.costlabel = costlabel;
            this.bday = bday;
            this.cartype = cartype;
            this.days = days;
            this.carval = carval;   

            InitializeComponent();
        }

        private void finalform_Load(object sender, EventArgs e)
        {
            //values load to labels form last form
            fnamelabel.Text = fname;
            lnamelabel.Text = lname;    
            niclabel.Text = nic;
            nolabel.Text = mobile;
            addlabel.Text = address;
            genderlabel.Text = gender;
            bdaylabel.Text = bday;
            clabel.Text = costlabel;
            carlabel.Text = cartype;
            dayslabel.Text = (days).ToString();

        }

        //try again button
        private void button2_Click(object sender, EventArgs e)
        {
            //laod previous form with selected cartype
            Registerform f8 = new Registerform(cartype , carval);
            f8.Show();
            this.Hide();
            
        }

        //submit button
        private void button1_Click(object sender, EventArgs e)
        {
            //load last form
            end end = new end();
            end.Show();
            this.Hide();
        }

        //new order button
        private void button3_Click(object sender, EventArgs e)
        {
            //laod the car select form
            user_select f9 = new user_select();
            f9.Show();
            this.Hide();
        }

        //close button
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
