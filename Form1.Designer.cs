
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
            this.계좌_label = new System.Windows.Forms.Label();
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
            this.종목코드_label = new System.Windows.Forms.Label();
            this.현재가01_label = new System.Windows.Forms.Label();
            this.전일대비_label = new System.Windows.Forms.Label();
            this.수량_numeric = new System.Windows.Forms.NumericUpDown();
            this.가격_numeric = new System.Windows.Forms.NumericUpDown();
            this.사용자이름_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MultiPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMakeSmall = new System.Windows.Forms.Button();
            this.btnMakeBig = new System.Windows.Forms.Button();
            this.삭제_btn = new System.Windows.Forms.Button();
            this.추가01_btn = new System.Windows.Forms.Button();
            this.관심주식_datagridview = new System.Windows.Forms.DataGridView();
            this.관심주식_코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.관심주식_이름 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIESearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.계좌정보_table.SuspendLayout();
            this.매수매도_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.수량_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.가격_numeric)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.관심주식_datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(1012, 297);
            this.axKHOpenAPI1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(75, 26);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // 계좌_label
            // 
            this.계좌_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.계좌_label.AutoSize = true;
            this.계좌_label.BackColor = System.Drawing.Color.White;
            this.계좌_label.Font = new System.Drawing.Font("굴림체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.계좌_label.Location = new System.Drawing.Point(806, 39);
            this.계좌_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.계좌_label.Name = "계좌_label";
            this.계좌_label.Size = new System.Drawing.Size(0, 16);
            this.계좌_label.TabIndex = 3;
            this.계좌_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 계좌정보_table
            // 
            this.계좌정보_table.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.계좌정보_table.Location = new System.Drawing.Point(788, 92);
            this.계좌정보_table.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.계좌정보_table.Name = "계좌정보_table";
            this.계좌정보_table.RowCount = 4;
            this.계좌정보_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.계좌정보_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.계좌정보_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.계좌정보_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.계좌정보_table.Size = new System.Drawing.Size(204, 182);
            this.계좌정보_table.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 44);
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
            this.label4.Location = new System.Drawing.Point(3, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 44);
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
            this.label5.Location = new System.Drawing.Point(3, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 44);
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
            this.label6.Location = new System.Drawing.Point(3, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 45);
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
            this.자본_label.Location = new System.Drawing.Point(84, 1);
            this.자본_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.자본_label.Name = "자본_label";
            this.자본_label.Size = new System.Drawing.Size(117, 44);
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
            this.총매입_label.Location = new System.Drawing.Point(84, 46);
            this.총매입_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.총매입_label.Name = "총매입_label";
            this.총매입_label.Size = new System.Drawing.Size(117, 44);
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
            this.총평가_label.Location = new System.Drawing.Point(84, 91);
            this.총평가_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.총평가_label.Name = "총평가_label";
            this.총평가_label.Size = new System.Drawing.Size(117, 44);
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
            this.전체손익_label.Location = new System.Drawing.Point(84, 136);
            this.전체손익_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.전체손익_label.Name = "전체손익_label";
            this.전체손익_label.Size = new System.Drawing.Size(117, 45);
            this.전체손익_label.TabIndex = 7;
            this.전체손익_label.Text = "0";
            this.전체손익_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 로그인_btn
            // 
            this.로그인_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(206)))));
            this.로그인_btn.FlatAppearance.BorderSize = 0;
            this.로그인_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.로그인_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.로그인_btn.Location = new System.Drawing.Point(938, 60);
            this.로그인_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.로그인_btn.Name = "로그인_btn";
            this.로그인_btn.Size = new System.Drawing.Size(56, 24);
            this.로그인_btn.TabIndex = 4;
            this.로그인_btn.Text = "로그인";
            this.로그인_btn.UseVisualStyleBackColor = false;
            this.로그인_btn.Click += new System.EventHandler(this.로그인_btn_Click);
            // 
            // 계좌정보조회_btn
            // 
            this.계좌정보조회_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(206)))));
            this.계좌정보조회_btn.Enabled = false;
            this.계좌정보조회_btn.FlatAppearance.BorderSize = 0;
            this.계좌정보조회_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.계좌정보조회_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.계좌정보조회_btn.Location = new System.Drawing.Point(829, 61);
            this.계좌정보조회_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.계좌정보조회_btn.Name = "계좌정보조회_btn";
            this.계좌정보조회_btn.Size = new System.Drawing.Size(103, 23);
            this.계좌정보조회_btn.TabIndex = 5;
            this.계좌정보조회_btn.Text = "계좌정보 조회";
            this.계좌정보조회_btn.UseVisualStyleBackColor = false;
            this.계좌정보조회_btn.Visible = false;
            this.계좌정보조회_btn.Click += new System.EventHandler(this.계좌정보조회_btn_Click);
            // 
            // 매수매도_table
            // 
            this.매수매도_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.매수매도_table.Controls.Add(this.종목코드_label, 1, 1);
            this.매수매도_table.Controls.Add(this.현재가01_label, 1, 2);
            this.매수매도_table.Controls.Add(this.전일대비_label, 1, 3);
            this.매수매도_table.Controls.Add(this.수량_numeric, 1, 4);
            this.매수매도_table.Controls.Add(this.가격_numeric, 1, 5);
            this.매수매도_table.Location = new System.Drawing.Point(785, 331);
            this.매수매도_table.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.매수매도_table.Name = "매수매도_table";
            this.매수매도_table.RowCount = 8;
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.433962F));
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.805032F));
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.15723F));
            this.매수매도_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.매수매도_table.Size = new System.Drawing.Size(209, 319);
            this.매수매도_table.TabIndex = 10;
            // 
            // 매수_btn
            // 
            this.매수_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.매수_btn.Enabled = false;
            this.매수_btn.Location = new System.Drawing.Point(3, 226);
            this.매수_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.매수_btn.Name = "매수_btn";
            this.매수_btn.Size = new System.Drawing.Size(99, 66);
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
            this.매도_btn.Location = new System.Drawing.Point(107, 226);
            this.매도_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.매도_btn.Name = "매도_btn";
            this.매도_btn.Size = new System.Drawing.Size(99, 66);
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
            this.label13.Location = new System.Drawing.Point(3, 1);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 41);
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
            this.label14.Location = new System.Drawing.Point(3, 43);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 41);
            this.label14.TabIndex = 3;
            this.label14.Text = "종목코드";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 85);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 41);
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
            this.label16.Location = new System.Drawing.Point(3, 127);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 41);
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
            this.label17.Location = new System.Drawing.Point(3, 169);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 27);
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
            this.label18.Location = new System.Drawing.Point(3, 197);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 25);
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
            this.종목이름01_label.Location = new System.Drawing.Point(107, 1);
            this.종목이름01_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.종목이름01_label.Name = "종목이름01_label";
            this.종목이름01_label.Size = new System.Drawing.Size(99, 41);
            this.종목이름01_label.TabIndex = 8;
            this.종목이름01_label.Text = "0";
            this.종목이름01_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.종목이름01_label.Click += new System.EventHandler(this.종목이름01_label_Click);
            // 
            // 종목코드_label
            // 
            this.종목코드_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.종목코드_label.AutoSize = true;
            this.종목코드_label.BackColor = System.Drawing.Color.White;
            this.종목코드_label.Location = new System.Drawing.Point(107, 43);
            this.종목코드_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.종목코드_label.Name = "종목코드_label";
            this.종목코드_label.Size = new System.Drawing.Size(99, 41);
            this.종목코드_label.TabIndex = 9;
            this.종목코드_label.Text = "0";
            this.종목코드_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 현재가01_label
            // 
            this.현재가01_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.현재가01_label.AutoSize = true;
            this.현재가01_label.BackColor = System.Drawing.Color.White;
            this.현재가01_label.Location = new System.Drawing.Point(107, 85);
            this.현재가01_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.현재가01_label.Name = "현재가01_label";
            this.현재가01_label.Size = new System.Drawing.Size(99, 41);
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
            this.전일대비_label.Location = new System.Drawing.Point(107, 127);
            this.전일대비_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.전일대비_label.Name = "전일대비_label";
            this.전일대비_label.Size = new System.Drawing.Size(99, 41);
            this.전일대비_label.TabIndex = 11;
            this.전일대비_label.Text = "0";
            this.전일대비_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 수량_numeric
            // 
            this.수량_numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.수량_numeric.Location = new System.Drawing.Point(107, 172);
            this.수량_numeric.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.수량_numeric.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.수량_numeric.Name = "수량_numeric";
            this.수량_numeric.Size = new System.Drawing.Size(99, 21);
            this.수량_numeric.TabIndex = 12;
            // 
            // 가격_numeric
            // 
            this.가격_numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.가격_numeric.Location = new System.Drawing.Point(107, 200);
            this.가격_numeric.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.가격_numeric.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.가격_numeric.Name = "가격_numeric";
            this.가격_numeric.Size = new System.Drawing.Size(99, 21);
            this.가격_numeric.TabIndex = 13;
            // 
            // 사용자이름_label
            // 
            this.사용자이름_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.사용자이름_label.AutoSize = true;
            this.사용자이름_label.BackColor = System.Drawing.Color.White;
            this.사용자이름_label.Font = new System.Drawing.Font("굴림체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.사용자이름_label.Location = new System.Drawing.Point(806, 16);
            this.사용자이름_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.사용자이름_label.Name = "사용자이름_label";
            this.사용자이름_label.Size = new System.Drawing.Size(0, 16);
            this.사용자이름_label.TabIndex = 2;
            this.사용자이름_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(91, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Stock Simulator";
            // 
            // MultiPanel
            // 
            this.MultiPanel.Location = new System.Drawing.Point(268, 91);
            this.MultiPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MultiPanel.Name = "MultiPanel";
            this.MultiPanel.Size = new System.Drawing.Size(500, 560);
            this.MultiPanel.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.btnMakeSmall);
            this.panel1.Controls.Add(this.btnMakeBig);
            this.panel1.Controls.Add(this.삭제_btn);
            this.panel1.Controls.Add(this.추가01_btn);
            this.panel1.Controls.Add(this.관심주식_datagridview);
            this.panel1.Controls.Add(this.btnIESearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnChart);
            this.panel1.Controls.Add(this.btnBalance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 664);
            this.panel1.TabIndex = 21;
            // 
            // btnMakeSmall
            // 
            this.btnMakeSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.btnMakeSmall.FlatAppearance.BorderSize = 0;
            this.btnMakeSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeSmall.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMakeSmall.Location = new System.Drawing.Point(26, 359);
            this.btnMakeSmall.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMakeSmall.Name = "btnMakeSmall";
            this.btnMakeSmall.Size = new System.Drawing.Size(101, 41);
            this.btnMakeSmall.TabIndex = 22;
            this.btnMakeSmall.Text = "축소";
            this.btnMakeSmall.UseVisualStyleBackColor = false;
            this.btnMakeSmall.Click += new System.EventHandler(this.btnMakeSmall_Click);
            // 
            // btnMakeBig
            // 
            this.btnMakeBig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.btnMakeBig.FlatAppearance.BorderSize = 0;
            this.btnMakeBig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeBig.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMakeBig.Location = new System.Drawing.Point(133, 359);
            this.btnMakeBig.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMakeBig.Name = "btnMakeBig";
            this.btnMakeBig.Size = new System.Drawing.Size(97, 41);
            this.btnMakeBig.TabIndex = 21;
            this.btnMakeBig.Text = "확대";
            this.btnMakeBig.UseVisualStyleBackColor = false;
            this.btnMakeBig.Click += new System.EventHandler(this.btnMakeBig_Click);
            // 
            // 삭제_btn
            // 
            this.삭제_btn.Enabled = false;
            this.삭제_btn.FlatAppearance.BorderSize = 0;
            this.삭제_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.삭제_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.삭제_btn.Location = new System.Drawing.Point(26, 605);
            this.삭제_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.삭제_btn.Name = "삭제_btn";
            this.삭제_btn.Size = new System.Drawing.Size(203, 41);
            this.삭제_btn.TabIndex = 10;
            this.삭제_btn.Text = "삭제";
            this.삭제_btn.UseVisualStyleBackColor = true;
            this.삭제_btn.Visible = false;
            this.삭제_btn.Click += new System.EventHandler(this.삭제_btn_Click);
            // 
            // 추가01_btn
            // 
            this.추가01_btn.FlatAppearance.BorderSize = 0;
            this.추가01_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.추가01_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.추가01_btn.Image = global::Api_test01.Properties.Resources.search_12_24;
            this.추가01_btn.Location = new System.Drawing.Point(44, 219);
            this.추가01_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.추가01_btn.Name = "추가01_btn";
            this.추가01_btn.Size = new System.Drawing.Size(171, 41);
            this.추가01_btn.TabIndex = 9;
            this.추가01_btn.Text = "          검색";
            this.추가01_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.추가01_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.추가01_btn.UseVisualStyleBackColor = true;
            this.추가01_btn.Click += new System.EventHandler(this.추가_btn_Click);
            this.추가01_btn.MouseEnter += new System.EventHandler(this.추가01_btn_MouseEnter);
            this.추가01_btn.MouseLeave += new System.EventHandler(this.추가01_btn_MouseLeave);
            // 
            // 관심주식_datagridview
            // 
            this.관심주식_datagridview.AllowUserToAddRows = false;
            this.관심주식_datagridview.AllowUserToDeleteRows = false;
            this.관심주식_datagridview.AllowUserToResizeColumns = false;
            this.관심주식_datagridview.AllowUserToResizeRows = false;
            this.관심주식_datagridview.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.관심주식_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.관심주식_datagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.관심주식_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.관심주식_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.관심주식_코드,
            this.관심주식_이름});
            this.관심주식_datagridview.Location = new System.Drawing.Point(26, 406);
            this.관심주식_datagridview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.관심주식_datagridview.Name = "관심주식_datagridview";
            this.관심주식_datagridview.RowHeadersVisible = false;
            this.관심주식_datagridview.RowHeadersWidth = 51;
            this.관심주식_datagridview.RowTemplate.Height = 23;
            this.관심주식_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.관심주식_datagridview.Size = new System.Drawing.Size(203, 193);
            this.관심주식_datagridview.TabIndex = 8;
            // 
            // 관심주식_코드
            // 
            this.관심주식_코드.HeaderText = "종목코드";
            this.관심주식_코드.MinimumWidth = 6;
            this.관심주식_코드.Name = "관심주식_코드";
            this.관심주식_코드.ReadOnly = true;
            // 
            // 관심주식_이름
            // 
            this.관심주식_이름.HeaderText = "종목이름";
            this.관심주식_이름.MinimumWidth = 6;
            this.관심주식_이름.Name = "관심주식_이름";
            this.관심주식_이름.ReadOnly = true;
            // 
            // btnIESearch
            // 
            this.btnIESearch.FlatAppearance.BorderSize = 0;
            this.btnIESearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIESearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIESearch.Image = global::Api_test01.Properties.Resources.newspaper_24;
            this.btnIESearch.Location = new System.Drawing.Point(44, 163);
            this.btnIESearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIESearch.Name = "btnIESearch";
            this.btnIESearch.Size = new System.Drawing.Size(171, 41);
            this.btnIESearch.TabIndex = 20;
            this.btnIESearch.Text = "          뉴스";
            this.btnIESearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIESearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIESearch.UseVisualStyleBackColor = true;
            this.btnIESearch.Click += new System.EventHandler(this.btnIESearch_Click);
            this.btnIESearch.MouseEnter += new System.EventHandler(this.btnIESearch_MouseEnter);
            this.btnIESearch.MouseLeave += new System.EventHandler(this.btnIESearch_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.pictureBox1.Image = global::Api_test01.Properties.Resources.pngaaa_com_5178135;
            this.pictureBox1.Location = new System.Drawing.Point(19, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 53);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnChart
            // 
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChart.Image = global::Api_test01.Properties.Resources.pie_chart_24;
            this.btnChart.Location = new System.Drawing.Point(44, 107);
            this.btnChart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(171, 41);
            this.btnChart.TabIndex = 17;
            this.btnChart.Text = "          차트";
            this.btnChart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            this.btnChart.Leave += new System.EventHandler(this.btnChart_Leave);
            this.btnChart.MouseEnter += new System.EventHandler(this.btnChart_MouseEnter);
            this.btnChart.MouseLeave += new System.EventHandler(this.btnChart_MouseLeave);
            // 
            // btnBalance
            // 
            this.btnBalance.FlatAppearance.BorderSize = 0;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.ForeColor = System.Drawing.Color.White;
            this.btnBalance.Image = global::Api_test01.Properties.Resources.icons8_account_24;
            this.btnBalance.Location = new System.Drawing.Point(44, 266);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(171, 41);
            this.btnBalance.TabIndex = 14;
            this.btnBalance.Text = "     잔고확인";
            this.btnBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            this.btnBalance.MouseEnter += new System.EventHandler(this.btnBalance_MouseEnter);
            this.btnBalance.MouseLeave += new System.EventHandler(this.btnBalance_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Api_test01.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(747, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 43);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Api_test01.Properties.Resources._1564506_close_exit_logout_power_icon;
            this.pictureBox2.Location = new System.Drawing.Point(955, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 43);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 664);
            this.Controls.Add(this.MultiPanel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.계좌_label);
            this.Controls.Add(this.사용자이름_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.매수매도_table);
            this.Controls.Add(this.계좌정보조회_btn);
            this.Controls.Add(this.로그인_btn);
            this.Controls.Add(this.계좌정보_table);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Parent";
            this.Text = "Parent";
            this.Load += new System.EventHandler(this.Parent_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Drag_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Drag_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.계좌정보_table.ResumeLayout(false);
            this.계좌정보_table.PerformLayout();
            this.매수매도_table.ResumeLayout(false);
            this.매수매도_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.수량_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.가격_numeric)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.관심주식_datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.TableLayoutPanel 계좌정보_table;
        private System.Windows.Forms.Button 로그인_btn;
        private System.Windows.Forms.Button 계좌정보조회_btn;
        private System.Windows.Forms.Button 추가01_btn;
        private System.Windows.Forms.TableLayoutPanel 매수매도_table;
        private System.Windows.Forms.Button 매수_btn;
        private System.Windows.Forms.Button 매도_btn;
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
        private System.Windows.Forms.Label 종목코드_label;
        private System.Windows.Forms.NumericUpDown 수량_numeric;
        private System.Windows.Forms.NumericUpDown 가격_numeric;
        private System.Windows.Forms.Label 사용자이름_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel MultiPanel;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnIESearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button 삭제_btn;
        private System.Windows.Forms.DataGridView 관심주식_datagridview;
        private System.Windows.Forms.Button btnMakeBig;
        private System.Windows.Forms.Button btnMakeSmall;
        public System.Windows.Forms.Label 종목이름01_label;
        public System.Windows.Forms.Label 현재가01_label;
        public System.Windows.Forms.Label 전일대비_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관심주식_코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관심주식_이름;
		private System.Windows.Forms.Button btnBalance;
	}
}

