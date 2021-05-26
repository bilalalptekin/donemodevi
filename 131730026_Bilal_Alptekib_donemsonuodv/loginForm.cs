using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _131730026_Bilal_Alptekib_donemsonuodv
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

        }



        private void linklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                registerForm registerform = new registerForm();
                this.Hide();
                registerform.Show();
        }
    }
}
