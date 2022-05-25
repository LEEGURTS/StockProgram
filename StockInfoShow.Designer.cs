
namespace Api_test01
{
    partial class StockInfoShow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl시가 = new System.Windows.Forms.Label();
            this.lbl고가 = new System.Windows.Forms.Label();
            this.lbl저가 = new System.Windows.Forms.Label();
            this.lbl종가 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "가격 정보";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "시가:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "고가:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "저가:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "종가:";
            // 
            // lbl시가
            // 
            this.lbl시가.AutoSize = true;
            this.lbl시가.Location = new System.Drawing.Point(51, 44);
            this.lbl시가.Name = "lbl시가";
            this.lbl시가.Size = new System.Drawing.Size(38, 12);
            this.lbl시가.TabIndex = 5;
            this.lbl시가.Text = "label5";
            // 
            // lbl고가
            // 
            this.lbl고가.AutoSize = true;
            this.lbl고가.Location = new System.Drawing.Point(51, 85);
            this.lbl고가.Name = "lbl고가";
            this.lbl고가.Size = new System.Drawing.Size(38, 12);
            this.lbl고가.TabIndex = 6;
            this.lbl고가.Text = "label5";
            // 
            // lbl저가
            // 
            this.lbl저가.AutoSize = true;
            this.lbl저가.Location = new System.Drawing.Point(51, 132);
            this.lbl저가.Name = "lbl저가";
            this.lbl저가.Size = new System.Drawing.Size(38, 12);
            this.lbl저가.TabIndex = 7;
            this.lbl저가.Text = "label5";
            // 
            // lbl종가
            // 
            this.lbl종가.AutoSize = true;
            this.lbl종가.Location = new System.Drawing.Point(51, 180);
            this.lbl종가.Name = "lbl종가";
            this.lbl종가.Size = new System.Drawing.Size(38, 12);
            this.lbl종가.TabIndex = 8;
            this.lbl종가.Text = "label5";
            // 
            // StockInfoShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(99, 206);
            this.Controls.Add(this.lbl종가);
            this.Controls.Add(this.lbl저가);
            this.Controls.Add(this.lbl고가);
            this.Controls.Add(this.lbl시가);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockInfoShow";
            this.Text = "StockInfoShow";
            this.MouseLeave += new System.EventHandler(this.StockInfoShow_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl시가;
        private System.Windows.Forms.Label lbl고가;
        private System.Windows.Forms.Label lbl저가;
        private System.Windows.Forms.Label lbl종가;
    }
}