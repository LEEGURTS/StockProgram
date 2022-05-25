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
        Series SMA;
        //list값을 준다면 /20 /60 /120 선 그어주기.
        private void candleChart_Load(object sender, EventArgs e)
        {
            
            chartSeries = chart1.Series["Series1"];
            SMA = chart1.Series["SMA"];
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
                chartSeries.Points[idx].YValues[3] = int.Parse(now[3]); //종가 
                idx++;
            }
        }

        public void SetPoint(int val) //이평선 함수 구현 문제 지적 부탁.
        {
            int k = 0;
            int sum = 0;
            if(stock.Count < val) //val만큼 값은있니?
            {
                return;
            }
            while (stock.Count - val - 1 - k != -1) {
                for (int i = stock.Count - 1 - k; i > stock.Count - val - 1 - k; i--)
                {
                    sum += int.Parse(stock[i][3]);
                }
                SMA.Points[stock.Count - 1 - k].YValues[0] = sum / val;
                k++;
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
