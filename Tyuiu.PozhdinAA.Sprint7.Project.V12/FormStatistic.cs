using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PozhdinAA.Sprint7.Project.V12.Lib;

namespace Tyuiu.PozhdinAA.Sprint7.Project.V12
{
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
            var ds = new DataService();
            var priceColumnIndex = 7;
            var pathPC = @"..\Back-end\personal_computer.csv";
            var data = ds.GetData(pathPC);
            var prices = new double[data.GetLength(0)];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                var priceString = data[i, priceColumnIndex].Replace('.', ',');
                var parseSuccess = double.TryParse(priceString, out double price);
                if (!parseSuccess)
                {
                    MessageBox.Show("Цена имеет неверный формат");
                    return;
                }

                prices[i] = price;
            }

            this.textBoxMinPrice_PAA.Text = prices.Min().ToString();
            this.textBoxMaxPrice_PAA.Text = prices.Max().ToString();
            this.textBoxAvgPrice_PAA.Text = prices.Average().ToString();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                this.chart1.Series[0].Points.AddXY(data[i, 0], data[i, 7]);
                this.chart2.Series[0].Points.AddXY(data[i, 0], data[i, 7]);
            }
        }
    }
}
