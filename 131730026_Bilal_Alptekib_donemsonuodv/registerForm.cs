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
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }


        private void textBox2_Enter(object sender, EventArgs e)
        {
            enter(label2);

        }


        private void enter(Label lbl)
        {
            lbl.Visible = false;
        }
        private void leave(Label lbl)
        {
            if (lbl.Text.Length == 0)
            {
                lbl.Visible = true;
            }
            else
            {
                lbl.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            enter(label7);
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            enter(label4);
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            enter(label5);
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            enter(label3);
        }

        private void tbxIdentityNumber_Enter(object sender, EventArgs e)
        {
            enter(label6);
        }
    }
}
