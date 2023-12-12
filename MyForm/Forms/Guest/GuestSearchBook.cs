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
    public partial class GuestSearchBook : Form
    {
        public GuestSearchBook()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search_result = TemporaryDatabase.SearchInTableByCondition("图书表", row => row.Field<string>("书名").Contains(txtBookName.Text));
            dataGridView1.DataSource = search_result;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            var search_result = TemporaryDatabase.SearchInTableByCondition("图书表", row => true);
            dataGridView1.DataSource = search_result;
        }

        private void GuestSearchBook_Load(object sender, EventArgs e)
        {
            var search_result = TemporaryDatabase.SearchInTableByCondition("图书表", row => true);
            dataGridView1.DataSource = search_result;
        }
    }
}
