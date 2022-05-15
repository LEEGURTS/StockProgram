using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Api_test01
{
    public partial class Parent : Form
    {
        string 종목코드리스트;
        public string[] 종목코드;
        public string[] 종목이름;
        int grid_count = 0;
        public Parent()
        {
            InitializeComponent();
            // 계좌 조회 클릭 -> 계좌 잔고를 table의 label에 Load함
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData;

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
                삭제_btn.Enabled = true;
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
            child.Show();
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
    }
}
