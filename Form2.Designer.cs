
namespace Api_test01
{
    partial class Child
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.검색_btn = new System.Windows.Forms.Button();
            this.검색_txtBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.현재가02_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.종목검색_datagridview = new System.Windows.Forms.DataGridView();
            this.종목검색_이름 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.종목검색_코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.추가02_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.종목검색_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "종목 검색";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.검색_btn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.검색_txtBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 30);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // 검색_btn
            // 
            this.검색_btn.Location = new System.Drawing.Point(362, 4);
            this.검색_btn.Name = "검색_btn";
            this.검색_btn.Size = new System.Drawing.Size(148, 22);
            this.검색_btn.TabIndex = 4;
            this.검색_btn.Text = "검색";
            this.검색_btn.UseVisualStyleBackColor = true;
            this.검색_btn.Click += new System.EventHandler(this.검색_btn_Click);
            // 
            // 검색_txtBox
            // 
            this.검색_txtBox.Location = new System.Drawing.Point(4, 4);
            this.검색_txtBox.Name = "검색_txtBox";
            this.검색_txtBox.Size = new System.Drawing.Size(351, 21);
            this.검색_txtBox.TabIndex = 5;
            this.검색_txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.검색_txtBox_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.현재가02_label);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.종목검색_datagridview);
            this.groupBox2.Controls.Add(this.추가02_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 469);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "종목 리스트";
            // 
            // 현재가02_label
            // 
            this.현재가02_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.현재가02_label.AutoSize = true;
            this.현재가02_label.Location = new System.Drawing.Point(107, 432);
            this.현재가02_label.Name = "현재가02_label";
            this.현재가02_label.Size = new System.Drawing.Size(11, 12);
            this.현재가02_label.TabIndex = 6;
            this.현재가02_label.Text = "0";
            this.현재가02_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "현재가";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 종목검색_datagridview
            // 
            this.종목검색_datagridview.AllowUserToAddRows = false;
            this.종목검색_datagridview.AllowUserToDeleteRows = false;
            this.종목검색_datagridview.AllowUserToResizeColumns = false;
            this.종목검색_datagridview.AllowUserToResizeRows = false;
            this.종목검색_datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.종목검색_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.종목검색_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.종목검색_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.종목검색_이름,
            this.종목검색_코드});
            this.종목검색_datagridview.Location = new System.Drawing.Point(6, 20);
            this.종목검색_datagridview.Name = "종목검색_datagridview";
            this.종목검색_datagridview.RowHeadersVisible = false;
            this.종목검색_datagridview.RowHeadersWidth = 51;
            this.종목검색_datagridview.RowTemplate.Height = 23;
            this.종목검색_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.종목검색_datagridview.Size = new System.Drawing.Size(504, 379);
            this.종목검색_datagridview.TabIndex = 0;
            // 
            // 종목검색_이름
            // 
            this.종목검색_이름.HeaderText = "종목이름";
            this.종목검색_이름.MinimumWidth = 6;
            this.종목검색_이름.Name = "종목검색_이름";
            this.종목검색_이름.ReadOnly = true;
            // 
            // 종목검색_코드
            // 
            this.종목검색_코드.HeaderText = "종목코드";
            this.종목검색_코드.MinimumWidth = 6;
            this.종목검색_코드.Name = "종목검색_코드";
            this.종목검색_코드.ReadOnly = true;
            // 
            // 추가02_btn
            // 
            this.추가02_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.추가02_btn.Location = new System.Drawing.Point(364, 424);
            this.추가02_btn.Name = "추가02_btn";
            this.추가02_btn.Size = new System.Drawing.Size(146, 29);
            this.추가02_btn.TabIndex = 0;
            this.추가02_btn.Text = "관심주식 추가";
            this.추가02_btn.UseVisualStyleBackColor = true;
            this.추가02_btn.Click += new System.EventHandler(this.추가02_btn_Click);
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Child";
            this.Text = "Child";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.종목검색_datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox 검색_txtBox;
        private System.Windows.Forms.Button 검색_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView 종목검색_datagridview;
        private System.Windows.Forms.Button 추가02_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목검색_이름;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목검색_코드;
        private System.Windows.Forms.Label 현재가02_label;
        private System.Windows.Forms.Label label5;
    }
}