using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;




namespace autologin
{
    public partial class Form_main : Form
    {
        int function=0;
        string url_box="";
        Cookie cookieSave;
        IsRight check_str = new IsRight();
        public Form_main()
        {
            InitializeComponent();
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            check_str.UserName = text_username.Text;
            check_str.PassWord =text_passwd.Text;
            if (!check_str.isright())
                MessageBox.Show("请输入完全");
            else
            {
                string sUrl = "http://jwc1.usst.edu.cn/default5.aspx";
                webBrowser1.Navigate(sUrl);
                function = 1;
               // this.webBrowser1.DocumentCompleted +=new  WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
                System.Threading.Thread.Sleep(1500);
                //webBrowser1.Refresh();

                but_quit.Enabled = true;
                but_login.Text = "刷新登陆";
                but_class.Enabled = true;
                text_username.Enabled = false;
                text_passwd.Enabled = false;

                CookieContainer myCookie = new CookieContainer();
                string cookieStr = webBrowser1.Document.Cookie;
                string[] cookiestr = cookieStr.Split(';');


                foreach (string str in cookiestr)
                {
                    string[] cookieNameValue = str.Split('=');
                    Cookie ck = new Cookie(cookieNameValue[0].Trim().ToString(), cookieNameValue[1].Trim().ToString());
                    ck.Domain = "jwc1.usst.edu.cn";
                    cookieSave = ck;


                }


            }
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           if(function==1)//login
           {
               
                   
                       HtmlElement tbUserid = webBrowser1.Document.GetElementById("TextBox1");
                       tbUserid.SetAttribute("value", text_username.Text.ToString());

                       HtmlElement tbPasswd = webBrowser1.Document.GetElementById("TextBox2");
                       tbPasswd.SetAttribute("value", text_passwd.Text.ToString());

                       HtmlElement btLogin = webBrowser1.Document.GetElementById("Button1");
                       btLogin.InvokeMember("click");
                       function = 3;


            }
           if(function==2)//post
           {
              
               HtmlElement btLogin = webBrowser1.Document.GetElementById("likTc");
               btLogin.InvokeMember("click");
               but_class.Enabled = false;
               but_quit.Enabled = false;
               text_username.Enabled = true;
               text_passwd.Enabled = true;
               function = 3;

           }
            if(function==3)
            {
                url_box = webBrowser1.Document.Url.ToString();
                text_website.Text = url_box;
                WebRequest req = WebRequest.Create(url_box);
                WebResponse resp = req.GetResponse();
                StreamReader reader = new StreamReader(resp.GetResponseStream(), Encoding.UTF8);
                StreamReader readersave = new StreamReader(resp.GetResponseStream(), Encoding.UTF8);

                keyword getkey = new keyword();
                getkey.ReaderSave = readersave;
                text_keywords.Text = getkey.findkeyword(48);

                System.IO.StreamWriter file = new StreamWriter(@"d:\test.txt");
                file.WriteLine(reader.ReadToEnd());                               
                file.Close();
            }
            if(function==4)
            {
                function = 3;
                HtmlDocument total = webBrowser1.Document;


                
            }

        }








        private void but_class_Click(object sender, EventArgs e)
        {
            function = 2;//退出
            string sUrl = text_website.Text.ToString();
            webBrowser1.Navigate(sUrl);
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
            webBrowser1.Refresh();
            but_login.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string keysa;
            but_quit.Enabled = false;
            but_class.Enabled = false;
           // text_keywords.Enabled = false;
            text_website.Enabled = false;

        

            try
            {
                System.IO.StreamReader file_reader = new StreamReader(@"d:\login.txt");
                text_username.Text = file_reader.ReadLine().ToString();
                keysa = file_reader.ReadLine().ToString();
                text_passwd.Text = keepmessagesafe.DecryptDES(keysa,text_username.Text.ToString()).ToString();
                file_reader.Close();
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show("未保存过密码\n"+"请先保存密码以便下次快速登录","友情提示");
                but_save.Enabled = true;
            }


            check_str.UserName = text_username.Text;
            check_str.PassWord = text_passwd.Text;
            if (check_str.isright())
                but_save.Enabled = false;

            string sUrl = "http://jwc1.usst.edu.cn";
            webBrowser1.Navigate(sUrl);
            function = 3;
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
             System.Threading.Thread.Sleep(1500);
        }

                         


        private void but_class_Click_1(object sender, EventArgs e)
        {
            //选课按键
            function = 3;
            //string sUrl = "http://jwc1.usst.edu.cn/xskbcx.aspx?xh=1112030225&xm=吴沛林&gnmkdm=N121603";
            //webBrowser1.Navigate(sUrl);
            //this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            check_str.UserName = text_username.Text;
            check_str.PassWord = text_passwd.Text;
            if (!check_str.isright())
                MessageBox.Show("保存出错");
            else
            {
                
                System.IO.StreamWriter file_login = new StreamWriter(@"d:\login.txt");
                file_login.WriteLine(text_username.Text);

                //加密密码文件
                file_login.WriteLine(keepmessagesafe.EncryptDES(text_passwd.Text.ToString(), text_username.Text.ToString()));
                file_login.Close();
                but_save.Enabled = false;
                MessageBox.Show("保存成功\n"+"以后即可快速登录","提示");
 
            }
        }

        private void text_username_TextChanged(object sender, EventArgs e)
        {
            but_save.Enabled = true;
        }

        private void text_passwd_TextChanged(object sender, EventArgs e)
        {
            but_save.Enabled = true;
        }
    }
}
