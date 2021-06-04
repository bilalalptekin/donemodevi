using _131730026_Bilal_Alptekib_donemsonuodv.DOMAIN;
using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class mainForm : Form
    {

        Custumer custumer; 

        public mainForm(Custumer cs)

        {
            custumer = cs;
            //loadGraph();
            InitializeComponent();
            //loadGraph();
        }
        public mainForm(Custumer cs,decimal a)

        {
            //mainForm.ActiveForm.Close();
            custumer = cs;
            cs.BankCard.Balance += a;
            cs.CreditCard.MaxCredit -= a;
            
            InitializeComponent();
            //loadGraph();
        }
        public mainForm(decimal b, Custumer cs)

        {
            //mainForm.ActiveForm.Close();
            custumer = cs;
            cs.BankCard.Balance -= b;
            

            InitializeComponent();
            //loadGraph();
        }
        private void hesapÖzetiÇıkartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
            if (custumer.CreditCard.CreditCardNumber != null)
            {
                takeCredit tc = new takeCredit(custumer);
                tc.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kredi Kartınız Yok Kredi Çekemezsiniz");
            }
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
            
        {
            Custumer custumerReciever = new Custumer();
            sendMoney sendMoney = new sendMoney(custumer,custumerReciever);
            sendMoney.ShowDialog();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePassword changePassword = new changePassword(custumer);
            changePassword.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ibanlbl.Text);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
            loadGraph();
            ibanlbl.Text = custumer.Iban;
            lblEmail.Text = $"E mail: {custumer.Mail}";
            lblIsimSoyisim.Text = $"İsim Soyisim: {custumer.Name} {custumer.Surname}";
        }
        private void loadGraph()
        {
            pieChartGraphic.LegendLocation = LegendLocation.Bottom;
            ArrayList bilal = new ArrayList{custumer.BankCard.Balance,custumer.CreditCard.MaxCredit,};
            Func<ChartPoint, string> func = x => string.Format("{0},{1:P}", x.Y, x.Participation);            
            ArrayList textler = new ArrayList { "Bakiye", "Çekebileceğiniz Maximum Kredi" };      
            SeriesCollection series = new SeriesCollection();
            int i = 0;
            foreach (var item in bilal)
            {
                PieSeries pie = new PieSeries();
                pie.Title = textler[i].ToString();
                i++;
                pie.Values = new ChartValues<decimal> { Convert.ToDecimal(item) };
                pie.DataLabels = true;
                pie.LabelPoint = func;
                series.Add(pie);
                pieChartGraphic.Series = series;
            }
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.ActiveForm.Close();
        }
    }
}
