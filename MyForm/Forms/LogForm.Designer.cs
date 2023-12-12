namespace MyForm
{
    partial class LogForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegist = new Button();
            btnLog = new Button();
            checkBoxTest = new CheckBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(184, 61);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(427, 48);
            label1.TabIndex = 0;
            label1.Text = "欢迎使用本图书管理工具";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(160, 142);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 36);
            label2.TabIndex = 1;
            label2.Text = "用户名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(184, 242);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 36);
            label3.TabIndex = 2;
            label3.Text = "密码";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(310, 142);
            txtUsername.Margin = new Padding(5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(326, 42);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "guestUser";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(310, 242);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(326, 42);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "guestPWD";
            // 
            // btnRegist
            // 
            btnRegist.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegist.Location = new Point(211, 343);
            btnRegist.Margin = new Padding(5);
            btnRegist.Name = "btnRegist";
            btnRegist.Size = new Size(133, 51);
            btnRegist.TabIndex = 5;
            btnRegist.Text = "注册";
            btnRegist.UseVisualStyleBackColor = true;
            btnRegist.Click += btnRegist_Click;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLog.Location = new Point(455, 343);
            btnLog.Margin = new Padding(5);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(133, 51);
            btnLog.TabIndex = 6;
            btnLog.Text = "登录";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // checkBoxTest
            // 
            checkBoxTest.AutoSize = true;
            checkBoxTest.Checked = true;
            checkBoxTest.CheckState = CheckState.Checked;
            checkBoxTest.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTest.Location = new Point(27, 12);
            checkBoxTest.Name = "checkBoxTest";
            checkBoxTest.Size = new Size(127, 34);
            checkBoxTest.TabIndex = 7;
            checkBoxTest.Text = "测试模式";
            checkBoxTest.UseVisualStyleBackColor = true;
            checkBoxTest.CheckedChanged += checkBoxTest_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(160, 18);
            label4.Name = "label4";
            label4.Size = new Size(568, 24);
            label4.TabIndex = 8;
            label4.Text = "（测试模式下将不会连接到数据库，而是使用本地创建的测试数据库）";
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(16F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 433);
            Controls.Add(label4);
            Controls.Add(checkBoxTest);
            Controls.Add(btnLog);
            Controls.Add(btnRegist);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "LogForm";
            Text = "登录";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegist;
        private Button btnLog;
        private CheckBox checkBoxTest;
        private Label label4;
    }
}