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
    public partial class registerForm : Form
    {
        loginForm lgForm = new loginForm();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (checkBox1.Checked)
                {
                    registerWithCreditcard();


                }
                else
                {
                    registerWithoutCreditCard();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Bir Hata Alındı Lütfen Kutucukları kontrol ediniz Hata= {ex.Message}");
            }
        }

        private void registerWithCreditcard()
        {
            string iban = ibanCreator();
            custumerService cs = new custumerService();
            BankCard bankcard = new BankCard(iban, balanceCreator(),cvvCreator(),cardNumberCreator(),dateTimerCreator());
            CreditCard creditcard = new CreditCard(iban,maxCreditCreator(),cardNumberCreator());
            Custumer custumer = new Custumer(tbxName.Text, tbxSurname.Text, tbxEmail.Text, tbxPassword.Text, ibanCreator(), tbxIdentityNumber.Text, comboBox1.SelectedItem.ToString(),creditcard,bankcard);

            cs.saveCustumerWithCreditCard(custumer, bankcard, creditcard);
            
            lgForm.Show();
            this.Hide();
        }
        private void registerWithoutCreditCard()
        {
            string iban = ibanCreator();
            custumerService cs = new custumerService();
            BankCard bankcard = new BankCard(iban, balanceCreator(), cvvCreator(), cardNumberCreator(), dateTimerCreator());
            Custumer custumer = new Custumer(tbxName.Text, tbxSurname.Text, tbxEmail.Text, tbxPassword.Text, ibanCreator(), tbxIdentityNumber.Text, comboBox1.SelectedItem.ToString(),bankcard);

            cs.saveCustumerWithoutCreditCard(custumer, bankcard);
            lgForm.Show();
            this.Hide();
        }
        private string ibanCreator()
        {
            Random random = new Random();
            return $"{"TR"}{random.Next(10, 99)}{random.Next(100000000, 999999999)}{random.Next(100000000, 999999999)}{random.Next(1000, 9999)}";
        }
        private decimal balanceCreator()
        {
        
            Random random = new Random();
            if (comboBox1.SelectedItem.ToString() == "Mühendis" || comboBox1.SelectedItem.ToString() == "Doktor" || comboBox1.SelectedItem.ToString() == "Mimar")
            {
                return random.Next(5000, 50000);
            }
            else
            {
                return random.Next(4000, 15000);
            }
            
            
        }
        private int cvvCreator()
        {
            Random random = new Random();
            return random.Next(100, 999);
        }
        private string cardNumberCreator()
        {

            Random random = new Random();
            return $"{random.Next(10, 99)}{random.Next(100000000, 999999999)}{random.Next(10000, 99999)}";
        }
        private DateTime dateTimerCreator()
        {
            DateTime dateTime = DateTime.Now;
            
            var date = dateTime.AddYears(10);
            //DateTime date = DateTime.Parse(combined);
            return date;//date.ToShortDateString();
        }
        private decimal maxCreditCreator()
        {
            
            Random random = new Random();
            if (comboBox1.SelectedItem.ToString() == "Mühendis" || comboBox1.SelectedItem.ToString() == "Doktor" || comboBox1.SelectedItem.ToString() == "Mimar")
            {
                return  random.Next(50000, 500000);
            }
            else
            {
                return  random.Next(40000, 150000);
            }
        }
    }
}
