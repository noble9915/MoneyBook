namespace MoneyBook
{
    partial class fOut
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbAmt = new System.Windows.Forms.TextBox();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "분류";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "등록일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "금액";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "비고";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(115, 87);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(242, 25);
            this.tbType.TabIndex = 3;
            // 
            // tbAmt
            // 
            this.tbAmt.Location = new System.Drawing.Point(115, 129);
            this.tbAmt.Name = "tbAmt";
            this.tbAmt.Size = new System.Drawing.Size(242, 25);
            this.tbAmt.TabIndex = 5;
            // 
            // tbMemo
            // 
            this.tbMemo.Location = new System.Drawing.Point(115, 169);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(242, 153);
            this.tbMemo.TabIndex = 7;
            this.tbMemo.TextChanged += new System.EventHandler(this.tbMemo_TextChanged);
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(115, 35);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(242, 25);
            this.dtDate.TabIndex = 1;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(115, 338);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(242, 59);
            this.btOk.TabIndex = 8;
            this.btOk.Text = "확인";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // fOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 409);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.tbAmt);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "출금";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btOk;
        public System.Windows.Forms.DateTimePicker dtDate;
        public System.Windows.Forms.TextBox tbType;
        public System.Windows.Forms.TextBox tbAmt;
        public System.Windows.Forms.TextBox tbMemo;
    }
}