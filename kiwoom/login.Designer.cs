
namespace kiwoom
{
    partial class login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usrName = new System.Windows.Forms.Label();
            this.usrID = new System.Windows.Forms.Label();
            this.getServer = new System.Windows.Forms.Label();
            this.btnAccCheck = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labProfit = new System.Windows.Forms.Label();
            this.labValuation = new System.Windows.Forms.Label();
            this.labBuy = new System.Windows.Forms.Label();
            this.labDeposit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.종목조회_종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.종목조회_종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtpercent = new System.Windows.Forms.Label();
            this.txtvolume = new System.Windows.Forms.Label();
            this.txtdiff = new System.Windows.Forms.Label();
            this.txtcurPrice = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.Label();
            this.curPrice = new System.Windows.Forms.Label();
            this.diff = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(688, 10);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(529, 20);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cmbAccount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.usrName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.usrID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.getServer, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cmbAccount
            // 
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(103, 4);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(93, 20);
            this.cmbAccount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "사용자이름";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "계좌번호";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "접속서버";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usrName
            // 
            this.usrName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usrName.AutoSize = true;
            this.usrName.Location = new System.Drawing.Point(103, 25);
            this.usrName.Name = "usrName";
            this.usrName.Size = new System.Drawing.Size(93, 23);
            this.usrName.TabIndex = 5;
            this.usrName.Text = "label5";
            // 
            // usrID
            // 
            this.usrID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usrID.AutoSize = true;
            this.usrID.Location = new System.Drawing.Point(103, 49);
            this.usrID.Name = "usrID";
            this.usrID.Size = new System.Drawing.Size(93, 23);
            this.usrID.TabIndex = 6;
            this.usrID.Text = "label6";
            // 
            // getServer
            // 
            this.getServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getServer.AutoSize = true;
            this.getServer.Location = new System.Drawing.Point(103, 73);
            this.getServer.Name = "getServer";
            this.getServer.Size = new System.Drawing.Size(93, 26);
            this.getServer.TabIndex = 7;
            this.getServer.Text = "label7";
            // 
            // btnAccCheck
            // 
            this.btnAccCheck.Location = new System.Drawing.Point(529, 49);
            this.btnAccCheck.Name = "btnAccCheck";
            this.btnAccCheck.Size = new System.Drawing.Size(97, 23);
            this.btnAccCheck.TabIndex = 4;
            this.btnAccCheck.Text = "계좌정보조회";
            this.btnAccCheck.UseVisualStyleBackColor = true;
            this.btnAccCheck.Click += new System.EventHandler(this.btnAccCheck_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labProfit, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labValuation, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labBuy, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labDeposit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(218, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 124);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // labProfit
            // 
            this.labProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labProfit.AutoSize = true;
            this.labProfit.BackColor = System.Drawing.Color.White;
            this.labProfit.Location = new System.Drawing.Point(145, 91);
            this.labProfit.Name = "labProfit";
            this.labProfit.Size = new System.Drawing.Size(135, 32);
            this.labProfit.TabIndex = 9;
            this.labProfit.Text = "0";
            this.labProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labValuation
            // 
            this.labValuation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labValuation.AutoSize = true;
            this.labValuation.BackColor = System.Drawing.Color.White;
            this.labValuation.Location = new System.Drawing.Point(145, 61);
            this.labValuation.Name = "labValuation";
            this.labValuation.Size = new System.Drawing.Size(135, 29);
            this.labValuation.TabIndex = 8;
            this.labValuation.Text = "0";
            this.labValuation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labBuy
            // 
            this.labBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labBuy.AutoSize = true;
            this.labBuy.BackColor = System.Drawing.Color.White;
            this.labBuy.Location = new System.Drawing.Point(145, 31);
            this.labBuy.Name = "labBuy";
            this.labBuy.Size = new System.Drawing.Size(135, 29);
            this.labBuy.TabIndex = 7;
            this.labBuy.Text = "0";
            this.labBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labDeposit
            // 
            this.labDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labDeposit.AutoSize = true;
            this.labDeposit.BackColor = System.Drawing.Color.White;
            this.labDeposit.Location = new System.Drawing.Point(145, 1);
            this.labDeposit.Name = "labDeposit";
            this.labDeposit.Size = new System.Drawing.Size(135, 29);
            this.labDeposit.TabIndex = 6;
            this.labDeposit.Text = "0";
            this.labDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "예수금";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "총매입금액";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "전체손익금액";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "총평가금액";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSearch, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 153);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 27);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(94, 21);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(103, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 21);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "종목조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.종목조회_종목코드,
            this.종목조회_종목명});
            this.dgvItem.Location = new System.Drawing.Point(18, 186);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.RowTemplate.Height = 23;
            this.dgvItem.Size = new System.Drawing.Size(206, 150);
            this.dgvItem.TabIndex = 7;
            // 
            // 종목조회_종목코드
            // 
            this.종목조회_종목코드.HeaderText = "종목코드";
            this.종목조회_종목코드.Name = "종목조회_종목코드";
            this.종목조회_종목코드.ReadOnly = true;
            // 
            // 종목조회_종목명
            // 
            this.종목조회_종목명.HeaderText = "종목명";
            this.종목조회_종목명.Name = "종목조회_종목명";
            this.종목조회_종목명.ReadOnly = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.txtpercent, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtvolume, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtdiff, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtcurPrice, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtItemName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.itemName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.curPrice, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.diff, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.volume, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.percent, 0, 4);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(457, 167);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // txtpercent
            // 
            this.txtpercent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpercent.AutoSize = true;
            this.txtpercent.Location = new System.Drawing.Point(103, 77);
            this.txtpercent.Name = "txtpercent";
            this.txtpercent.Size = new System.Drawing.Size(93, 22);
            this.txtpercent.TabIndex = 9;
            this.txtpercent.Text = "label";
            this.txtpercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtvolume
            // 
            this.txtvolume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtvolume.AutoSize = true;
            this.txtvolume.Location = new System.Drawing.Point(103, 58);
            this.txtvolume.Name = "txtvolume";
            this.txtvolume.Size = new System.Drawing.Size(93, 18);
            this.txtvolume.TabIndex = 8;
            this.txtvolume.Text = "label";
            this.txtvolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdiff
            // 
            this.txtdiff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdiff.AutoSize = true;
            this.txtdiff.Location = new System.Drawing.Point(103, 39);
            this.txtdiff.Name = "txtdiff";
            this.txtdiff.Size = new System.Drawing.Size(93, 18);
            this.txtdiff.TabIndex = 7;
            this.txtdiff.Text = "label";
            this.txtdiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcurPrice
            // 
            this.txtcurPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcurPrice.AutoSize = true;
            this.txtcurPrice.Location = new System.Drawing.Point(103, 20);
            this.txtcurPrice.Name = "txtcurPrice";
            this.txtcurPrice.Size = new System.Drawing.Size(93, 18);
            this.txtcurPrice.TabIndex = 6;
            this.txtcurPrice.Text = "label";
            this.txtcurPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.AutoSize = true;
            this.txtItemName.Location = new System.Drawing.Point(103, 1);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(93, 18);
            this.txtItemName.TabIndex = 5;
            this.txtItemName.Text = "label";
            this.txtItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemName
            // 
            this.itemName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemName.AutoSize = true;
            this.itemName.Location = new System.Drawing.Point(4, 1);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(92, 18);
            this.itemName.TabIndex = 0;
            this.itemName.Text = "종목이름";
            this.itemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curPrice
            // 
            this.curPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curPrice.AutoSize = true;
            this.curPrice.Location = new System.Drawing.Point(4, 20);
            this.curPrice.Name = "curPrice";
            this.curPrice.Size = new System.Drawing.Size(92, 18);
            this.curPrice.TabIndex = 1;
            this.curPrice.Text = "현재가";
            this.curPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diff
            // 
            this.diff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diff.AutoSize = true;
            this.diff.Location = new System.Drawing.Point(4, 39);
            this.diff.Name = "diff";
            this.diff.Size = new System.Drawing.Size(92, 18);
            this.diff.TabIndex = 2;
            this.diff.Text = "전일대비";
            this.diff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volume
            // 
            this.volume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volume.AutoSize = true;
            this.volume.Location = new System.Drawing.Point(4, 58);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(92, 18);
            this.volume.TabIndex = 3;
            this.volume.Text = "거래량";
            this.volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // percent
            // 
            this.percent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(4, 77);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(92, 22);
            this.percent.TabIndex = 4;
            this.percent.Text = "등락율";
            this.percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnAccCheck);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Name = "login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label usrName;
        private System.Windows.Forms.Label usrID;
        private System.Windows.Forms.Label getServer;
        private System.Windows.Forms.Button btnAccCheck;
        protected System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labProfit;
        private System.Windows.Forms.Label labValuation;
        private System.Windows.Forms.Label labBuy;
        private System.Windows.Forms.Label labDeposit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목조회_종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목조회_종목명;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label txtpercent;
        private System.Windows.Forms.Label txtvolume;
        private System.Windows.Forms.Label txtdiff;
        private System.Windows.Forms.Label txtcurPrice;
        private System.Windows.Forms.Label txtItemName;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label curPrice;
        private System.Windows.Forms.Label diff;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Label percent;
    }
}

