namespace MyForm.Forms.Guest
{
    partial class GuestSearchBook
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
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtBookName = new TextBox();
            btnShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(404, 81);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 42);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "查询";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(636, 264);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 81);
            label1.Name = "label1";
            label1.Size = new Size(99, 36);
            label1.TabIndex = 3;
            label1.Text = "书名：";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 57);
            label2.Name = "label2";
            label2.Size = new Size(118, 24);
            label2.TabIndex = 6;
            label2.Text = "（模糊查询）";
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookName.Location = new Point(164, 81);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(217, 42);
            txtBookName.TabIndex = 7;
            // 
            // btnShowAll
            // 
            btnShowAll.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowAll.Location = new Point(648, 81);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(126, 42);
            btnShowAll.TabIndex = 8;
            btnShowAll.Text = "显示所有";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // GuestSearchBook
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowAll);
            Controls.Add(txtBookName);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "GuestSearchBook";
            Text = "查询图书";
            Load += GuestSearchBook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtBookName;
        private Button btnShowAll;
    }
}