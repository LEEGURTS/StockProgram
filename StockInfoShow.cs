using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Api_test01
{
    public partial class StockInfoShow : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse);
        public StockInfoShow(List<string> data)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            lbl시가.Text = data[0];
            lbl고가.Text = data[1];
            lbl저가.Text = data[2];
            lbl종가.Text = data[3];
            Location = this.TopLevelControl.PointToClient(this.PointToScreen(new Point(MousePosition.X-2, MousePosition.Y-2)));
        }


        private void StockInfoShow_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
