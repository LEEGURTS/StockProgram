using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockProgram
{
    public partial class Form1 : Form
    {
        List<List<string>> stock = new List<List<string>>(); //시가,고가,저가,종가;
        List<Panel> plist; 
        public Form1()
        {
            InitializeComponent();
        }
        private double getCompare(double before, double after)
        {
            return before / after;
        }

        
        private bool compareUpDowm(double stock1, double stock2) //어제와 오늘의 종가를 비교.
        {
            if (stock1 > stock2)
                return false; //떨어지면 false blue
            else
                return true; //올라가면 true red
        }



        private void Form1_Load(object sender, EventArgs e)
        {         
            string[] lines = System.IO.File.ReadAllLines(@"C:/Users/rmstj/Desktop/Stock.txt"); //임시 데이터 생성부
            int k = 0;
            foreach (string str in lines)
            {
                List<string> data = new List<string>();
                string[] temp = str.Split(',');
                foreach (string str2 in temp)
                {
                    if(str2.IndexOf('\"') == -1 && str2.IndexOf("]") == -1 && str2.IndexOf("\r") == -1 && str2.IndexOf("\t") == -1)
                    {
                        data.Add(str2.Trim());
                    }
                    else
                    {
                        continue;
                    }
                } 
                if(data.Count < 4)
                {
                    continue;
                }
                stock.Add(data);               
            }
            Series chartSeries;
            chartSeries = chart1.Series["Series1"];
            int idx = 0;
            foreach(List<string> now in stock)
            {
                chartSeries.Points.AddXY(idx, int.Parse(now[1]));
                chartSeries.Points[idx].YValues[1] = int.Parse(now[2]);
                chartSeries.Points[idx].YValues[2] = int.Parse(now[0]);
                chartSeries.Points[idx].YValues[3] = int.Parse(now[3]);
                idx++;
            }
            chartSeries.CustomProperties = "PriceDownColor=Blue,PriceUpColor=Red";
            chartSeries.Palette = new ChartColorPalette();
            chart1.AxisViewChanged += ViewChanged;
        }  
        private void ViewChanged(object sender,ViewEventArgs e)
        {
            if (sender.Equals(chart1))
            {
                int startPos = (int)e.Axis.ScaleView.ViewMinimum;
                int endPos = (int)e.Axis.ScaleView.ViewMaximum;
                int max = 0;
                int min = 420000000;
                for (int i = startPos-1; i < endPos; i++)
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
                this.chart1.ChartAreas[0].AxisY.Maximum = (max*11)/10;
                this.chart1.ChartAreas[0].AxisY.Minimum = (min*9)/10;
            }
        }
    }
}
