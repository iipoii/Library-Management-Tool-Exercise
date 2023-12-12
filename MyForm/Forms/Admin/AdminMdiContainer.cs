using MyForm.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm.Forms.Admin
{
    public partial class AdminMdiContainer : Form
    {
        public AdminMdiContainer()
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
   
        }

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

        private void ToolStripMenuItemEditBookInfo_Click(object sender, EventArgs e)
        {
            OpenMdiChildForm(new AdminEditBook());
        }

        private void ToolStripMenuItemEditLoan_Click(object sender, EventArgs e)
        {
            OpenMdiChildForm(new AdminEditLoan());
        }
    }
}
