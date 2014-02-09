using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Script.Serialization;//System.Web.Extensions添加dll引用

namespace CnblogsRobot
{
    public partial class fmIng : Form
    {

        public fmIng()
        {
            InitializeComponent();
        }

        private void fmIng_Load(object sender, EventArgs e)
        {
            HttpHeader header = new HttpHeader();
            header.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            header.ContentType = "application/x-www-form-urlencoded";
            header.Method = "POST";
            header.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36";
            header.MaxTry = 300;

            //登录
            fmLogin login = new fmLogin();
            login.ShowDialog();

            //获取最近一条说说,=后面的参数是时间戳
            string lastIngUrl = "http://home.cnblogs.com/ajax/ing/MyLastIng?_=1391921465936";
            string lastIngContent = HttpHelper.GetHtml(lastIngUrl, login.cc, header);

            //获取主页的html
            string html = login.homeHtml;


            //获取头像url
            string avatarUrl = "http://home.cnblogs.com/user/CurrentIngUserInfo";
            string str = HttpHelper.HttpPost(avatarUrl, "", login.cc);
            //序列化注意：需要引用System.Web.Extensions
            JavaScriptSerializer jss = new JavaScriptSerializer();
            UserInfo user = jss.Deserialize<UserInfo>(str);

            this.pictureBox1.ImageLocation = user.AvatarUrl;
            this.lblUserName.Text = user.UserName;




            //获取园龄

            //获取粉丝数

            //获取星星


        }

        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case 0x0112:
        //            if (((int)m.WParam) == 61536)
        //            {
        //                DialogResult result = MessageBox.Show("确定退出系统吗?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        //                if (result == DialogResult.OK)
        //                {
        //                    Application.Exit();
        //                }
        //                else
        //                {
        //                    base.WndProc(ref m);
        //                }
        //            }
        //            break;

        //        default:
        //            base.WndProc(ref m);
        //            break;
        //    }
        //}
    }
}
