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
    public partial class end : Form
    {
        public end()
        {
            InitializeComponent();
        }

        //new order button
        private void button3_Click(object sender, EventArgs e)
        {        
             user_select f9 = new user_select();
             f9.Show();
             this.Hide();          
        }

        //close button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
