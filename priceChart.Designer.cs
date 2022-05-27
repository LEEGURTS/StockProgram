
namespace Api_test01 {
	partial class priceChart {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(priceChart));
			this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.labPrice = new System.Windows.Forms.Label();
			this.lstPrice = new System.Windows.Forms.ListBox();
			this.lstVolume = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// axKHOpenAPI1
			// 
			this.axKHOpenAPI1.Enabled = true;
			this.axKHOpenAPI1.Location = new System.Drawing.Point(4, 56);
			this.axKHOpenAPI1.Name = "axKHOpenAPI1";
			this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
			this.axKHOpenAPI1.Size = new System.Drawing.Size(61, 18);
			this.axKHOpenAPI1.TabIndex = 5;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.axKHOpenAPI1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labPrice, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lstPrice, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.lstVolume, 1, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 521);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.LemonChiffon;
			this.label3.Location = new System.Drawing.Point(270, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(260, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "0";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.txtName, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(526, 19);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.LightGray;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(257, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "종목명";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtName
			// 
			this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtName.Location = new System.Drawing.Point(266, 3);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(257, 21);
			this.txtName.TabIndex = 1;
			// 
			// labPrice
			// 
			this.labPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labPrice.AutoSize = true;
			this.labPrice.BackColor = System.Drawing.Color.SeaShell;
			this.labPrice.Location = new System.Drawing.Point(4, 27);
			this.labPrice.Name = "labPrice";
			this.labPrice.Size = new System.Drawing.Size(259, 25);
			this.labPrice.TabIndex = 1;
			this.labPrice.Text = "0";
			this.labPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lstPrice
			// 
			this.lstPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstPrice.FormattingEnabled = true;
			this.lstPrice.ItemHeight = 12;
			this.lstPrice.Location = new System.Drawing.Point(1, 79);
			this.lstPrice.Margin = new System.Windows.Forms.Padding(0);
			this.lstPrice.Name = "lstPrice";
			this.lstPrice.Size = new System.Drawing.Size(265, 436);
			this.lstPrice.TabIndex = 3;
			// 
			// lstVolume
			// 
			this.lstVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstVolume.FormattingEnabled = true;
			this.lstVolume.ItemHeight = 12;
			this.lstVolume.Location = new System.Drawing.Point(267, 79);
			this.lstVolume.Margin = new System.Windows.Forms.Padding(0);
			this.lstVolume.Name = "lstVolume";
			this.lstVolume.Size = new System.Drawing.Size(266, 436);
			this.lstVolume.TabIndex = 4;
			// 
			// priceChart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 521);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "priceChart";
			this.Text = "Form3";
			((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label labPrice;
		public System.Windows.Forms.ListBox lstPrice;
		public System.Windows.Forms.ListBox lstVolume;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
	}
}