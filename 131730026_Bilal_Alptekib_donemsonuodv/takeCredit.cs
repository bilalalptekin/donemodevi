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
    public partial class takeCredit : Form
    {
        Custumer custumer;
        public takeCredit(Custumer cs)
        {
            custumer = cs;
            InitializeComponent();


        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            custumerService custumerService = new custumerService();
            try
            {
                custumerService.takeCredit(custumer, Convert.ToDecimal(tbxTutar.Text));
                custumer.BankCard.Balance = custumer.BankCard.Balance;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Girdiğiniz Miktar Çekebileceğiniz max Kredi Tutarından Fazla {ex.Message}");
            }
            mainForm mainForm = new mainForm(custumer);
            mainForm.Show();
            this.Close();
        }
    }
}
