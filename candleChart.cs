using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.InteropServices;
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
            
            chartSeries = chart1.Series["주가"];
            SMA = chart1.Series["SMA"];
            chartSeries.CustomProperties = "PriceDownColor=Blue,PriceUpColor=Red";
            chartSeries.Palette = new ChartColorPalette();
            chart1.MouseWheel += new MouseEventHandler(ChangeWidth);
            SetStockList();
        }   
        private int findMax(List<string> data)
        {
            int max = 0;
            for(int i = 0; i < 4; i++)
            {
                max = Math.Max(int.Parse(data[i]), max);
            }
            return max;
        }
        private int findMin(List<string> data)
        {
            int min = int.MaxValue;
            for (int i = 0; i < 4; i++)
            {
                min = Math.Min(int.Parse(data[i]), min);
            }
            return min;
        }
        private void ChangeWidth(object sender, MouseEventArgs e) //마우스 스크롤에 대한 동작
        {
            if(chart1 == null)
            {
                return;
            }
            double min = chart1.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
            double max = chart1.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
            int start=0, fin=0;
            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            if (e.Delta > 0)
            {
                start = (int)(chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (max - min) / 3);
                fin = (int)(chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (max - min) / 3);
            }
            else if(e.Delta < 0){
               
                start = (int)(min - (max - min) / 3);
                fin = (int)(max + (max - min) / 3);
            }
            if (start < 0) start = 0;
            if (fin > chart1.ChartAreas[0].AxisX.Maximum) fin = (int)chart1.ChartAreas[0].AxisX.Maximum;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(start, fin);
            double ymin = int.MaxValue;
            double ymax = 0;
            for(int i = start; i < fin-1; i++)
            {
                ymin = Math.Min(ymin,findMin(stock[i]));
                ymax = Math.Max(ymax,findMax(stock[i]));
            }
            chart1.ChartAreas[0].AxisY.Maximum = ymax * 1.1;
            chart1.ChartAreas[0].AxisY.Minimum = ymin * 0.9;
        }

        public void SetStockList() //폼 초기설정
        {
            stock.Reverse();
            int max = 0;
            int min = int.MaxValue;
            int idx = 0;
            foreach (List<string> now in stock)
            {
                this.chartSeries.Points.AddXY(now[4], int.Parse(now[1]));
                chartSeries.Points[idx].YValues[1] = int.Parse(now[2]);
                chartSeries.Points[idx].YValues[2] = int.Parse(now[0]);
                chartSeries.Points[idx].YValues[3] = int.Parse(now[3]); //종가 
                idx++;
                max = Math.Max(findMax(now),max);
                min = Math.Min(findMin(now),min);
            }
            chart1.ChartAreas[0].AxisY.Minimum = min * 0.9;
            chart1.ChartAreas[0].AxisY.Maximum = max * 1.1;
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

        StockInfoShow child;
        private void chart1_MouseClick(object sender, MouseEventArgs e) //정보 출력
        {
            int idx = (int)(chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X));
            HitTestResult result = chart1.HitTest(e.Location.X, e.Location.Y);
            if (result.ChartElementType == ChartElementType.DataPoint && result.PointIndex != -1)
            {
                if(child != null)
                {
                    child.Close();
                }
                child = new StockInfoShow(stock[idx]);
                child.Show();
            }
        }
    }
}
