using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Api_test01
{
    public partial class Parent : Form
    {
        string 종목코드리스트;
        public string[] 종목코드;
        public string[] 종목이름;
        int grid_count = 0;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse);
        public Parent()
        {
            InitializeComponent();
            // 계좌 조회 클릭 -> 계좌 잔고를 table의 label에 Load함
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData;

        }
        private void Parent_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            btnChart.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnChart.Width, btnChart.Height, 30, 30));
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            btnIESearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnIESearch.Width, btnIESearch.Height, 30, 30));
            추가01_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 추가01_btn.Width, 추가01_btn.Height, 30, 30));
            btnMakeBig.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnMakeBig.Width, btnMakeBig.Height, 30, 30));
            btnMakeSmall.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnMakeSmall.Width, btnMakeSmall.Height, 30, 30));
            삭제_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 삭제_btn.Width, 삭제_btn.Height, 30, 30));
            추가01_btn.Enabled = false;
            추가01_btn.Visible = false;

            

            axKHOpenAPI1.Visible = false;
        }
        private Point MouseDownLocation;
        private void Panel_Drag_MouseDown(object sender, MouseEventArgs e) //마우스 위치 전달
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
        private void Panel_Drag_MouseMove(object sender, MouseEventArgs e) //드래그로 폼을 이동시키는 함수
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Left = e.X + Left - MouseDownLocation.X;
                Top = e.Y + Top - MouseDownLocation.Y;
            }
        }
        public void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if (e.sRQName == "계좌잔고평가내역")
            {
                int buy = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총매입금액"));
                int deposit = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "추정예탁자산"));
                int val = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총평가금액"));
                int profit = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총평가손익금액"));

                자본_label.Text = String.Format("{0:#,###}", deposit);
                총매입_label.Text = buy.ToString();
                총평가_label.Text = val.ToString();
                전체손익_label.Text = profit.ToString();
            }


        }

            private void 로그인_btn_Click(object sender, EventArgs e) 
        {
            axKHOpenAPI1.CommConnect();
            axKHOpenAPI1.OnEventConnect += OnEventConnect;
        }

        public void OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0)
            {
                // 사용자 이름
                string UserName = axKHOpenAPI1.GetLoginInfo("USER_NAME");
                사용자이름_label.Text = UserName;

                // 계좌 정보
                string accList = axKHOpenAPI1.GetLoginInfo("ACCLIST").Trim();
                string[] userAccount = accList.Split(';');
                계좌_label.Text = userAccount[0];

                계좌정보조회_btn.Enabled = true;
                추가01_btn.Enabled = true;
                추가01_btn.Visible = true;
                삭제_btn.Enabled = true;
                삭제_btn.Visible = true;
                매수_btn.Enabled = true;
                매도_btn.Enabled = true;

                종목코드리스트 = axKHOpenAPI1.GetCodeListByMarket("0");
                종목코드 = 종목코드리스트.Split(';');
                종목이름 = new string[종목코드.Length];
                int i = 0;
                foreach (string code in 종목코드)
                {
                    종목이름[i] = axKHOpenAPI1.GetMasterCodeName(code);
                    i++;
                }
            }
        }

        private void 계좌정보조회_btn_Click(object sender, EventArgs e)
        {
            string account = 계좌_label.Text;
            axKHOpenAPI1.SetInputValue("계좌번호", account);
            axKHOpenAPI1.SetInputValue("비밀번호", "0000");
            axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI1.SetInputValue("조회구분", "2");
            axKHOpenAPI1.CommRqData("계좌잔고평가내역", "opw00018", 0, "5000");
        }

        private void 추가_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(종목코드.Length.ToString()+"개 업뎃함!");
            Child child = new Child(this);
            child.Owner = this;
            childToMulti(child);
        }

        public void add_grid(string name, string code)
        {
            if (관심주식_datagridview.RowCount > 0)
            {
                for (int i = 0; i < 관심주식_datagridview.RowCount; i++)
                {
                    if (관심주식_datagridview["관심종목_이름", i].Value.ToString() == name)
                    {
                        return;
                    }
                }
            }
            관심주식_datagridview.Rows.Add(); // datagrid 행 추가
            관심주식_datagridview["관심종목_이름", grid_count].Value = name;
            관심주식_datagridview["관심종목_코드", grid_count].Value = code;
            grid_count++;
        }

        private void 삭제_btn_Click(object sender, EventArgs e)
        {
            if (관심주식_datagridview.SelectedCells.Count > 0)
            {
                int selectRowindex = 관심주식_datagridview.SelectedCells[0].RowIndex;
                관심주식_datagridview.Rows.Remove(관심주식_datagridview.Rows[selectRowindex]);
            }
        }

        private void 매수_btn_Click(object sender, EventArgs e)
        {

        }

        private void 매도_btn_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void childToMulti(Form newChild) {
            
            newChild.TopLevel = false;
            newChild.Location = MultiPanel.Location;
            newChild.Dock = DockStyle.Fill;
            MultiPanel.Controls.Add(newChild);
            MultiPanel.Tag = newChild;
            newChild.Size = MultiPanel.Size;
            newChild.Font = MultiPanel.Font;
            newChild.BringToFront();
            newChild.Show();
        }
        private void btnChart_Click(object sender, EventArgs e)
        {
            candleChart newChild = new candleChart();
            newChild.stock = new List<List<string>>(); //이곳에 생성된 stock값을 전달
            newChild.SetStockList();
            childToMulti(newChild);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {           
            //Form newForm = new Form();
            //새로운 폼에 대한 설정
            //childToMulti(newForm);
            
            //이와 같이 설정하면 됨
        }

        private void btnIESearch_Click(object sender, EventArgs e)
        {
            if(this.관심주식_datagridview.RowCount == 0)
            {
                return;
            }
            DataGridViewRow row = 관심주식_datagridview.SelectedRows[0];
            string data = row.Cells[1].Value.ToString();
            System.Diagnostics.Process.Start("https://finance.daum.net/news?keyword=" + data);      
        }

        private void btnChart_MouseEnter(object sender, EventArgs e)
        {
            btnChart.BackColor = Color.FromArgb(118, 106, 206);
        }

        private void btnChart_MouseLeave(object sender, EventArgs e)
        {
            btnChart.BackColor = Color.FromArgb(83, 66, 194);
        }

        private void btnIESearch_MouseEnter(object sender, EventArgs e)
        {
            btnIESearch.BackColor = Color.FromArgb(118, 106, 206);
        }

        private void btnIESearch_MouseLeave(object sender, EventArgs e)
        {
            btnIESearch.BackColor = Color.FromArgb(83, 66, 194);
        }

        private void 추가01_btn_MouseEnter(object sender, EventArgs e)
        {
            추가01_btn.BackColor = Color.FromArgb(118, 106, 206);
        }

        private void 추가01_btn_MouseLeave(object sender, EventArgs e)
        {
            추가01_btn.BackColor = Color.FromArgb(83, 66, 194);
        }

        private void btnMakeSmall_Click(object sender, EventArgs e)
        {
            this.Controls.Add(관심주식_datagridview);
            Point p = new Point(29, 406);
            관심주식_datagridview.Dock = DockStyle.None;
            관심주식_datagridview.Height = 193;
            관심주식_datagridview.Width = 222;
            관심주식_datagridview.Location = p;
            관심주식_datagridview.BringToFront();
            관심주식_datagridview.Show();
        }

        private void btnMakeBig_Click(object sender, EventArgs e)
        {
            관심주식_datagridview.Location = MultiPanel.Location;
            관심주식_datagridview.Dock = DockStyle.Fill;
            MultiPanel.Controls.Add(관심주식_datagridview);
            MultiPanel.Tag = 관심주식_datagridview;
            관심주식_datagridview.Size = MultiPanel.Size;
            관심주식_datagridview.Font = MultiPanel.Font;
        }
    }
}
