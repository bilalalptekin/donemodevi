using _131730026_Bilal_Alptekib_donemsonuodv.DOMAIN;
using _131730026_Bilal_Alptekib_donemsonuodv.SERVICE;
using System;
using System.Collections;
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




        private void linklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                registerForm registerform = new registerForm();
                this.Hide();
                registerform.Show();
        }


        private void Login()
        {
            //ArrayList degerler = new ArrayList();
            Custumer custumer = new Custumer(textBox1.Text,textBox2.Text);
            custumerService cs = new custumerService();

            //degerler.Add();
            try
            {
                if (cs.login(custumer))//degerler[0].ToString()==custumer.Name&&degerler[1].ToString()==custumer.Surname)
                {
                    mainForm mF = new mainForm();
                    mF.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen Mail Adresinizi Ve/Veya Şifrenizi Kontrol Edin");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen Mail Adresinizi Ve/Veya Şifrenizi Kontrol Edin"+" "+ex.Message);
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
