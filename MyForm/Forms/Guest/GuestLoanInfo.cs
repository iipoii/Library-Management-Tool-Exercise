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

namespace MyForm.Forms
{
    public partial class GuestLoanInfo : Form
    {
        public GuestLoanInfo()
        {
            InitializeComponent();
        }

        private void GuestLoanInfo_Load(object sender, EventArgs e)
        {
            DataGridViewRefrsh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataGridViewRefrsh();
        }

        private void DataGridViewRefrsh()
        {
            GuestMdiContainer parent = this.MdiParent as GuestMdiContainer;
            if (parent != null)
            {
                string username = parent.Username; // 子窗口访问父窗口的数据
                dataGridView1.DataSource = TemporaryDatabase.SearchInTableByCondition("图书借阅记录表", row => row.Field<string>("借阅人") == username);
            }
        }
    }
}
