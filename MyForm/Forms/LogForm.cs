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
            // ���ı����ȡ�˺�����
            string got_username = txtUsername.Text;
            string got_password = txtPassword.Text;
            if (TemporaryDatabase.test_mode)
            {
                TemporaryDatabase.CreateTestTableAccount();
            }
            else
            {
                TemporaryDatabase.GetTable("�˺ű�");
            }
            // �ӱ��м�������
            DataTable search_result = TemporaryDatabase.SearchInTableByCondition("�˺ű�", row => row.Field<string>("username") == got_username
                                                                                                && row.Field<string>("password") == got_password);
            // �������˺�
            if (search_result != null && search_result.Rows.Count > 0)
            {
                // �����˺ű��uniqueԼ�������ؽ����ֻ��һ�����ݵı�
                DataRow row = search_result.Rows[0];
                string user_type = row["type"].ToString().Trim();

                if (user_type == "admin")
                {
                    MessageBox.Show("����Ա��¼�ɹ�");
                    AdminMdiContainer admin_form = new AdminMdiContainer();
                    this.Hide();
                    admin_form.ShowDialog();
                    this.Close();
                }
                else if (user_type == "guest")
                {
                    MessageBox.Show("�ο͵�½�ɹ�");
                    GuestMdiContainer guest_form = new GuestMdiContainer(got_username);
                    this.Hide();
                    guest_form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("δ֪���˺ŷ��࣬����ϵ����Ա");
                }
            }
            else
            // δ�������˺�
            {
                MessageBox.Show("�˺Ż��������");
            }

        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            // ��һ���µ�ע�ᴰ��
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