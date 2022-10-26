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
    public partial class fIN : Form
    {
        public fIN()
        {
            InitializeComponent();
        }
        public fIN(string 날짜, string 분류, string 금액, string 비고 )
        {
            InitializeComponent();
            dtDate.Value = DateTime.Parse(날짜);
            tbType.Text = 분류;
            tbAmt.Text = 금액;
            tbMemo.Text = 비고;
        
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbMemo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbType_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAmt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
