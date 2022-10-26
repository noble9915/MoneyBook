using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBook
{
    public partial class fMain : Form
    {
       
        public fMain()
        {
            InitializeComponent();
        }

        private void btIN_Click(object sender, EventArgs e)
        {
            fIN f = new fIN();
            DialogResult result = f.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                //입력데이터 확인
   
                DateTime 입력일 = f.dtDate.Value;
                string 분류 = f.tbType.Text;
                string 금액 = f.tbAmt.Text;
                string 비고 = f.tbMemo.Text;

                //데이터를 추가한다.
                //(미구현)



                //목록에 추가된 데이터를 표시한다. (목록을 새로고침)
                ListViewItem lv= lv1.Items.Add(입력일.ToShortDateString());
                lv.SubItems.Add(분류);
                lv.SubItems.Add(금액);
                lv.SubItems.Add(""); //출금
                lv.SubItems.Add(비고);
            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
                
                fOut f = new fOut();
                DialogResult result = f.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    //입력데이터 확인

                    DateTime 입력일 = f.dtDate.Value;
                    string 분류 = f.tbType.Text;
                    string 금액 = f.tbAmt.Text;
                    string 비고 = f.tbMemo.Text;

                    //데이터를 추가한다.
                    //(미구현)



                    //목록에 추가된 데이터를 표시한다. (목록을 새로고침)
                    ListViewItem lv = lv1.Items.Add(입력일.ToShortDateString());
                    lv.SubItems.Add(분류);
                    lv.SubItems.Add(금액);
                    lv.SubItems.Add(""); //입금
                    lv.SubItems.Add(비고);
                }
            }

        private void btLogin_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            DialogResult result = f.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //로그인이 성공함
                //1. 자료를 불러와서 표시(목록)
                //2. 입/출금 버튼 활성화
                btIN.Enabled = true; //입금버튼 활성
                btOut.Enabled = true; //출금버튼 활성
            }
            else
            {
                //로그인이 실패함
                //1. 현재 표시되는 목록 제거
                //2. 입/출금 등록 버튼 비활성
                btIN.Enabled = false; //입금버튼비활성
                btOut.Enabled = false; //출금버튼 비활성

            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void sbUserName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btDelect_Click(object sender, EventArgs e)
        {
            //삭제메뉴
            if (lv1.SelectedItems.Count < 1)
            {
                MessageBox.Show("데이터를 선택하세요");
                return;
            }

            DialogResult result = MessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                ListViewItem lv = lv1.SelectedItems[0];
                lv1.Items.Remove(lv);
                MessageBox.Show("삭제 완료");
            }

        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            //편집메뉴
            if (lv1.SelectedItems.Count < 1)
            {
                MessageBox.Show("데이터를 선택하세요");
                return;
            }
            //선택된 자료의 구분을 확인한다.
            ListViewItem lv = lv1.SelectedItems[0];
            string 날짜 = lv.SubItems[0].Text;
            string 분류 = lv.SubItems[1].Text;
            string 입금액 = lv.SubItems[2].Text;
            string 출금액 = lv.SubItems[3].Text;
            string 비고 = lv.SubItems[4].Text;
            if (입금액 != "")
            {
                //입금화면을 호출하고 현재 데이터를 전송
                fIN f = new fIN(날짜, 분류, 입금액, 비고);
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //현재 선택된 자료를 업데이트 합니다.
                    lv.SubItems[0].Text = f.dtDate.Value.ToLongDateString();
                    lv.SubItems[1].Text = f.tbType.Text;
                    lv.SubItems[2].Text = f.tbAmt.Text;
                    lv.SubItems[3].Text = "";
                    lv.SubItems[4].Text = f.tbMemo.Text;
                }

            }
            else
            {
                //출금화면을 호축
                fOut f = new fOut(날짜,분류,출금액,비고);
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //현재 선택된 자료를 업데이트 합니다.
                    lv.SubItems[0].Text = f.dtDate.Value.ToLongDateString();
                    lv.SubItems[1].Text = f.tbType.Text;
                    lv.SubItems[2].Text = f.tbAmt.Text;
                    lv.SubItems[3].Text = "";
                    lv.SubItems[4].Text = f.tbMemo.Text;
                }
            }
        }
    }
}
