using MyForm.Class;
using MyForm.Forms;
using MyForm.Forms.Admin;
using System.Data;

namespace MyForm
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            TemporaryDatabase.dataSet.Clear();
            InitializeComponent();
        }


        private void btnLog_Click(object sender, EventArgs e)
        {
            // 从文本框获取账号密码
            string got_username = txtUsername.Text;
            string got_password = txtPassword.Text;
            if (TemporaryDatabase.test_mode)
            {
                TemporaryDatabase.CreateTestTableAccount();
            }
            else
            {
                TemporaryDatabase.GetTable("账号表");
            }
            // 从表中检索数据
            DataTable search_result = TemporaryDatabase.SearchInTableByCondition("账号表", row => row.Field<string>("username") == got_username
                                                                                                && row.Field<string>("password") == got_password);
            // 检索到账号
            if (search_result != null && search_result.Rows.Count > 0)
            {
                // 由于账号表的unique约束，返回结果是只有一行数据的表
                DataRow row = search_result.Rows[0];
                string user_type = row["type"].ToString().Trim();

                if (user_type == "admin")
                {
                    MessageBox.Show("管理员登录成功");
                    AdminMdiContainer admin_form = new AdminMdiContainer();
                    this.Hide();
                    admin_form.ShowDialog();
                    this.Close();
                }
                else if (user_type == "guest")
                {
                    MessageBox.Show("游客登陆成功");
                    GuestMdiContainer guest_form = new GuestMdiContainer(got_username);
                    this.Hide();
                    guest_form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("未知的账号分类，请联系管理员");
                }
            }
            else
            // 未检索到账号
            {
                MessageBox.Show("账号或密码错误");
            }

        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            // 打开一个新的注册窗口
            RegistForm regist_Form = new RegistForm();
            regist_Form.Show();
        }

        private void checkBoxTest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTest.Checked)
            {
                TemporaryDatabase.test_mode = true;
            }
            else
            {
                TemporaryDatabase.test_mode = false;
            }
        }
    }
}