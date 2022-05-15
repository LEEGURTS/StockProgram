
namespace Api_test01
{
    partial class Parent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent));
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.User정보_table = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.사용자이름_label = new System.Windows.Forms.Label();
            this.계좌_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.계좌정보_table = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.자본_label = new System.Windows.Forms.Label();
            this.총매입_label = new System.Windows.Forms.Label();
            this.총평가_label = new System.Windows.Forms.Label();
            this.전체손익_label = new System.Windows.Forms.Label();
            this.로그인_btn = new System.Windows.Forms.Button();
            this.계좌정보조회_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.삭제_btn = new System.Windows.Forms.Button();
            this.추가01_btn = new System.Windows.Forms.Button();
            this.관심주식_datagridview = new System.Windows.Forms.DataGridView();
            this.관심종목_코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.관심종목_이름 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.매수매도_table = new System.Windows.Forms.TableLayoutPanel();
            this.매수_btn = new System.Windows.Forms.Button();
            this.매도_btn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.종목이름01_label = new System.Windows.Forms.Label();
            this.보유수량_label = new System.Windows.Forms.Label();
            this.현재가01_label = new System.Windows.Forms.Label();
            this.전일대비_label = new System.Windows.Forms.Label();
            this.수량_numeric = new System.Windows.Forms.NumericUpDown();
            this.가격_numeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.User정보_table.SuspendLayout();
            this.계좌정보_table.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.관심주식_datagridview)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.매수매도_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.수량_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.가격_numeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(293, 218);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(60, 21);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // User정보_table
            // 
            this.User정보_table.BackColor = System.Drawing.Color.White;
            this.User정보_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.User정보_table.ColumnCount = 2;
            this.User정보_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.User정보_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.User정보_table.Controls.Add(this.label2, 0, 1);
            this.User정보_table.Controls.Add(this.사용자이름_label, 1, 0);
            this.User정보_table.Controls.Add(this.계좌_label, 1, 1);
            this.User정보_table.Controls.Add(this.label1, 0, 0);
            this.User정보_table.Location = new System.Drawing.Point(12, 12);
            this.User정보_table.Name = "User정보_table";
            this.User정보_table.RowCount = 2;
            this.User정보_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.User정보_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.User정보_table.Size = new System.Drawing.Size(259, 60);
            this.User정보_table.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "계좌 번호";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 사용자이름_label
            // 
            this.사용자이름_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.사용자이름_label.AutoSize = true;
            this.사용자이름_label.BackColor = System.Drawing.Color.White;
            this.사용자이름_label.Location = new System.Drawing.Point(107, 1);
            this.사용자이름_label.Name = "사용자이름_label";
            this.사용자이름_label.Size = new System.Drawing.Size(148, 28);
            this.사용자이름_label.TabIndex = 2;
            this.사용자이름_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 계좌_label
            // 
            this.계좌_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.계좌_label.AutoSize = true;
            this.계좌_label.BackColor = System.Drawing.Color.White;
            this.계좌_label.Location = new System.Drawing.Point(107, 30);
            this.계좌_label.Name = "계좌_label";
            this.계좌_label.Size = new System.Drawing.Size(148, 29);
            this.계좌_label.TabIndex = 3;
            this.계좌_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 계좌정보_table
            // 
            this.계좌정보_table.BackColor = System.Drawing.Color.White;
            this.계좌정보_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.계좌정보_table.ColumnCount = 2;
            this.계좌정보_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.계좌정보_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.계좌정보_table.Controls.Add(this.label3, 0, 0);
            this.계좌정보_table.Controls.Add(this.label4, 0, 1);
            this.계좌정보_table.Controls.Add(this.label5, 0, 2);
            this.계좌정보_table.Controls.Add(this.label6, 0, 3);
            this.계좌정보_table.Controls.Add(this.자본_label, 1, 0);
            this.계좌정보_table.Controls.Add(this.총매입_label, 1, 1);
            this.계좌정보_table.Controls.Add(this.총평가_label, 1, 2);
            this.계좌정보_table.Controls.Add(this.전체손익_label, 1, 3);
            this.계좌정보_table.Location = new System.Drawing.Point(13, 147);
            this.계좌정보_table.Name = "계좌정보_table";
            this.계좌정보_table.RowCount = 4;
            this.계좌정보_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.계좌정보_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.계좌정보_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.계좌정보_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.계좌정보_table.Size = new System.Drawing.Size(259, 142);
            this.계좌정보_table.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "자본(예수금)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "총매입금액";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 34);
            this.label5.TabIndex = 2;
            this.label5.Text = "총평가금액";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 35);
            this.label6.TabIndex = 3;
            this.label6.Text = "전체손익금액";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 자본_label
            // 
            this.자본_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.자본_label.AutoSize = true;
            this.자본_label.BackColor = System.Drawing.Color.White;
            this.자본_label.Location = new System.Drawing.Point(107, 1);
            this.자본_label.Name = "자본_label";
            this.자본_label.Size = new System.Drawing.Size(148, 34);
            this.자본_label.TabIndex = 4;
            this.자본_label.Text = "0";
            this.자본_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 총매입_label
            // 
            this.총매입_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.총매입_label.AutoSize = true;
            this.총매입_label.BackColor = System.Drawing.Color.White;
            this.총매입_label.Location = new System.Drawing.Point(107, 36);
            this.총매입_label.Name = "총매입_label";
            this.총매입_label.Size = new System.Drawing.Size(148, 34);
            this.총매입_label.TabIndex = 5;
            this.총매입_label.Text = "0";
            this.총매입_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 총평가_label
            // 
            this.총평가_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.총평가_label.AutoSize = true;
            this.총평가_label.BackColor = System.Drawing.Color.White;
            this.총평가_label.Location = new System.Drawing.Point(107, 71);
            this.총평가_label.Name = "총평가_label";
            this.총평가_label.Size = new System.Drawing.Size(148, 34);
            this.총평가_label.TabIndex = 6;
            this.총평가_label.Text = "0";
            this.총평가_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 전체손익_label
            // 
            this.전체손익_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.전체손익_label.AutoSize = true;
            this.전체손익_label.BackColor = System.Drawing.Color.White;
            this.전체손익_label.Location = new System.Drawing.Point(107, 106);
            this.전체손익_label.Name = "전체손익_label";
            this.전체손익_label.Size = new System.Drawing.Size(148, 35);
            this.전체손익_label.TabIndex = 7;
            this.전체손익_label.Text = "0";
            this.전체손익_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 로그인_btn
            // 
            this.로그인_btn.Location = new System.Drawing.Point(13, 90);
            this.로그인_btn.Name = "로그인_btn";
            this.로그인_btn.Size = new System.Drawing.Size(102, 36);
            this.로그인_btn.TabIndex = 4;
            this.로그인_btn.Text = "로그인";
            this.로그인_btn.UseVisualStyleBackColor = true;
            this.로그인_btn.Click += new System.EventHandler(this.로그인_btn_Click);
            // 
            // 계좌정보조회_btn
            // 
            this.계좌정보조회_btn.Enabled = false;
            this.계좌정보조회_btn.Location = new System.Drawing.Point(121, 90);
            this.계좌정보조회_btn.Name = "계좌정보조회_btn";
            this.계좌정보조회_btn.Size = new System.Drawing.Size(150, 36);
            this.계좌정보조회_btn.TabIndex = 5;
            this.계좌정보조회_btn.Text = "계좌정보 조회";
            this.계좌정보조회_btn.UseVisualStyleBackColor = true;
            this.계좌정보조회_btn.Click += new System.EventHandler(this.계좌정보조회_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.삭제_btn);
            this.groupBox1.Controls.Add(this.추가01_btn);
            this.groupBox1.Controls.Add(this.관심주식_datagridview);
            this.groupBox1.Location = new System.Drawing.Point(13, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 266);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "관심 주식";
            // 
            // 삭제_btn
            // 
            this.삭제_btn.Enabled = false;
            this.삭제_btn.Location = new System.Drawing.Point(130, 219);
            this.삭제_btn.Name = "삭제_btn";
            this.삭제_btn.Size = new System.Drawing.Size(123, 41);
            this.삭제_btn.TabIndex = 10;
            this.삭제_btn.Text = "삭제";
            this.삭제_btn.UseVisualStyleBackColor = true;
            this.삭제_btn.Click += new System.EventHandler(this.삭제_btn_Click);
            // 
            // 추가01_btn
            // 
            this.추가01_btn.Enabled = false;
            this.추가01_btn.Location = new System.Drawing.Point(6, 219);
            this.추가01_btn.Name = "추가01_btn";
            this.추가01_btn.Size = new System.Drawing.Size(118, 41);
            this.추가01_btn.TabIndex = 9;
            this.추가01_btn.Text = "추가";
            this.추가01_btn.UseVisualStyleBackColor = true;
            this.추가01_btn.Click += new System.EventHandler(this.추가_btn_Click);
            // 
            // 관심주식_datagridview
            // 
            this.관심주식_datagridview.AllowUserToAddRows = false;
            this.관심주식_datagridview.AllowUserToDeleteRows = false;
            this.관심주식_datagridview.AllowUserToResizeColumns = false;
            this.관심주식_datagridview.AllowUserToResizeRows = false;
            this.관심주식_datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.관심주식_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.관심주식_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.관심종목_코드,
            this.관심종목_이름});
            this.관심주식_datagridview.Location = new System.Drawing.Point(19, 20);
            this.관심주식_datagridview.Name = "관심주식_datagridview";
            this.관심주식_datagridview.RowHeadersVisible = false;
            this.관심주식_datagridview.RowHeadersWidth = 51;
            this.관심주식_datagridview.RowTemplate.Height = 23;
            this.관심주식_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.관심주식_datagridview.Size = new System.Drawing.Size(222, 193);
            this.관심주식_datagridview.TabIndex = 8;
            // 
            // 관심종목_코드
            // 
            this.관심종목_코드.HeaderText = "종목코드";
            this.관심종목_코드.MinimumWidth = 6;
            this.관심종목_코드.Name = "관심종목_코드";
            this.관심종목_코드.ReadOnly = true;
            this.관심종목_코드.Width = 125;
            // 
            // 관심종목_이름
            // 
            this.관심종목_이름.HeaderText = "종목이름";
            this.관심종목_이름.MinimumWidth = 6;
            this.관심종목_이름.Name = "관심종목_이름";
            this.관심종목_이름.ReadOnly = true;
            this.관심종목_이름.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(293, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 326);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "차트 보여줌";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(105, 102);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(348, 124);
            this.button8.TabIndex = 0;
            this.button8.Text = "차트입니다";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // 매수매도_table
            // 
            this.매수매도_table.BackColor = System.Drawing.Color.White;
            this.매수매도_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.매수매도_table.ColumnCount = 2;
            this.매수매도_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.매수매도_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.매수매도_table.Controls.Add(this.매수_btn, 0, 6);
            this.매수매도_table.Controls.Add(this.매도_btn, 1, 6);
            this.매수매도_table.Controls.Add(this.label13, 0, 0);
            this.매수매도_table.Controls.Add(this.label14, 0, 1);
            this.매수매도_table.Controls.Add(this.label15, 0, 2);
            this.매수매도_table.Controls.Add(this.label16, 0, 3);
            this.매수매도_table.Controls.Add(this.label17, 0, 4);
            this.매수매도_table.Controls.Add(this.label18, 0, 5);
            this.매수매도_table.Controls.Add(this.종목이름01_label, 1, 0);
            this.매수매도_table.Controls.Add(this.보유수량_label, 1, 1);
            this.매수매도_table.Controls.Add(this.현재가01_label, 1, 2);
            this.매수매도_table.Controls.Add(this.전일대비_label, 1, 3);
            this.매수매도_table.Controls.Add(this.수량_numeric, 1, 4);
            this.매수매도_table.Controls.Add(this.가격_numeric, 1, 5);
            this.매수매도_table.Location = new System.Drawing.Point(858, 252);
            this.매수매도_table.Name = "매수매도_table";
            this.매수매도_table.RowCount = 7;
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.433962F));
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.805032F));
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.15723F));
            this.매수매도_table.Size = new System.Drawing.Size(228, 319);
            this.매수매도_table.TabIndex = 10;
            // 
            // 매수_btn
            // 
            this.매수_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.매수_btn.Enabled = false;
            this.매수_btn.Location = new System.Drawing.Point(4, 242);
            this.매수_btn.Name = "매수_btn";
            this.매수_btn.Size = new System.Drawing.Size(106, 73);
            this.매수_btn.TabIndex = 0;
            this.매수_btn.Text = "매수";
            this.매수_btn.UseVisualStyleBackColor = true;
            this.매수_btn.Click += new System.EventHandler(this.매수_btn_Click);
            // 
            // 매도_btn
            // 
            this.매도_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.매도_btn.Enabled = false;
            this.매도_btn.Location = new System.Drawing.Point(117, 242);
            this.매도_btn.Name = "매도_btn";
            this.매도_btn.Size = new System.Drawing.Size(107, 73);
            this.매도_btn.TabIndex = 1;
            this.매도_btn.Text = "매도";
            this.매도_btn.UseVisualStyleBackColor = true;
            this.매도_btn.Click += new System.EventHandler(this.매도_btn_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(4, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 44);
            this.label13.TabIndex = 2;
            this.label13.Text = "종목이름";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(4, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 44);
            this.label14.TabIndex = 3;
            this.label14.Text = "보유수량";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(4, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 44);
            this.label15.TabIndex = 4;
            this.label15.Text = "현재가";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(4, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 44);
            this.label16.TabIndex = 5;
            this.label16.Text = "전일대비";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(4, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 29);
            this.label17.TabIndex = 6;
            this.label17.Text = "수량";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(4, 211);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 27);
            this.label18.TabIndex = 7;
            this.label18.Text = "가격";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 종목이름01_label
            // 
            this.종목이름01_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.종목이름01_label.AutoSize = true;
            this.종목이름01_label.BackColor = System.Drawing.Color.White;
            this.종목이름01_label.Location = new System.Drawing.Point(117, 1);
            this.종목이름01_label.Name = "종목이름01_label";
            this.종목이름01_label.Size = new System.Drawing.Size(107, 44);
            this.종목이름01_label.TabIndex = 8;
            this.종목이름01_label.Text = "0";
            this.종목이름01_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 보유수량_label
            // 
            this.보유수량_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.보유수량_label.AutoSize = true;
            this.보유수량_label.BackColor = System.Drawing.Color.White;
            this.보유수량_label.Location = new System.Drawing.Point(117, 46);
            this.보유수량_label.Name = "보유수량_label";
            this.보유수량_label.Size = new System.Drawing.Size(107, 44);
            this.보유수량_label.TabIndex = 9;
            this.보유수량_label.Text = "0";
            this.보유수량_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 현재가01_label
            // 
            this.현재가01_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.현재가01_label.AutoSize = true;
            this.현재가01_label.BackColor = System.Drawing.Color.White;
            this.현재가01_label.Location = new System.Drawing.Point(117, 91);
            this.현재가01_label.Name = "현재가01_label";
            this.현재가01_label.Size = new System.Drawing.Size(107, 44);
            this.현재가01_label.TabIndex = 10;
            this.현재가01_label.Text = "0";
            this.현재가01_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 전일대비_label
            // 
            this.전일대비_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.전일대비_label.AutoSize = true;
            this.전일대비_label.BackColor = System.Drawing.Color.White;
            this.전일대비_label.Location = new System.Drawing.Point(117, 136);
            this.전일대비_label.Name = "전일대비_label";
            this.전일대비_label.Size = new System.Drawing.Size(107, 44);
            this.전일대비_label.TabIndex = 11;
            this.전일대비_label.Text = "0";
            this.전일대비_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 수량_numeric
            // 
            this.수량_numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.수량_numeric.Location = new System.Drawing.Point(117, 184);
            this.수량_numeric.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.수량_numeric.Name = "수량_numeric";
            this.수량_numeric.Size = new System.Drawing.Size(107, 21);
            this.수량_numeric.TabIndex = 12;
            // 
            // 가격_numeric
            // 
            this.가격_numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.가격_numeric.Location = new System.Drawing.Point(117, 214);
            this.가격_numeric.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.가격_numeric.Name = "가격_numeric";
            this.가격_numeric.Size = new System.Drawing.Size(107, 21);
            this.가격_numeric.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Location = new System.Drawing.Point(293, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(790, 200);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "거래 관련 정보";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(236, 57);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(303, 78);
            this.button7.TabIndex = 0;
            this.button7.Text = "잔고, 미체결 기록";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 583);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.매수매도_table);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.계좌정보조회_btn);
            this.Controls.Add(this.로그인_btn);
            this.Controls.Add(this.계좌정보_table);
            this.Controls.Add(this.User정보_table);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Name = "Parent";
            this.Text = "Parent";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.User정보_table.ResumeLayout(false);
            this.User정보_table.PerformLayout();
            this.계좌정보_table.ResumeLayout(false);
            this.계좌정보_table.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.관심주식_datagridview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.매수매도_table.ResumeLayout(false);
            this.매수매도_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.수량_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.가격_numeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.TableLayoutPanel User정보_table;
        private System.Windows.Forms.TableLayoutPanel 계좌정보_table;
        private System.Windows.Forms.Button 로그인_btn;
        private System.Windows.Forms.Button 계좌정보조회_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button 삭제_btn;
        private System.Windows.Forms.Button 추가01_btn;
        private System.Windows.Forms.DataGridView 관심주식_datagridview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel 매수매도_table;
        private System.Windows.Forms.Button 매수_btn;
        private System.Windows.Forms.Button 매도_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 사용자이름_label;
        private System.Windows.Forms.Label 계좌_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label 자본_label;
        private System.Windows.Forms.Label 총매입_label;
        private System.Windows.Forms.Label 총평가_label;
        private System.Windows.Forms.Label 전체손익_label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label 종목이름01_label;
        private System.Windows.Forms.Label 보유수량_label;
        private System.Windows.Forms.Label 현재가01_label;
        private System.Windows.Forms.Label 전일대비_label;
        private System.Windows.Forms.NumericUpDown 수량_numeric;
        private System.Windows.Forms.NumericUpDown 가격_numeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관심종목_코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관심종목_이름;
    }
}

