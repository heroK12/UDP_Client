namespace UDP_Client
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.RcvStart = new System.Windows.Forms.Button();
            this.IPtxt = new System.Windows.Forms.TextBox();
            this.LocalPort = new System.Windows.Forms.TextBox();
            this.RemotePort = new System.Windows.Forms.TextBox();
            this.RcvClose = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.SendMsg = new System.Windows.Forms.TextBox();
            this.Logtxt = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RcvStart
            // 
            this.RcvStart.Location = new System.Drawing.Point(208, 19);
            this.RcvStart.Name = "RcvStart";
            this.RcvStart.Size = new System.Drawing.Size(75, 23);
            this.RcvStart.TabIndex = 0;
            this.RcvStart.Text = "受信";
            this.RcvStart.UseVisualStyleBackColor = true;
            this.RcvStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // IPtxt
            // 
            this.IPtxt.Location = new System.Drawing.Point(63, 15);
            this.IPtxt.Name = "IPtxt";
            this.IPtxt.Size = new System.Drawing.Size(132, 19);
            this.IPtxt.TabIndex = 1;
            this.IPtxt.Text = "127.0.0.1";
            // 
            // LocalPort
            // 
            this.LocalPort.Location = new System.Drawing.Point(63, 21);
            this.LocalPort.Name = "LocalPort";
            this.LocalPort.Size = new System.Drawing.Size(132, 19);
            this.LocalPort.TabIndex = 2;
            // 
            // RemotePort
            // 
            this.RemotePort.Location = new System.Drawing.Point(63, 55);
            this.RemotePort.Name = "RemotePort";
            this.RemotePort.Size = new System.Drawing.Size(132, 19);
            this.RemotePort.TabIndex = 3;
            // 
            // RcvClose
            // 
            this.RcvClose.Location = new System.Drawing.Point(208, 51);
            this.RcvClose.Name = "RcvClose";
            this.RcvClose.Size = new System.Drawing.Size(75, 23);
            this.RcvClose.TabIndex = 4;
            this.RcvClose.Text = "閉じる";
            this.RcvClose.UseVisualStyleBackColor = true;
            this.RcvClose.Click += new System.EventHandler(this.RcvClose_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(447, 71);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 5;
            this.SendBtn.Text = "送信";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // SendMsg
            // 
            this.SendMsg.Location = new System.Drawing.Point(6, 46);
            this.SendMsg.Name = "SendMsg";
            this.SendMsg.Size = new System.Drawing.Size(516, 19);
            this.SendMsg.TabIndex = 6;
            // 
            // Logtxt
            // 
            this.Logtxt.FormattingEnabled = true;
            this.Logtxt.ItemHeight = 12;
            this.Logtxt.Location = new System.Drawing.Point(12, 256);
            this.Logtxt.Name = "Logtxt";
            this.Logtxt.Size = new System.Drawing.Size(541, 160);
            this.Logtxt.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IPtxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 44);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "受信";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "IPアドレス";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LocalPort);
            this.groupBox2.Controls.Add(this.RcvStart);
            this.groupBox2.Controls.Add(this.RemotePort);
            this.groupBox2.Controls.Add(this.RcvClose);
            this.groupBox2.Location = new System.Drawing.Point(12, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 80);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "送信";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Remote";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.SendBtn);
            this.groupBox3.Controls.Add(this.SendMsg);
            this.groupBox3.Location = new System.Drawing.Point(12, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "データ送信";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "送信するデータ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Logtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RcvStart;
        private System.Windows.Forms.TextBox IPtxt;
        private System.Windows.Forms.TextBox LocalPort;
        private System.Windows.Forms.TextBox RemotePort;
        private System.Windows.Forms.Button RcvClose;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox SendMsg;
        private System.Windows.Forms.ListBox Logtxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
    }
}

