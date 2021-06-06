using _131730026_Bilal_Alptekib_donemsonuodv.DOMAIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace _131730026_Bilal_Alptekib_donemsonuodv
{
    public partial class denemeForm : Form
    {
        Custumer custumer;
        public denemeForm(Custumer cs)
        {
            InitializeComponent();
            custumer =cs;
            
        }

        private void deneme_Load(object sender, EventArgs e)
        {
            ReportParameter[] parameters = new ReportParameter[]
            {
               new ReportParameter("PIban",custumer.Iban),
               new ReportParameter("Pad",custumer.Name),
               new ReportParameter("Psoyad",custumer.Surname),
               new ReportParameter("PbankCard",custumer.BankCard.CardNumber),
               new ReportParameter("Pemail",custumer.Mail),

               //new ReportParameter("PbankCardBalance",Convert.ToString(custumer.BankCard.Balance))

            };
            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
        }
    }
}
