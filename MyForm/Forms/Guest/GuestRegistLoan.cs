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
    public partial class GuestRegistLoan : Form
    {
        public GuestRegistLoan()
        {
            InitializeComponent();
        }

        private void GuestRegistLoan_Load(object sender, EventArgs e)
        {
            GuestMdiContainer parent = this.MdiParent as GuestMdiContainer;
            if (parent != null)
            {
                txtUsername.Text = parent.Username; // 访问MDI父窗口的属性
                txtLoanTime.Text = DateTime.Now.ToString();
            }
        }

        // 该刷新功能比较简单，只是刷新时间而已
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtLoanTime.Text = DateTime.Now.ToString();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            // 读取输入数据
            string bookname = txtBookname.Text;
            string username = txtUsername.Text;
            string time = txtLoanTime.Text;
            // 更新时间
            txtLoanTime.Text = DateTime.Now.ToString();
            // 向图书借阅记录表添加数据
            if (string.IsNullOrEmpty(bookname))
            {
                MessageBox.Show("请输入书名");
            }
            else
            {
                var search_book = TemporaryDatabase.SearchInTableByCondition("图书表", row => row.Field<string>("书名") == txtBookname.Text);
                var search_loan = TemporaryDatabase.SearchInTableByCondition("图书借阅记录表", row => row.Field<string>("书名") == txtBookname.Text);
                if (search_book.Rows.Count == 0)
                {
                    MessageBox.Show("该图书尚未上架");
                }
                else if (search_loan.Rows.Count > 0)
                {
                    MessageBox.Show("该图书已被借阅");
                }
                else
                {
                    try
                    {
                        TemporaryDatabase.AddRow("图书借阅记录表", bookname, username, time);
                        MessageBox.Show("借阅成功");
                    }
                    catch (ConstraintException)
                    {
                        MessageBox.Show("请勿重复借阅");
                    }
                }
            }
        }

    }
    }
