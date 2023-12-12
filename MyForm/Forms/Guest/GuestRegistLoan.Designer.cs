namespace MyForm.Forms
{
    partial class GuestRegistLoan
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtLoanTime = new TextBox();
            txtBookname = new TextBox();
            btnRefresh = new Button();
            btnCommit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(287, 36);
            label1.Name = "label1";
            label1.Size = new Size(183, 36);
            label1.TabIndex = 0;
            label1.Text = "图书借阅登记";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(190, 135);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 1;
            label2.Text = "用户名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(165, 212);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 2;
            label3.Text = "借阅时间";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(215, 285);
            label4.Name = "label4";
            label4.Size = new Size(64, 32);
            label4.TabIndex = 3;
            label4.Text = "书名";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(340, 132);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(268, 39);
            txtUsername.TabIndex = 4;
            // 
            // txtLoanTime
            // 
            txtLoanTime.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoanTime.Location = new Point(340, 209);
            txtLoanTime.Name = "txtLoanTime";
            txtLoanTime.ReadOnly = true;
            txtLoanTime.Size = new Size(268, 39);
            txtLoanTime.TabIndex = 5;
            // 
            // txtBookname
            // 
            txtBookname.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookname.Location = new Point(340, 282);
            txtBookname.Name = "txtBookname";
            txtBookname.Size = new Size(268, 39);
            txtBookname.TabIndex = 6;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(208, 376);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 46);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "刷新";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCommit
            // 
            btnCommit.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCommit.Location = new Point(479, 376);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(115, 46);
            btnCommit.TabIndex = 8;
            btnCommit.Text = "提交";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // GuestRegistLoan
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCommit);
            Controls.Add(btnRefresh);
            Controls.Add(txtBookname);
            Controls.Add(txtLoanTime);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GuestRegistLoan";
            Text = "图书借阅登记";
            Load += GuestRegistLoan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtLoanTime;
        private TextBox txtBookname;
        private Button btnRefresh;
        private Button btnCommit;
    }
}