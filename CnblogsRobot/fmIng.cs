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
            fmLogin fl = new fmLogin();
            fl.ShowDialog();
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
