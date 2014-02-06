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
    public partial class fmIng : Form
    {
        public fmIng()
        {
            InitializeComponent();
        }

        private void fmIng_Load(object sender, EventArgs e)
        {
            //登录
            fmLogin login = new fmLogin();
            login.ShowDialog();

            //获取主页的html
            string html = login.homeHtml;

            //获取头像url

            //获取最近一条说说

            //获取园龄

            //获取粉丝数

            //获取星星


        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0112:
                    if (((int)m.WParam) == 61536)
                    {
                        DialogResult result = MessageBox.Show("确定退出系统吗?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.OK)
                        {
                            Application.Exit();
                        }
                        else
                        {
                            base.WndProc(ref m);
                        }
                    }
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }
    }
}
