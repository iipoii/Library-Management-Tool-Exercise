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
    public partial class AdminEditLoan : Form
    {
        public AdminEditLoan()
        {
            InitializeComponent();
        }

        int selected_recordID;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search_result = TemporaryDatabase.SearchInTableByCondition("图书借阅记录表", row => row.Field<string>("书名").Contains(txtBookName.Text));
            dataGridView1.DataSource = search_result;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1_Refresh();
        }

        private void AdminEditLoan_Load(object sender, EventArgs e)
        {
            dataGridView1_Refresh();
        }

        private void dataGridView1_Refresh()
        {
            var search_result = TemporaryDatabase.SearchInTableByCondition("图书借阅记录表", row => true);
            dataGridView1.DataSource = search_result;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // 检查是否有选中的行
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 获取第一选中行的数据
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                // 获取选中行的数据
                selected_recordID = (int)selectedRow.Cells[0].Value;
                txtBookInfo1.Text = selectedRow.Cells[1].Value.ToString();
                txtBookInfo2.Text = selectedRow.Cells[2].Value.ToString();
                txtBookInfo3.Text = selectedRow.Cells[3].Value.ToString();
                // 在这里处理选中行的数据
            }
        }
        private void checkBoxEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxEdit.Checked)
            {
                txtBookInfo1.ReadOnly = true;
                txtBookInfo2.ReadOnly = true;
                txtBookInfo3.ReadOnly = true;
            }
            else
            {
                txtBookInfo1.ReadOnly = false;
                txtBookInfo2.ReadOnly = false;
                txtBookInfo3.ReadOnly = false;
                checkBoxAdd.Checked = false;
            }
        }

        private void btnCommitEdit_Click(object sender, EventArgs e)
        {
            // 获取修改后的数据
            string updatedInfo1 = txtBookInfo1.Text;
            string updatedInfo2 = txtBookInfo2.Text;
            string updatedInfo3 = txtBookInfo3.Text;
            if (selected_recordID > 0 && checkBoxEdit.Checked)
            {
                TemporaryDatabase.UpdateRow("图书借阅记录表", row => row.Field<int>("ID") == selected_recordID,
                                                      row =>
                                                      {
                                                          row["书名"] = updatedInfo1;
                                                          row["借阅人"] = updatedInfo2;
                                                          row["借阅日期"] = updatedInfo3;
                                                      });
                MessageBox.Show("更新成功");
                dataGridView1_Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selected_recordID > 0)
            {
                TemporaryDatabase.DeleteRow("图书借阅记录表", row => row.Field<int>("ID") == selected_recordID);
                MessageBox.Show("删除成功");
                dataGridView1_Refresh();
            }
        }

        private void checkBoxAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxAdd.Checked)
            {
                txtBookInfo1.ReadOnly = true;
                txtBookInfo2.ReadOnly = true;
                txtBookInfo3.ReadOnly = true;
            }
            else
            {
                txtBookInfo1.ReadOnly = false;
                txtBookInfo2.ReadOnly = false;
                txtBookInfo3.ReadOnly = false;
                txtBookInfo1.Text = string.Empty;
                txtBookInfo2.Text = string.Empty;
                txtBookInfo3.Text = string.Empty;
                selected_recordID = 0;
                checkBoxEdit.Checked = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string updatedInfo1 = txtBookInfo1.Text;
            string updatedInfo2 = txtBookInfo2.Text;
            string updatedInfo3 = txtBookInfo3.Text;
            if (checkBoxAdd.Checked)
            {
                TemporaryDatabase.AddRow("图书借阅记录表", updatedInfo1, updatedInfo2, updatedInfo3);
                MessageBox.Show("添加成功");
                dataGridView1_Refresh();
            }
        }
    }
}
