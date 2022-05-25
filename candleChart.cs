using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Api_test01
{
    public partial class candleChart : Form
    {
        public candleChart()
        {
            InitializeComponent();
        }
        public List<List<string>> stock = new List<List<string>>(); // 스톡의 정보, 순서는 시가,고가,저가,종가
        Series chartSeries;
        private void candleChart_Load(object sender, EventArgs e)
        {
            
            chartSeries = chart1.Series["Series1"];
            chartSeries.CustomProperties = "PriceDownColor=Blue,PriceUpColor=Red";
            chartSeries.Palette = new ChartColorPalette();
            chart1.AxisViewChanged += ViewChanged;
            SetStockList();
        }

        public void SetStockList()
        {
            int idx = 0;
            foreach (List<string> now in stock)
            {
                this.chartSeries.Points.AddXY(int.Parse(now[4]), int.Parse(now[1]));
                chartSeries.Points[idx].YValues[1] = int.Parse(now[2]);
                chartSeries.Points[idx].YValues[2] = int.Parse(now[0]);
                chartSeries.Points[idx].YValues[3] = int.Parse(now[3]);
                idx++;
            }
        }
        private void ViewChanged(object sender, ViewEventArgs e)
        {
            if (sender.Equals(chart1))
            {
                int startPos = (int)e.Axis.ScaleView.ViewMinimum;
                int endPos = (int)e.Axis.ScaleView.ViewMaximum;
                int max = 0;
                int min = 420000000;
                for (int i = startPos - 1; i < endPos; i++)
                {
                    if (i >= stock.Count)
                        break;
                    if (i < 0)
                        i = 0;
                    if (int.Parse(stock[i][1]) > max)
                        max = int.Parse(stock[i][1]);
                    if (int.Parse(stock[i][3]) < min)
                        min = int.Parse(stock[i][1]);

                }
                this.chart1.ChartAreas[0].AxisY.Maximum = (max * 11) / 10;
                this.chart1.ChartAreas[0].AxisY.Minimum = (min * 9) / 10;
            }
        }
    }
}
