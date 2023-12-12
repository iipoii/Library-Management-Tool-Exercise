namespace MyForm
{
    partial class RegistForm
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
            components = new System.ComponentModel.Container();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtCaptcha = new TextBox();
            btnRegistConfirm = new Button();
            btnGetCaptcha = new Button();
            label1 = new Label();
            txtEmail = new TextBox();
            timerCaptchaGap = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            checkBoxTest = new CheckBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(339, 228);
            txtPassword.Margin = new Padding(9);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(337, 42);
            txtPassword.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(339, 146);
            txtUsername.Margin = new Padding(9);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(337, 42);
            txtUsername.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(219, 228);
            label3.Margin = new Padding(9, 0, 9, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 36);
            label3.TabIndex = 6;
            label3.Text = "密码";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(191, 146);
            label2.Margin = new Padding(9, 0, 9, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 36);
            label2.TabIndex = 5;
            label2.Text = "用户名";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 310);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 36);
            label4.TabIndex = 9;
            label4.Text = "验证码";
            // 
            // txtCaptcha
            // 
            txtCaptcha.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCaptcha.Location = new Point(339, 304);
            txtCaptcha.Margin = new Padding(9);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.Size = new Size(222, 42);
            txtCaptcha.TabIndex = 10;
            // 
            // btnRegistConfirm
            // 
            btnRegistConfirm.Location = new Point(387, 390);
            btnRegistConfirm.Name = "btnRegistConfirm";
            btnRegistConfirm.Size = new Size(151, 51);
            btnRegistConfirm.TabIndex = 11;
            btnRegistConfirm.Text = "确认注册";
            btnRegistConfirm.UseVisualStyleBackColor = true;
            btnRegistConfirm.Click += btnRegistConfirm_Click;
            // 
            // btnGetCaptcha
            // 
            btnGetCaptcha.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGetCaptcha.Location = new Point(556, 304);
            btnGetCaptcha.Name = "btnGetCaptcha";
            btnGetCaptcha.Size = new Size(120, 42);
            btnGetCaptcha.TabIndex = 12;
            btnGetCaptcha.Text = "获取验证码";
            btnGetCaptcha.UseVisualStyleBackColor = true;
            btnGetCaptcha.Click += btnGetCaptcha_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 74);
            label1.Name = "label1";
            label1.Size = new Size(71, 36);
            label1.TabIndex = 13;
            label1.Text = "邮箱";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(339, 74);
            txtEmail.Margin = new Padding(9);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(337, 42);
            txtEmail.TabIndex = 14;
            // 
            // timerCaptchaGap
            // 
            timerCaptchaGap.Interval = 1000;
            timerCaptchaGap.Tick += timerCaptchaGap_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(228, 18);
            label5.Name = "label5";
            label5.Size = new Size(568, 24);
            label5.TabIndex = 16;
            label5.Text = "（测试模式下将不会连接到数据库，而是使用本地创建的测试数据库）";
            // 
            // checkBoxTest
            // 
            checkBoxTest.AutoSize = true;
            checkBoxTest.Checked = true;
            checkBoxTest.CheckState = CheckState.Checked;
            checkBoxTest.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTest.Location = new Point(95, 12);
            checkBoxTest.Name = "checkBoxTest";
            checkBoxTest.Size = new Size(127, 34);
            checkBoxTest.TabIndex = 15;
            checkBoxTest.Text = "测试模式";
            checkBoxTest.UseVisualStyleBackColor = true;
            checkBoxTest.CheckedChanged += checkBoxTest_CheckedChanged;
            // 
            // RegistForm
            // 
            AutoScaleDimensions = new SizeF(16F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 459);
            Controls.Add(label5);
            Controls.Add(checkBoxTest);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(btnGetCaptcha);
            Controls.Add(btnRegistConfirm);
            Controls.Add(txtCaptcha);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "RegistForm";
            Text = "注册";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtCaptcha;
        private Button btnRegistConfirm;
        private Button btnGetCaptcha;
        private Label label1;
        private TextBox txtEmail;
        private System.Windows.Forms.Timer timerCaptchaGap;
        private Label label5;
        private CheckBox checkBoxTest;
    }
}