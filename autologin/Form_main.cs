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
using Microsoft.Win32;
using System.Runtime.InteropServices;




namespace autologin
{
    public partial class Form_main : Form
    {
        int function=0;
        string url_box="";
        int order=0;
        string[] postUrls = new string[50];
        string[] postDate = new string[50];
        CookieContainer cookieSave=new CookieContainer();
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
                //but_class.Enabled = true;
                text_username.Enabled = false;
                text_passwd.Enabled = false;
                button_postclass.Enabled = true;

                ///保存cookie
                ///保存到cookiesave 后面的but_post中使用
                CookieContainer myCookie = new CookieContainer();
                string cookieStr = webBrowser1.Document.Cookie;
                richText_return.Text = cookieStr;
                string[] cookiestr = cookieStr.Split(';');
                foreach (string str in cookiestr)
                {
                    string[] cookieNameValue = str.Split('=');
                    Cookie ck = new Cookie(cookieNameValue[0].Trim().ToString(), cookieNameValue[1].Trim().ToString());
                    ck.Domain = "jwc1.usst.edu.cn";
                    cookieSave.Add(ck);


                }


            }
            
        }
        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //将所有的链接的目标，指向本窗体
            foreach (HtmlElement archor in this.webBrowser1.Document.Links)
            {
                archor.SetAttribute("target", "_self");
            }

            //将所有的FORM的提交目标，指向本窗体
            foreach (HtmlElement form in this.webBrowser1.Document.Forms)
            {
                form.SetAttribute("target", "_self");
            }
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
           if(function==2)//退出
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
                /*
                WebRequest req = WebRequest.Create(url_box);
                WebResponse resp = req.GetResponse();
                StreamReader reader = new StreamReader(resp.GetResponseStream(), Encoding.UTF8);
                StreamReader readersave = new StreamReader(resp.GetResponseStream(), Encoding.UTF8);

                keyword getkey = new keyword();
                getkey.ReaderSave = readersave;
                System.IO.StreamWriter file = new StreamWriter(@"d:\test.txt");
                file.WriteLine(reader.ReadToEnd());                               
                file.Close();
                 */
            }
            if(function==4)
            {
                function = 3;

                


                
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

        private void WebBrowser1_BeforeNavigate(object pDisp,ref object URL,ref object Flags, ref object TargetFramName,
                ref object PostDate,ref object Headers,ref bool Cancel)
        {
            byte[] post;
            if (PostDate != null)
            {
                post = PostDate as byte[];
                
                postUrls[order] = URL.ToString();
                postDate[order] = System.Text.Encoding.ASCII.GetString(PostDate as byte[]);
                textorder.Text = order.ToString();
                order += 1;
                richText_POST.Text = postDate[order - 1];
               // MessageBox.Show("已捕获一个可能的选课数据");
                richText_return.Text = Headers.ToString() + post.Length;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string keysa;
            but_quit.Enabled = false;
            but_class.Enabled = false;
            text_website.Enabled = false;
            
            richText_POST.Multiline = false;
            richText_POST.Enabled = false;
            button_postclass.Enabled = false;
        

            


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
            ///加入对post数据的提取
            SHDocVw.WebBrowser wb = (SHDocVw.WebBrowser)webBrowser1.ActiveXInstance;
            wb.BeforeNavigate2 += new SHDocVw.DWebBrowserEvents2_BeforeNavigate2EventHandler(WebBrowser1_BeforeNavigate);
            //结束定义
            
            function = 3;
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
             //System.Threading.Thread.Sleep(1500);

             RegistryKey myReg1, myReg2;//声明注册表对象
             myReg1 = Registry.CurrentUser;//获取当前用户注册表项
             try
             {
                 myReg2 = myReg1.CreateSubKey("Software\\MySoft");//在注册表项中创建子项
                 this.Location = new Point(Convert.ToInt16(myReg2.GetValue("1")), Convert.ToInt16(myReg2.GetValue("2")));//设置窗体的显示位置
                 if (myReg2.GetValue("3") != null && myReg2.GetValue("4") != null)
                 {
                     this.Width = Convert.ToInt16(myReg2.GetValue("3"));
                     this.Height = Convert.ToInt16(myReg2.GetValue("4"));
                 }
             }
             catch { }

        }

        private void Form_main_FormClosing(object sender, FormClosedEventArgs e)
        {
            RegistryKey myReg1, myReg2;//声明注册表对象
            myReg1 = Registry.CurrentUser;//获取当前用户注册表项
            myReg2 = myReg1.CreateSubKey("Software\\MySoft");//在注册表项中创建子项
            try
            {
                myReg2.SetValue("1", this.Location.X.ToString());//将窗体关闭位置的x坐标写入注册表
                myReg2.SetValue("2", this.Location.Y.ToString());//将窗体关闭位置的y坐标写入注册表
                myReg2.SetValue("3", this.Width.ToString());
                myReg2.SetValue("4", this.Height.ToString());
            }
            catch { }
        }
              

        private void but_class_Click_1(object sender, EventArgs e)
        {
            //选课按键
            function = 3;
            
            
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

        private void button_post_Click(object sender, EventArgs e)
        {
            /*
            for(int i=0;i<List_classChoiced.Items.Count;i++)
            {
                if (List_classChoiced.GetItemChecked(i))
                {
                    if(i==1)
                        richText_return.Text = SendDataByPost(postUrl[i], richText_POST.Text.ToString().Trim());
                    //richText_return.Text = SendDataByPost(text_website.Text.ToString(), richText_POST.Text.ToString());
                }
            }
             */

            richText_return.Text = SendDataByPost(postUrls[int.Parse(textorder.Text)], postDate[int.Parse(textorder.Text)]);
        }
    
        #region 同步通过POST方式发送数据
        /// <summary>
        /// 通过POST方式发送数据
        /// </summary>
        /// <param name="Url">url</param>
        /// <param name="postDataStr">Post数据</param>
        /// <param name="cookie">Cookie容器</param>
        /// <returns></returns>
        public string SendDataByPost(string Url,string postDataStr)
        {
             CookieContainer cookie=new CookieContainer();
            // cookie = cookieSave;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            if (cookie.Count == 0)
            {
                request.CookieContainer = new CookieContainer();
                cookie = request.CookieContainer;
            }
            else
            {
                request.CookieContainer = cookie;
            }

            string retString = "";
            try
            {
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                request.ContentLength = postDataStr.Length;
                Stream myRequestStream = request.GetRequestStream();
                StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
                myStreamWriter.Write(postDataStr);
                myStreamWriter.Close();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("gb2312"));
                 retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                return retString;
            }
            catch(WebException ex)
            {
                HttpWebResponse res = ex.Response as HttpWebResponse;

                if (res.StatusCode == HttpStatusCode.InternalServerError)
                {
                    Stream s = res.GetResponseStream();
                    StreamReader objReader = new StreamReader(s, Encoding.GetEncoding("gb2312"));
                    retString = objReader.ReadToEnd();
                    objReader.Close();
                }
                else
                {
                    retString = ex.Message;
                }
                return retString;
            }

        }
        #endregion



        private void but_add_Click(object sender, EventArgs e)
        {
            List_classChoiced.Items.Add(richText_POST.Text);
        }

        private void richText_POST_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
}
}