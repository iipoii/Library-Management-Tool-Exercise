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

namespace MyForm.Forms.Guest
{
    public partial class GuestChgPSW : Form
    {
        public GuestChgPSW()
        {
            InitializeComponent();
        }

        private void GuestChgPSW_Load(object sender, EventArgs e)
        {
            GuestMdiContainer parent = this.MdiParent as GuestMdiContainer;
            if (parent != null)
            {
                txtUsername.Text = parent.Username;
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != string.Empty)
            {
                try
                {
                    TemporaryDatabase.UpdateRow("账号表", row => row.Field<string>("username") == txtUsername.Text
                                                            && row.Field<string>("password") == txtPassword.Text,
                                                            row => { row.SetField("password", txtNewPassword.Text); }
                                                            );
                    MessageBox.Show("修改成功");
                }
                catch(ArgumentNullException) 
                {
                    MessageBox.Show("用户名或密码错误");
                }
            }
            else 
            {
                MessageBox.Show("密码不能为空");
            }
        }
    }
}
