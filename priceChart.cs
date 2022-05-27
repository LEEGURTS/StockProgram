using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Api_test01 {
    public partial class priceChart : Form {
        Form parent;

        public priceChart(string name, int[] 차선호가, int[] 차선잔량,
            int 매도최우선호가, int 매도최우선잔량, int 매수최우선호가, int 매수최우선잔량, int[] 호가, int[] 잔량) {
            InitializeComponent();
            
            txtName.Text =name;
            lstPrice.DrawItem += ListBox_DrawItem;
            lstPrice.DrawMode = DrawMode.OwnerDrawVariable;

            lstPrice.ItemHeight = lstPrice.Height / 20;

            lstVolume.DrawItem += ListBox_DrawItem;
            lstVolume.DrawMode = DrawMode.OwnerDrawVariable;
            lstVolume.ItemHeight = lstVolume.Height / 20;
            this.parent = parent;

            this.lstPrice.Items.Clear();
            this.lstVolume.Items.Clear();
            for (int i = 0; i < 9; i++) {

                this.lstPrice.Items.Add(차선호가[i]);

                if (i == 4) {

                    this.lstVolume.Items.Add(차선잔량[i]);

                }
                else {

                    this.lstVolume.Items.Add(차선잔량[i]);
                }
            }


            this.lstPrice.Items.Add(매도최우선호가 + " / 매도최우선호가");

            this.lstVolume.Items.Add(매도최우선잔량);


            this.lstPrice.Items.Add(매수최우선호가 + " / 매수최우선호가");

            this.lstVolume.Items.Add(매수최우선잔량);
            for (int i = 0; i < 9; i++) {
                if (i == 4) {

                    this.lstPrice.Items.Add(호가[i] + " / " + (2 + i) + "차선");


                    this.lstVolume.Items.Add(잔량[i]);
                }
                else {

                    this.lstPrice.Items.Add(호가[i] + " / " + (2 + i) + "차선");


                    this.lstVolume.Items.Add(잔량[i]);
                }
            }

        }

        public void ListBox_DrawItem(object sender, DrawItemEventArgs e) {
            if (sender.Equals(lstPrice)) {
                try {
                    if (e.Index < 10) {
                        e.Graphics.FillRectangle(Brushes.LightSteelBlue, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                    else {
                        e.Graphics.FillRectangle(Brushes.LightPink, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                    String value = lstPrice.Items[e.Index].ToString();
                    Brush brush;

                    if (value[0] == '-') {
                        brush = Brushes.Blue;
                    }
                    else {
                        brush = Brushes.Red;
                    }
                    int x = e.Bounds.X + e.Font.Height / 2;
                    int y = e.Bounds.Y + e.Font.Height / 2;

                    e.Graphics.DrawString(value.Replace("-", ""), e.Font, brush, x, y, StringFormat.GenericDefault);
                }
                catch (Exception exception) {
                    Console.WriteLine(exception.Message.ToString());
                }
            }
            else if (sender.Equals(lstVolume)) {
                try {
                    string value = lstVolume.Items[e.Index].ToString();

                    int x = e.Bounds.X + e.Font.Height / 2 + e.Bounds.Width / 2;
                    int y = e.Bounds.Y + e.Font.Height / 2;

                    e.Graphics.DrawString(value, e.Font, Brushes.Black, x, y, StringFormat.GenericDefault);
                }
                catch (Exception exception) {
                    Console.WriteLine(exception.Message.ToString());

                }
            }
        }
    }
}
