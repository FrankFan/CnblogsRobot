using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace CnblogsRobot
{
    /*
     * 功能点
     * 1. 模拟登录
     *    - Login.cs 登录逻辑代码
     *    
     * 2. 上传图片，获取外链图片url
     *    - ImageUploader.cs 上传图片逻辑代码
     *    
     * 3. 发闪存客户端（可以发送，可以获取）
     *    - shan.cs  闪存逻辑代码
     */
    public partial class fmLogin : Form
    {
        public string homeHtml = string.Empty;
        public CookieContainer cc = new CookieContainer();

        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPwd.Text.Trim();

            homeHtml = Login.LoginCnblogs(username, password);

            cc = Login.cc; 

            if (homeHtml.IndexOf("<title>首页 - 我的园子 - 博客园</title>") >= 0)
            {
                //MessageBox.Show("登陆成功", this.Text);
                //this.Close();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("登陆失败", this.Text);
            }
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
