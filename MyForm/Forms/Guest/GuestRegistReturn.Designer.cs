namespace MyForm.Forms
{
    partial class GuestRegistReturn
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
            label1 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtReturnDate = new TextBox();
            btnCommit = new Button();
            btnRefresh = new Button();
            comboBoxLoanBook = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(307, 41);
            label1.Name = "label1";
            label1.Size = new Size(183, 36);
            label1.TabIndex = 0;
            label1.Text = "图书归还登记";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(353, 135);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(268, 39);
            txtUsername.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(228, 292);
            label4.Name = "label4";
            label4.Size = new Size(64, 32);
            label4.TabIndex = 9;
            label4.Text = "书名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(203, 138);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 7;
            label2.Text = "用户名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(178, 213);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 13;
            label3.Text = "应还日期";
            // 
            // txtReturnDate
            // 
            txtReturnDate.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtReturnDate.Location = new Point(353, 213);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.ReadOnly = true;
            txtReturnDate.Size = new Size(268, 39);
            txtReturnDate.TabIndex = 14;
            // 
            // btnCommit
            // 
            btnCommit.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCommit.Location = new Point(465, 364);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(115, 46);
            btnCommit.TabIndex = 16;
            btnCommit.Text = "提交";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(265, 364);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 46);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "刷新";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // comboBoxLoanBook
            // 
            comboBoxLoanBook.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxLoanBook.FormattingEnabled = true;
            comboBoxLoanBook.Location = new Point(353, 289);
            comboBoxLoanBook.Name = "comboBoxLoanBook";
            comboBoxLoanBook.Size = new Size(268, 40);
            comboBoxLoanBook.TabIndex = 19;
            comboBoxLoanBook.SelectedIndexChanged += comboBoxLoanBook_SelectedIndexChanged;
            // 
            // GuestRegistReturn
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxLoanBook);
            Controls.Add(btnRefresh);
            Controls.Add(btnCommit);
            Controls.Add(txtReturnDate);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GuestRegistReturn";
            Text = "图书归还登记";
            Load += GuestRegistReturn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox txtReturnDate;
        private Button btnCommit;
        private Button btnRefresh;
        private ComboBox comboBoxLoanBook;
    }
}