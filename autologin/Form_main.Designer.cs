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
            this.but_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richText_POST = new System.Windows.Forms.RichTextBox();
            this.List_classChoiced = new System.Windows.Forms.CheckedListBox();
            this.button_post = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // text_username
            // 
            this.text_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_username.Location = new System.Drawing.Point(46, 6);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(123, 21);
            this.text_username.TabIndex = 1;
            this.text_username.TextChanged += new System.EventHandler(this.text_username_TextChanged);
            // 
            // but_login
            // 
            this.but_login.Location = new System.Drawing.Point(14, 70);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(75, 23);
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
            this.webBrowser1.Location = new System.Drawing.Point(-1, 99);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1241, 506);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码：";
            // 
            // text_passwd
            // 
            this.text_passwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_passwd.Location = new System.Drawing.Point(46, 43);
            this.text_passwd.Name = "text_passwd";
            this.text_passwd.PasswordChar = '*';
            this.text_passwd.Size = new System.Drawing.Size(123, 21);
            this.text_passwd.TabIndex = 5;
            this.text_passwd.TextChanged += new System.EventHandler(this.text_passwd_TextChanged);
            // 
            // but_quit
            // 
            this.but_quit.Location = new System.Drawing.Point(95, 70);
            this.but_quit.Name = "but_quit";
            this.but_quit.Size = new System.Drawing.Size(75, 23);
            this.but_quit.TabIndex = 6;
            this.but_quit.Text = "退出";
            this.but_quit.UseVisualStyleBackColor = true;
            this.but_quit.Click += new System.EventHandler(this.but_class_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "网址：";
            // 
            // text_website
            // 
            this.text_website.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_website.Location = new System.Drawing.Point(212, 72);
            this.text_website.Name = "text_website";
            this.text_website.Size = new System.Drawing.Size(999, 21);
            this.text_website.TabIndex = 8;
            // 
            // but_class
            // 
            this.but_class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_class.Location = new System.Drawing.Point(212, 4);
            this.but_class.Name = "but_class";
            this.but_class.Size = new System.Drawing.Size(75, 23);
            this.but_class.TabIndex = 9;
            this.but_class.Text = "课表";
            this.but_class.UseVisualStyleBackColor = true;
            this.but_class.Click += new System.EventHandler(this.but_class_Click_1);
            // 
            // but_save
            // 
            this.but_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_save.Location = new System.Drawing.Point(212, 41);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 21);
            this.but_save.TabIndex = 12;
            this.but_save.Text = "保存账号";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "POST数据：";
            // 
            // richText_POST
            // 
            this.richText_POST.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richText_POST.Location = new System.Drawing.Point(58, 611);
            this.richText_POST.Name = "richText_POST";
            this.richText_POST.Size = new System.Drawing.Size(1182, 25);
            this.richText_POST.TabIndex = 14;
            this.richText_POST.Text = "";
            // 
            // List_classChoiced
            // 
            this.List_classChoiced.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_classChoiced.FormattingEnabled = true;
            this.List_classChoiced.Location = new System.Drawing.Point(293, 4);
            this.List_classChoiced.Name = "List_classChoiced";
            this.List_classChoiced.Size = new System.Drawing.Size(288, 52);
            this.List_classChoiced.TabIndex = 15;
            // 
            // button_post
            // 
            this.button_post.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_post.Location = new System.Drawing.Point(600, 33);
            this.button_post.Name = "button_post";
            this.button_post.Size = new System.Drawing.Size(75, 23);
            this.button_post.TabIndex = 16;
            this.button_post.Text = "开始选课";
            this.button_post.UseVisualStyleBackColor = true;
            this.button_post.Click += new System.EventHandler(this.button_post_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 632);
            this.Controls.Add(this.button_post);
            this.Controls.Add(this.List_classChoiced);
            this.Controls.Add(this.richText_POST);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.but_save);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_main_FormClosing);
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
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richText_POST;
        private System.Windows.Forms.CheckedListBox List_classChoiced;
        private System.Windows.Forms.Button button_post;
    }
}

