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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyForm.Forms
{
    // 图书归还窗口
    public partial class GuestRegistReturn : Form
    {
        public GuestRegistReturn()
        {
            InitializeComponent();
        }

        DataTable search_result;
        private string username;

        // 窗口中采用一个组合框（comboBox）显示当前用户借阅的所有图书
        private void comboBoxLoanBookRefresh()
        {
            // 刷新组合框中的图书
            comboBoxLoanBook.Items.Clear();
            search_result = TemporaryDatabase.SearchInTableByCondition("图书借阅记录表", row => row.Field<string>("借阅人") == username);
            foreach (DataRow row in search_result.Rows)
            {
                comboBoxLoanBook.Items.Add(row["书名"]);
            }

        }

        private void GuestRegistReturn_Load(object sender, EventArgs e)
        {
            // 从MDI父窗口中读取属性Username
            GuestMdiContainer parent = this.MdiParent as GuestMdiContainer;
            if (parent != null)
            {
                username = parent.Username;
            }
            txtUsername.Text = username;
            comboBoxLoanBookRefresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            comboBoxLoanBookRefresh();
        }

        // 当选中组合框中的另一本图书时，触发该事件，更新图书的应归还时间
        private void comboBoxLoanBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_bookname = comboBoxLoanBook.Text;
            // 使用选中的书名来查找对应的借书时间
            DataRow selectedRow = search_result.AsEnumerable().FirstOrDefault(row => row.Field<string>("书名") == selected_bookname);
            if (selectedRow != null)
            {
                // 使用borrowDate来访问选中书名对应的借书时间, 应还时间为借书时间后的30天以内
                string borrowDate = selectedRow.Field<string>("借阅日期");
                DateTime returnDate = Convert.ToDateTime(borrowDate).AddDays(30);
                txtReturnDate.Text = returnDate.ToString();
            }
            else
            {
                // 未找到匹配的行
                MessageBox.Show("您没有借阅该书");
            }
        }

        // 归还选定的图书并提交相关信息
        private void btnCommit_Click(object sender, EventArgs e)
        {
            string selected_bookname = comboBoxLoanBook.Text;
            if (comboBoxLoanBook.SelectedIndex >= 0)    // 选中有效行
            {
                // 在数据库中删除数据，并更新控件
                TemporaryDatabase.DeleteRow("图书借阅记录表", row =>row.Field<string>("借阅人") == username
                                                             && row.Field<string>("书名") == selected_bookname);
                MessageBox.Show("还书成功");
                txtReturnDate.Text = "";
                comboBoxLoanBook.Text = "";
                comboBoxLoanBookRefresh();
            }
            else
            {
                MessageBox.Show("请选择想要归还的书");
            }
        }


    }
}
