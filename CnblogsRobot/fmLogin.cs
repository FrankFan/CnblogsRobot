using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPwd.Text.Trim();

            Login.LoginCnblogs(username, password);
            
        }

        
    }
}
