using MyForm.Class;
using MyForm.Forms.Guest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm.Forms
{
    // 此窗口为客户MDI窗口的父容器
    public partial class GuestMdiContainer : Form
    {
        public GuestMdiContainer(string username)
        {
            InitializeComponent();
            if (TemporaryDatabase.test_mode)
            {
                TemporaryDatabase.CreateTestTableGuestInfo();
                TemporaryDatabase.CreateTestTableBook();
            }
            else
            {
                TemporaryDatabase.GetTable("图书借阅记录表");
                TemporaryDatabase.GetTable("图书表");
            }
            this.Username = username;
        }

        // 通过实例化时传递的参数，设置属性Username，以便于获取用户信息
        public string Username { get; private set; }

        private void OpenMdiChildForm(Form childForm)
        {
            // 遍历所有MDI子窗体
            foreach (Form openForm in this.MdiChildren)
            {
                if (openForm.GetType() == childForm.GetType())
                {
                    // 如果窗体已存在，将其激活并返回
                    openForm.Activate();
                    return;
                }
            }

            // 如果窗体不存在，设置父窗体并显示
            childForm.MdiParent = this;
            childForm.Show();
        }


        // 打开MDI子窗口
        private void ToolStripMenuItemLoanInfo_Click(object sender, EventArgs e)
        {
            OpenMdiChildForm(new GuestLoanInfo());
        }

        private void ToolStripMenuItemRegistLoan_Click(object sender, EventArgs e)
        {
            OpenMdiChildForm(new GuestRegistLoan());
        }

        private void ToolStripMenuItemRegistReturn_Click(object sender, EventArgs e)
        {
            OpenMdiChildForm(new GuestRegistReturn());
        }

        private void ToolStripMenuItemChgPWD_Click(object sender, EventArgs e)
        {
            OpenMdiChildForm(new GuestChgPSW());
        }

        private void ToolStripMenuItemSearchBook_Click(object sender, EventArgs e)
        {
            OpenMdiChildForm(new GuestSearchBook());
        }
    }
}
