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

namespace StockProgram
{
    public partial class Form1 : Form
    {
        List<List<string>> stock = new List<List<string>>(); //시가,고가,종가,저가;
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
            makePanel();
            
            string[] lines = System.IO.File.ReadAllLines(@"C:/Users/rmstj/Desktop/Stock.txt");
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
                        Console.WriteLine(str2);
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
            editPanel(0);
        }
        private void makePanel() //20개의 판넬을 생성해주는 함수
        {
            plist = new List<Panel>();
            for (int i = 0; i < 20; i++)
            {
                plist.Add(new Panel());
                plist[i].Width = 30;
                plist[i].Height = 100;
                plist[i].Location = new Point(100 + i * 40,350); //위에서 아래로 그림.
                plist[i].BackColor = Color.Red;      
                this.Controls.Add(plist[i]);
            }
        }
        private void editPanel(int index) // stock 리스트의 시작 포인트부터 20개의 값을 이용해 팬널 수정하는 함수(21개 받아오기)
        {
            
            for (int i = index; i < index + 20; i++)
            {
                float min = Math.Min(float.Parse(stock[i][0]),float.Parse(stock[i][0]));
                float max = Math.Max(float.Parse(stock[i][0]), float.Parse(stock[i][0]));
                plist[i].Top = (int)(max/10);
                plist[i].Height = (int)min/10;
            }
        }           
    }
}
