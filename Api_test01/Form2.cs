using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Api_test01
{
    public partial class Child : Form
    {
        Parent parent;
        public Child(Parent form1)
        {
            InitializeComponent();
            parent = form1;
            종목검색_datagridview.SelectionChanged += SendInfo;
        }

        public void SendInfo(object sender, EventArgs e)
        {   // 종목검색에서 나온 종목을 고르면, 그 종목의 정보를 table에 간략하게 출력함
            if (sender.Equals(종목검색_datagridview))
            {
                try
                {
                    if (종목검색_datagridview.SelectedCells.Count > 0)
                    {
                        int selectRowindex = 종목검색_datagridview.SelectedCells[0].RowIndex;
                        string name = 종목검색_datagridview["종목검색_이름", selectRowindex].Value.ToString();
                        string code = 종목검색_datagridview["종목검색_코드", selectRowindex].Value.ToString();
                        종목이름02_label.Text = name;
                        종목코드_label.Text = code;
                    }
                }
                catch (Exception ex)
                { 
                    // 오류나도 속행한다.
                }
            }
        }

        private void 검색_btn_Click(object sender, EventArgs e)
        {
            // 현재는 1개만 검색에 나오게 함

            if (검색_txtBox.Text == "") { return; }
            종목검색_datagridview.Rows.Clear();
            int i = 0, j = 0;

            foreach (string name in parent.종목이름)
            {
                if (name.IndexOf(검색_txtBox.Text, 0, name.Length)!=-1)
                {
                    종목검색_datagridview.Rows.Add(); // datagrid 행 추가
                    종목검색_datagridview["종목검색_이름", j].Value = name;
                    종목검색_datagridview["종목검색_코드", j].Value = parent.종목코드[i];
                    j++;
                }
                i++;
            }
        }

        private void 추가02_btn_Click(object sender, EventArgs e)
        {
            if (종목검색_datagridview.SelectedCells.Count > 0)
            {
                parent.add_grid(종목이름02_label.Text, 종목코드_label.Text);
            }
        }
    }
}
