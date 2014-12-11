namespace 通用投票软件
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btBegin = new System.Windows.Forms.Button();
            this.tbPostData = new System.Windows.Forms.TextBox();
            this.tbPostUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLimit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.RtbLog = new System.Windows.Forms.RichTextBox();
            this.btStop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEntryName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btBegin
            // 
            this.btBegin.Location = new System.Drawing.Point(199, 243);
            this.btBegin.Name = "btBegin";
            this.btBegin.Size = new System.Drawing.Size(57, 23);
            this.btBegin.TabIndex = 0;
            this.btBegin.Text = "开始";
            this.btBegin.UseVisualStyleBackColor = true;
            this.btBegin.Click += new System.EventHandler(this.btBegin_Click);
            // 
            // tbPostData
            // 
            this.tbPostData.Location = new System.Drawing.Point(12, 63);
            this.tbPostData.Multiline = true;
            this.tbPostData.Name = "tbPostData";
            this.tbPostData.Size = new System.Drawing.Size(312, 95);
            this.tbPostData.TabIndex = 1;
            this.tbPostData.Text = resources.GetString("tbPostData.Text");
            // 
            // tbPostUrl
            // 
            this.tbPostUrl.Location = new System.Drawing.Point(12, 24);
            this.tbPostUrl.Name = "tbPostUrl";
            this.tbPostUrl.Size = new System.Drawing.Size(312, 21);
            this.tbPostUrl.TabIndex = 2;
            this.tbPostUrl.Text = "http://www.19lou.com/vote/verify?created_city=2&uid=0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "地址:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "数据:(a=1&&b=2&&...)";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(101, 191);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(223, 21);
            this.tbUserName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "宽带用户名:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "宽带密码:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(101, 218);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(223, 21);
            this.tbPassword.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "每投";
            // 
            // tbLimit
            // 
            this.tbLimit.Location = new System.Drawing.Point(47, 245);
            this.tbLimit.Name = "tbLimit";
            this.tbLimit.Size = new System.Drawing.Size(63, 21);
            this.tbLimit.TabIndex = 10;
            this.tbLimit.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "次，重连宽带";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RtbLog
            // 
            this.RtbLog.Location = new System.Drawing.Point(14, 272);
            this.RtbLog.Name = "RtbLog";
            this.RtbLog.ReadOnly = true;
            this.RtbLog.Size = new System.Drawing.Size(310, 162);
            this.RtbLog.TabIndex = 12;
            this.RtbLog.Text = "";
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(262, 243);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(62, 23);
            this.btStop.TabIndex = 13;
            this.btStop.Text = "停止";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "宽带连接名称:";
            // 
            // tbEntryName
            // 
            this.tbEntryName.Location = new System.Drawing.Point(101, 164);
            this.tbEntryName.Name = "tbEntryName";
            this.tbEntryName.Size = new System.Drawing.Size(223, 21);
            this.tbEntryName.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 446);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbEntryName);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.RtbLog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLimit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPostUrl);
            this.Controls.Add(this.tbPostData);
            this.Controls.Add(this.btBegin);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBegin;
        private System.Windows.Forms.TextBox tbPostData;
        private System.Windows.Forms.TextBox tbPostUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RichTextBox RtbLog;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEntryName;
    }
}

