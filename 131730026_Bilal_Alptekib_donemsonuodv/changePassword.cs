using _131730026_Bilal_Alptekib_donemsonuodv.DOMAIN;
using _131730026_Bilal_Alptekib_donemsonuodv.SERVICE;
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
    public partial class changePassword : Form
    {
        Custumer custumer;
        public changePassword(Custumer cs)
        {
            custumer = cs;
            InitializeComponent();
        }



        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (tbxSıfre.Text.Equals(tbxSıfre2.Text))
            {
                custumer.Password = tbxSıfre.Text;
                custumerService cs = new custumerService();
                cs.ChangePassword(custumer);
                MessageBox.Show("Şifreniz Başarılı Bir Şekilde Değişti");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Girdiğiniz Şifreyi Kontrol Edin Şifreler Aynı Değil ");
            }
            //şimdilik sadece kapat ileride try catch e bağlanacak send money de
        }
    }
}
