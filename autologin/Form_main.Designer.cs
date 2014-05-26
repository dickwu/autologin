namespace autologin
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.label1 = new System.Windows.Forms.Label();
            this.text_username = new System.Windows.Forms.TextBox();
            this.but_login = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.text_passwd = new System.Windows.Forms.TextBox();
            this.but_quit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_website = new System.Windows.Forms.TextBox();
            this.but_class = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.text_keywords = new System.Windows.Forms.TextBox();
            this.but_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(46, 7);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(123, 20);
            this.text_username.TabIndex = 1;
            this.text_username.TextChanged += new System.EventHandler(this.text_username_TextChanged);
            // 
            // but_login
            // 
            this.but_login.Location = new System.Drawing.Point(14, 76);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(75, 25);
            this.but_login.TabIndex = 2;
            this.but_login.Text = "登陆";
            this.but_login.UseVisualStyleBackColor = true;
            this.but_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(-1, 107);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 22);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1241, 452);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码：";
            // 
            // text_passwd
            // 
            this.text_passwd.Location = new System.Drawing.Point(46, 47);
            this.text_passwd.Name = "text_passwd";
            this.text_passwd.PasswordChar = '*';
            this.text_passwd.Size = new System.Drawing.Size(123, 20);
            this.text_passwd.TabIndex = 5;
            this.text_passwd.TextChanged += new System.EventHandler(this.text_passwd_TextChanged);
            // 
            // but_quit
            // 
            this.but_quit.Location = new System.Drawing.Point(95, 76);
            this.but_quit.Name = "but_quit";
            this.but_quit.Size = new System.Drawing.Size(75, 25);
            this.but_quit.TabIndex = 6;
            this.but_quit.Text = "退出";
            this.but_quit.UseVisualStyleBackColor = true;
            this.but_quit.Click += new System.EventHandler(this.but_class_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "网址：";
            // 
            // text_website
            // 
            this.text_website.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_website.Location = new System.Drawing.Point(212, 78);
            this.text_website.Name = "text_website";
            this.text_website.Size = new System.Drawing.Size(999, 20);
            this.text_website.TabIndex = 8;
            // 
            // but_class
            // 
            this.but_class.Location = new System.Drawing.Point(212, 4);
            this.but_class.Name = "but_class";
            this.but_class.Size = new System.Drawing.Size(75, 25);
            this.but_class.TabIndex = 9;
            this.but_class.Text = "课表";
            this.but_class.UseVisualStyleBackColor = true;
            this.but_class.Click += new System.EventHandler(this.but_class_Click_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "获取的数据：";
            // 
            // text_keywords
            // 
            this.text_keywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_keywords.Location = new System.Drawing.Point(90, 559);
            this.text_keywords.Name = "text_keywords";
            this.text_keywords.Size = new System.Drawing.Size(1150, 20);
            this.text_keywords.TabIndex = 11;
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(212, 44);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 23);
            this.but_save.TabIndex = 12;
            this.but_save.Text = "保存账号";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 580);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.text_keywords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.but_class);
            this.Controls.Add(this.text_website);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_quit);
            this.Controls.Add(this.text_passwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.but_login);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_main";
            this.Text = "上海理工教务处登陆";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_passwd;
        private System.Windows.Forms.Button but_quit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_website;
        private System.Windows.Forms.Button but_class;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_keywords;
        private System.Windows.Forms.Button but_save;
    }
}

