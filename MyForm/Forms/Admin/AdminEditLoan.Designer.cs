namespace MyForm.Forms.Admin
{
    partial class AdminEditLoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            checkBoxAdd = new CheckBox();
            checkBoxEdit = new CheckBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnCommitEdit = new Button();
            txtBookInfo3 = new TextBox();
            txtBookInfo2 = new TextBox();
            txtBookInfo1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnShowAll = new Button();
            txtBookName = new TextBox();
            label2 = new Label();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxAdd);
            groupBox1.Controls.Add(checkBoxEdit);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnCommitEdit);
            groupBox1.Controls.Add(txtBookInfo3);
            groupBox1.Controls.Add(txtBookInfo2);
            groupBox1.Controls.Add(txtBookInfo1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(780, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 436);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "当前选中";
            // 
            // checkBoxAdd
            // 
            checkBoxAdd.AutoSize = true;
            checkBoxAdd.Location = new Point(6, 330);
            checkBoxAdd.Name = "checkBoxAdd";
            checkBoxAdd.Size = new Size(136, 36);
            checkBoxAdd.TabIndex = 25;
            checkBoxAdd.Text = "添加记录";
            checkBoxAdd.UseVisualStyleBackColor = true;
            checkBoxAdd.CheckedChanged += checkBoxAdd_CheckedChanged;
            // 
            // checkBoxEdit
            // 
            checkBoxEdit.AutoSize = true;
            checkBoxEdit.Location = new Point(6, 273);
            checkBoxEdit.Name = "checkBoxEdit";
            checkBoxEdit.Size = new Size(186, 36);
            checkBoxEdit.TabIndex = 23;
            checkBoxEdit.Text = "编辑选中记录";
            checkBoxEdit.UseVisualStyleBackColor = true;
            checkBoxEdit.CheckStateChanged += checkBoxEdit_CheckedChanged;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(213, 330);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 42);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "确认添加";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(213, 388);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 42);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "删除选中";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCommitEdit
            // 
            btnCommitEdit.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCommitEdit.Location = new Point(213, 269);
            btnCommitEdit.Name = "btnCommitEdit";
            btnCommitEdit.Size = new Size(126, 42);
            btnCommitEdit.TabIndex = 17;
            btnCommitEdit.Text = "提交编辑";
            btnCommitEdit.UseVisualStyleBackColor = true;
            btnCommitEdit.Click += btnCommitEdit_Click;
            // 
            // txtBookInfo3
            // 
            txtBookInfo3.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookInfo3.Location = new Point(155, 147);
            txtBookInfo3.Name = "txtBookInfo3";
            txtBookInfo3.ReadOnly = true;
            txtBookInfo3.Size = new Size(197, 37);
            txtBookInfo3.TabIndex = 19;
            // 
            // txtBookInfo2
            // 
            txtBookInfo2.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookInfo2.Location = new Point(155, 97);
            txtBookInfo2.Name = "txtBookInfo2";
            txtBookInfo2.ReadOnly = true;
            txtBookInfo2.Size = new Size(197, 37);
            txtBookInfo2.TabIndex = 18;
            // 
            // txtBookInfo1
            // 
            txtBookInfo1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookInfo1.Location = new Point(155, 47);
            txtBookInfo1.Name = "txtBookInfo1";
            txtBookInfo1.ReadOnly = true;
            txtBookInfo1.Size = new Size(197, 37);
            txtBookInfo1.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(10, 150);
            label5.Name = "label5";
            label5.Size = new Size(105, 30);
            label5.TabIndex = 2;
            label5.Text = "借阅日期";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(10, 100);
            label4.Name = "label4";
            label4.Size = new Size(82, 30);
            label4.TabIndex = 1;
            label4.Text = "借阅人";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(10, 50);
            label3.Name = "label3";
            label3.Size = new Size(59, 30);
            label3.TabIndex = 0;
            label3.Text = "书名";
            // 
            // btnShowAll
            // 
            btnShowAll.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowAll.Location = new Point(578, 56);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(126, 42);
            btnShowAll.TabIndex = 22;
            btnShowAll.Text = "显示所有";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookName.Location = new Point(156, 56);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(217, 42);
            txtBookName.TabIndex = 21;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 32);
            label2.Name = "label2";
            label2.Size = new Size(118, 24);
            label2.TabIndex = 20;
            label2.Text = "（模糊查询）";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(396, 56);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 42);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "查询";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(699, 382);
            dataGridView1.TabIndex = 18;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 56);
            label1.Name = "label1";
            label1.Size = new Size(99, 36);
            label1.TabIndex = 17;
            label1.Text = "书名：";
            // 
            // AdminEditLoan
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 552);
            Controls.Add(groupBox1);
            Controls.Add(btnShowAll);
            Controls.Add(txtBookName);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "AdminEditLoan";
            Text = "图书借阅记录编辑";
            Load += AdminEditLoan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBoxAdd;
        private CheckBox checkBoxEdit;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnCommitEdit;
        private TextBox txtBookInfo3;
        private TextBox txtBookInfo2;
        private TextBox txtBookInfo1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnShowAll;
        private TextBox txtBookName;
        private Label label2;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Label label1;
    }
}