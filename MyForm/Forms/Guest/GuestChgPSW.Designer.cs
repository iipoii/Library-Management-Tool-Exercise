namespace MyForm.Forms.Guest
{
    partial class GuestChgPSW
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
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtNewPassword = new TextBox();
            btnCommit = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(326, 182);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(326, 42);
            txtPassword.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(326, 82);
            txtUsername.Margin = new Padding(5);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(326, 42);
            txtUsername.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(200, 182);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 36);
            label2.TabIndex = 6;
            label2.Text = "密码";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(176, 82);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 36);
            label1.TabIndex = 5;
            label1.Text = "用户名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(172, 277);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 36);
            label3.TabIndex = 9;
            label3.Text = "新密码";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPassword.Location = new Point(326, 277);
            txtNewPassword.Margin = new Padding(5);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(326, 42);
            txtNewPassword.TabIndex = 10;
            // 
            // btnCommit
            // 
            btnCommit.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCommit.Location = new Point(339, 359);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(115, 46);
            btnCommit.TabIndex = 17;
            btnCommit.Text = "提交";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // GuestChgPSW
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCommit);
            Controls.Add(txtNewPassword);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GuestChgPSW";
            Text = "修改密码";
            Load += GuestChgPSW_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtNewPassword;
        private Button btnCommit;
    }
}