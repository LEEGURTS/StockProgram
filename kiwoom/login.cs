using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiwoom
{
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData; // 계좌 잔고 불러오는 함수
        }
        //로그인 버튼
        public void btnLogin_Click(object sender, EventArgs e)
        {
            axKHOpenAPI1.CommConnect(); // 로그인 서버 연결
            axKHOpenAPI1.OnEventConnect += OnEventConnect; // 로그인 후 사용자의 접속 정보 가져오기
        }
        public void OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            
            if (e.nErrCode ==0) // 값이 0이면 정상적으로 로그인됨
            {
        
                string AccList = axKHOpenAPI1.GetLoginInfo("ACCLIST").Trim();
                string[] userAccount = AccList.Split(';');

                for(int i = 0; i < userAccount.Length; i++)
                {
                    // 계좌번호 comboBox에 계좌 목록 추가
                    cmbAccount.Items.Add(userAccount[i]);
                    
                }
                // 사용자 이름 표시
                string userName = axKHOpenAPI1.GetLoginInfo("USER_NAME");
                usrName.Text = userName;

                // 사용자 아이디 표시
                string userId = axKHOpenAPI1.GetLoginInfo("USER_ID");
                usrID.Text = userId;

                // 접속 서버 표시 (모의투자서버 or 실거래서버)
                string serv = axKHOpenAPI1.GetLoginInfo("GetServerGubun");
                getServer.Text = serv;

                // 종목 조회
                string codeList = axKHOpenAPI1.GetCodeListByMarket("0"); // 전체 시장 조회 가능
                string[] codes = codeList.Split(';');
                
                for(int i = 0; i < codes.Length; i++)
                {
                    dgvItem.Rows.Add();
                    dgvItem["종목조회_종목코드", i].Value = codes[i];
                    dgvItem["종목조회_종목명", i].Value = axKHOpenAPI1.GetMasterCodeName(codes[i]);
                }




            }

        }
        // 계좌정보조회 버튼
        public void btnAccCheck_Click(object sender, EventArgs e)
        {
            // 계좌 정보 조회
            string account = cmbAccount.Text;
            axKHOpenAPI1.SetInputValue("계좌번호", account);
            axKHOpenAPI1.SetInputValue("비밀번호", "0000");
            axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI1.SetInputValue("조회구분", "2");

            axKHOpenAPI1.CommRqData("계좌잔고평가내역", "opw00018", 0, "5000");
        }
        public void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            // 계좌 잔고 불러오기
            if (e.sRQName == "계좌잔고평가내역")
            {
                int buy = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총매입금액"));
                int deposit = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "추정예탁자산"));
                int val = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총평가금액"));
                int profit = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총평가손익금액"));

                labDeposit.Text = deposit.ToString();
                labBuy.Text = buy.ToString();
                labValuation.Text = val.ToString();
                labProfit.Text = profit.ToString();

            }
            else if (e.sRQName == "종목정보요청")
            {
                string name = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Trim();
                long price= long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Trim().Substring(1));
                long dif= long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "전일대비").Trim());
                long vol = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량").Trim());
                string percentage = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율").Trim();

                //MessageBox.Show(dif.ToString());
                txtItemName.Text = name;
                txtcurPrice.Text = String.Format("{0:#,###}",price);
                txtdiff.Text= String.Format("{0:#,###}", dif);
                txtvolume.Text = String.Format("{0:#,###}", vol);
                txtpercent.Text = percentage;
            }
        }
        // 종목조회 버튼
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string code = txtSearch.Text;
            if (txtSearch.Text.Length > 0)
            {
                axKHOpenAPI1.SetInputValue("종목코드", code);
                axKHOpenAPI1.CommRqData("종목정보요청", "opt10001", 0, "5000");
            }
        }
    }
}
