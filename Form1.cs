using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Api_test01
{
    public partial class Parent : Form
    {
        public string[] all_Code; // 모든 주식코드
        public string[] all_Name; // 모든 주식명
        string target_code, target_name;// 주문에 사용
        int grid_count = 0;
        public List<List<string>> stock = new List<List<string>>();
        //List<unbuy> unbuyList;
        //List<balance> balanceList; 형석님 코드에 있음 
        Form children;

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
            axKHOpenAPI1.OnReceiveRealData += onReceiveRealData;
            관심주식_datagridview.SelectionChanged += SendInfo;

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
            로그인_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 로그인_btn.Width, 로그인_btn.Height, 10, 10));
            계좌정보조회_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 계좌정보조회_btn.Width, 계좌정보조회_btn.Height, 10, 10));
            추가01_btn.Enabled = false;
            추가01_btn.Visible = false;

            /*
            pictureBox3.Visible = false;
            PrivateFontCollection customFont = new PrivateFontCollection();
            customFont.AddFontFile("KoPub Dotum Bold.ttf");
            customFont.AddFontFile("KoPub Dotum Light.ttf");
            customFont.AddFontFile("KoPub Dotum Medium.ttf");
            this.Font = new Font(customFont.Families[2], 9);
            MultiPanel.Font = new Font(customFont.Families[2], 9);
            label7.Font = new Font(customFont.Families[2], 14);
            계좌_label.Font = new Font(customFont.Families[2], 9);
            사용자이름_label.Font = new Font(customFont.Families[2], 9);
            */
            axKHOpenAPI1.Visible = false;
        }
        
        private Point MouseDownLocation;

        ///////////////////////////////////////////
        //////////////API기능/////////////////////
        /////////////////////////////////////////
        public void SendInfo(object sender, EventArgs e)
        {
            if (sender.Equals(관심주식_datagridview))
            {
                try
                {
                    if (관심주식_datagridview.SelectedCells.Count > 0)
                    {
                        int selectRowindex = 관심주식_datagridview.SelectedCells[0].RowIndex;
                        if (selectRowindex == 0 && 관심주식_datagridview.Rows.Count == 1 && 관심주식_datagridview["관심주식_이름", selectRowindex].Value == null)
                        {   // 처음에 빈 셀이 선택되서 오류나는 것을 방지함
                            관심주식_datagridview.ClearSelection();
                            return;
                        }
                        target_name = 관심주식_datagridview["관심주식_이름", selectRowindex].Value.ToString();
                        target_code = 관심주식_datagridview["관심주식_코드", selectRowindex].Value.ToString();

                        axKHOpenAPI1.SetInputValue("종목코드", target_code); // 종목코드 보냄
                        axKHOpenAPI1.CommRqData("종목정보요청", "opt10001", 0, "5000"); // 정보 주세요!
                        // onReceive어쩌구 시작
                        axKHOpenAPI1.SetInputValue("종목코드", target_code);
                        axKHOpenAPI1.CommRqData("시고종저", "opt10005", 0, "5000");
                    }

                }
                catch (Exception ex)
                {
                    // 오류나도 속행한다.
                }
            }
        }

        public void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            int count = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);

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

            else if (e.sRQName == "종목정보요청")
            {
                long price = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Trim().Substring(1));
                long dif = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "전일대비").Trim());

                종목이름01_label.Text = target_name;
                전일대비_label.Text = String.Format("{0:#,###}", dif);
                현재가01_label.Text = String.Format("{0:#,###}", price);
                // 보유수량은 계좌잔고 평가 내역에서 code == 서버에서주는 code[i]이면
                // 보유수량[i]를 반환, 같은게 없으면 0 반환
            }

            else if (e.sRQName == "시고종저")
            {
                //MessageBox.Show(e.sRQName);
                stock.Clear();
                int Count = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                //MessageBox.Show(Count.ToString());
                string YMD, price_si, price_go, price_jong, price_jer;
                for (int i = 0; i < Count; i++)
                {
                    YMD = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "날짜").Trim();
                    price_si = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "시가").Trim();
                    price_go = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "고가").Trim();
                    price_jong = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종가").Trim();
                    price_jong = price_jong.Replace("+", "");
                    price_jong = price_jong.Replace("-", "");

                    price_jer = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "저가").Trim();
                    stock.Add(new List<string>());
                    stock[i].Add(price_si);
                    stock[i].Add(price_go);
                    stock[i].Add(price_jer);
                    stock[i].Add(price_jong);
                    stock[i].Add(YMD);

                    // 보유수량은 계좌잔고 평가 내역에서 code == 서버에서주는 code[i]이면
                    // 보유수량[i]를 반환, 같은게 없으면 0 반환
                }
            }
        }

        public void onReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {

        }

        public void add_grid(string name, string code)
        {
            if (관심주식_datagridview.RowCount > 0)
            {
                for (int i = 0; i < 관심주식_datagridview.RowCount; i++)
                {
                    if (관심주식_datagridview["관심주식_이름", i].Value.ToString() == name)
                    {
                        return;
                    }
                }
            }
            관심주식_datagridview.Rows.Add(); // datagrid 행 추가
            관심주식_datagridview["관심주식_이름", grid_count].Value = name;
            관심주식_datagridview["관심주식_코드", grid_count].Value = code;
            grid_count++;
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
                pictureBox3.Visible = true;
                계좌정보조회_btn.Visible = true;
                string code_list = axKHOpenAPI1.GetCodeListByMarket("0");
                all_Code = code_list.Split(';');
                all_Name = new string[all_Code.Length];
                int i = 0;
                foreach (string code in all_Code)
                {
                    all_Name[i] = axKHOpenAPI1.GetMasterCodeName(code);
                    i++;
                }
            }
        }

        ///////////////////////////////////////////
        //////////////Form관련////////////////////
        /////////////////////////////////////////
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

        private void childToMulti(Form newChild)
        {

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


        ///////////////////////////////////////////
        //////////////기타함수들//////////////////
        /////////////////////////////////////////
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
            Child child = new Child(this);
            child.Owner = this;
            child.BackColor = this.BackColor;
            childToMulti(child);
        }

        private void 로그인_btn_Click(object sender, EventArgs e)
        {
            axKHOpenAPI1.CommConnect();
            axKHOpenAPI1.OnEventConnect += OnEventConnect;
        }

        private void 삭제_btn_Click(object sender, EventArgs e)
        {
            if (관심주식_datagridview.SelectedCells.Count > 0)
            {
                int selectRowindex = 관심주식_datagridview.SelectedCells[0].RowIndex;
                관심주식_datagridview.Rows.Remove(관심주식_datagridview.Rows[selectRowindex]);
                grid_count--;
            }
        }

        private void 매수_btn_Click(object sender, EventArgs e)
        { /*
            if (가격_numeric.Value > 0 && 수량_numeric.Value > 0 && 계좌_label.Text.Length > 0)
            {
                int result = axKHOpenAPI1.SendOrder("현금매수주문", "5001", 계좌_label.Text, 1, target_code, int.Parse(수량_numeric.Value.ToString()), int.Parse(가격_numeric.Value.ToString()), "지정가", "");
                if (result == 0)
                    MessageBox.Show("주문성공");
            }
            */
        }

        private void 매도_btn_Click(object sender, EventArgs e)
        {/*
            if (가격_numeric.Value > 0 && 수량_numeric.Value > 0 && 계좌_label.Text.Length > 0)
            {
                int result = axKHOpenAPI1.SendOrder("현금매도주문", "5001", 계좌_label.Text, 2, target_code, int.Parse(수량_numeric.Value.ToString()), int.Parse(가격_numeric.Value.ToString()), "지정가", "");
                if (result == 0)
                    MessageBox.Show("주문성공");
            }
            */
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnChart_Click(object sender, EventArgs e)
        {
            candleChart newChild = new candleChart();
            newChild.stock.Clear();
            newChild.stock = this.stock;
            children = newChild;
            //newChild.SetStockList();
            childToMulti(newChild);
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
            관심주식_datagridview.Width = Convert.ToInt32(panel1.Width / 1.25);
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

        private void btnChart_Leave(object sender, EventArgs e)
        {
            MultiPanel.Controls.Remove(children);
        }

        

    }
}
