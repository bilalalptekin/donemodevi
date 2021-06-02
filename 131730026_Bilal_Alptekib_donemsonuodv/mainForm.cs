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
        public mainForm()
        {
            InitializeComponent();
        }
        //public mainForm()
        //{

        //}
        private void hesapÖzetiÇıkartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            sendMoney sendMoney = new sendMoney();
            sendMoney.ShowDialog();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePassword changePassword = new changePassword();
            changePassword.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ibanlbl.Text);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            pieChartGraphic.LegendLocation = LiveCharts.LegendLocation.Bottom;
            loadGraph();

        }
        private void loadGraph()
        {
            ArrayList bilal = new ArrayList{500,100,250};
            Func<ChartPoint, string> func = x => string.Format("{0},{1:P}", x.Y, x.Participation);
            SeriesCollection series = new SeriesCollection();
            foreach (var item in bilal)
            {
                PieSeries pie = new PieSeries();
                pie.Title = "bilal";
                pie.Values = new ChartValues<int> { Convert.ToInt32(item) };
                pie.DataLabels = true;
                pie.LabelPoint = func;
                series.Add(pie);
                pieChartGraphic.Series = series;
            }
        }
    }
}
