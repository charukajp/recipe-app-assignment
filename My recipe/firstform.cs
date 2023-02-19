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
    public partial class firstform : Form
    {
        public firstform()
        {
            InitializeComponent();
        }

        //Button hover effect
        private void btn_hover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Size = new Size(233, 100);
        }
        //button leave effect
        private void btn_leave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Size = new Size(223 , 90);

        }
        //login button click
        private void Login_click(object sender, MouseEventArgs e)
        {
            Loginform f2 = new Loginform();
            f2.Show();
            this.Hide();            

        }
    }
}
