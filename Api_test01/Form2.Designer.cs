
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
            this.검색_txtBox = new System.Windows.Forms.TextBox();
            this.검색_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.현재가02_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.종목코드_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.종목이름02_label = new System.Windows.Forms.Label();
            this.추가02_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.종목검색_datagridview = new System.Windows.Forms.DataGridView();
            this.종목검색_이름 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.종목검색_코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.종목검색_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(460, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "종목 검색";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.검색_txtBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.검색_btn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 38);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // 검색_txtBox
            // 
            this.검색_txtBox.Location = new System.Drawing.Point(4, 5);
            this.검색_txtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.검색_txtBox.Name = "검색_txtBox";
            this.검색_txtBox.Size = new System.Drawing.Size(301, 25);
            this.검색_txtBox.TabIndex = 5;
            // 
            // 검색_btn
            // 
            this.검색_btn.Location = new System.Drawing.Point(312, 5);
            this.검색_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.검색_btn.Name = "검색_btn";
            this.검색_btn.Size = new System.Drawing.Size(126, 28);
            this.검색_btn.TabIndex = 4;
            this.검색_btn.Text = "검색";
            this.검색_btn.UseVisualStyleBackColor = true;
            this.검색_btn.Click += new System.EventHandler(this.검색_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.종목검색_datagridview);
            this.groupBox2.Location = new System.Drawing.Point(14, 99);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(460, 226);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "종목 리스트";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.Controls.Add(this.현재가02_label, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.종목코드_label, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.종목이름02_label, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.추가02_btn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(268, 25);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(181, 188);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // 현재가02_label
            // 
            this.현재가02_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.현재가02_label.AutoSize = true;
            this.현재가02_label.Location = new System.Drawing.Point(86, 95);
            this.현재가02_label.Name = "현재가02_label";
            this.현재가02_label.Size = new System.Drawing.Size(89, 43);
            this.현재가02_label.TabIndex = 6;
            this.현재가02_label.Text = "0";
            this.현재가02_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 43);
            this.label5.TabIndex = 5;
            this.label5.Text = "현재가";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 종목코드_label
            // 
            this.종목코드_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.종목코드_label.AutoSize = true;
            this.종목코드_label.Location = new System.Drawing.Point(86, 49);
            this.종목코드_label.Name = "종목코드_label";
            this.종목코드_label.Size = new System.Drawing.Size(89, 43);
            this.종목코드_label.TabIndex = 4;
            this.종목코드_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 43);
            this.label3.TabIndex = 3;
            this.label3.Text = "종목코드";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 종목이름02_label
            // 
            this.종목이름02_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.종목이름02_label.AutoSize = true;
            this.종목이름02_label.Location = new System.Drawing.Point(86, 3);
            this.종목이름02_label.Name = "종목이름02_label";
            this.종목이름02_label.Size = new System.Drawing.Size(89, 43);
            this.종목이름02_label.TabIndex = 2;
            this.종목이름02_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 추가02_btn
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.추가02_btn, 2);
            this.추가02_btn.Location = new System.Drawing.Point(6, 145);
            this.추가02_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.추가02_btn.Name = "추가02_btn";
            this.추가02_btn.Size = new System.Drawing.Size(167, 36);
            this.추가02_btn.TabIndex = 0;
            this.추가02_btn.Text = "관심주식 추가";
            this.추가02_btn.UseVisualStyleBackColor = true;
            this.추가02_btn.Click += new System.EventHandler(this.추가02_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "종목이름";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 종목검색_datagridview
            // 
            this.종목검색_datagridview.AllowUserToAddRows = false;
            this.종목검색_datagridview.AllowUserToDeleteRows = false;
            this.종목검색_datagridview.AllowUserToResizeColumns = false;
            this.종목검색_datagridview.AllowUserToResizeRows = false;
            this.종목검색_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.종목검색_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.종목검색_이름,
            this.종목검색_코드});
            this.종목검색_datagridview.Location = new System.Drawing.Point(7, 25);
            this.종목검색_datagridview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.종목검색_datagridview.Name = "종목검색_datagridview";
            this.종목검색_datagridview.RowHeadersVisible = false;
            this.종목검색_datagridview.RowHeadersWidth = 51;
            this.종목검색_datagridview.RowTemplate.Height = 23;
            this.종목검색_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.종목검색_datagridview.Size = new System.Drawing.Size(255, 188);
            this.종목검색_datagridview.TabIndex = 0;
            // 
            // 종목검색_이름
            // 
            this.종목검색_이름.HeaderText = "종목이름";
            this.종목검색_이름.MinimumWidth = 6;
            this.종목검색_이름.Name = "종목검색_이름";
            this.종목검색_이름.ReadOnly = true;
            this.종목검색_이름.Width = 125;
            // 
            // 종목검색_코드
            // 
            this.종목검색_코드.HeaderText = "종목코드";
            this.종목검색_코드.MinimumWidth = 6;
            this.종목검색_코드.Name = "종목검색_코드";
            this.종목검색_코드.ReadOnly = true;
            this.종목검색_코드.Width = 125;
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Child";
            this.Text = "Child";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button 추가02_btn;
        private System.Windows.Forms.Label 현재가02_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label 종목코드_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label 종목이름02_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목검색_이름;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목검색_코드;
    }
}