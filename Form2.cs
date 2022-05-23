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
        string name;
        string code;
        public Child(Parent form1)
        {
            InitializeComponent();
            parent = form1;
            추가02_btn.Enabled = false;
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
                        if (selectRowindex == 0 && 종목검색_datagridview.Rows.Count == 1 && 종목검색_datagridview["종목검색_이름", selectRowindex].Value == null)
                        {   // 처음에 빈 셀이 선택되서 오류나는 것을 방지함
                            종목검색_datagridview.ClearSelection();
                            return;
                        }
                        name = 종목검색_datagridview["종목검색_이름", selectRowindex].Value.ToString();
                        code = 종목검색_datagridview["종목검색_코드", selectRowindex].Value.ToString();
                        추가02_btn.Enabled = true;
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

            foreach (string name in parent.all_Name)
            {
                if (name.IndexOf(검색_txtBox.Text, 0, name.Length) != -1)
                {
                    종목검색_datagridview.Rows.Add(); // datagrid 행 추가
                    종목검색_datagridview["종목검색_이름", j].Value = name;
                    종목검색_datagridview["종목검색_코드", j].Value = parent.all_Code[i];
                    //종목검색_datagridview["종목검색_현재가", j].Value = parent.현재가[i];
                    j++;
                }
                i++;
            }
        }

        private void 추가02_btn_Click(object sender, EventArgs e)
        {
            if (종목검색_datagridview.SelectedCells.Count > 0)
            {
                parent.add_grid(name, code);
            }
        }
    }
}
