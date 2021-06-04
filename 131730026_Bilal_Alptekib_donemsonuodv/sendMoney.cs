using _131730026_Bilal_Alptekib_donemsonuodv.DOMAIN;
using System;
using _131730026_Bilal_Alptekib_donemsonuodv.SERVICE;
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
    public partial class sendMoney : Form
    {
        Custumer cs, csReciever;
        
        public sendMoney(Custumer custumer,Custumer custumerReciever)
        {

            cs = custumer;
            csReciever = custumerReciever;
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            custumerService custumerService = new custumerService();
            
            try
            {
                csReciever.Iban = tbxIban.Text;
                custumerService.sendMoney(cs,csReciever,Convert.ToDecimal(tbxAmount.Text));
                
                //cs.BankCard.Balance = cs.BankCard.Balance;
                decimal a = (Convert.ToDecimal(tbxAmount.Text));
                mainForm mainForm = new mainForm(a,cs);
                mainForm.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"HATA {ex.Message}");
            }



            //mainForm.Close();
            this.Close();
        }

     
    }
}
