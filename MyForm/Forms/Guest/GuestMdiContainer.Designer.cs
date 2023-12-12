namespace MyForm.Forms
{
    partial class GuestMdiContainer
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
            menuStripMain = new MenuStrip();
            ToolStripMenuItemLoanInfo = new ToolStripMenuItem();
            ToolStripMenuItemRegistLoan = new ToolStripMenuItem();
            ToolStripMenuItemRegistReturn = new ToolStripMenuItem();
            ToolStripMenuItemMore = new ToolStripMenuItem();
            ToolStripMenuItemSearchBook = new ToolStripMenuItem();
            ToolStripMenuItemChgPWD = new ToolStripMenuItem();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemLoanInfo, ToolStripMenuItemRegistLoan, ToolStripMenuItemRegistReturn, ToolStripMenuItemMore });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(800, 28);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            // 
            // ToolStripMenuItemLoanInfo
            // 
            ToolStripMenuItemLoanInfo.Name = "ToolStripMenuItemLoanInfo";
            ToolStripMenuItemLoanInfo.Size = new Size(83, 24);
            ToolStripMenuItemLoanInfo.Text = "我的借阅";
            ToolStripMenuItemLoanInfo.Click += ToolStripMenuItemLoanInfo_Click;
            // 
            // ToolStripMenuItemRegistLoan
            // 
            ToolStripMenuItemRegistLoan.Name = "ToolStripMenuItemRegistLoan";
            ToolStripMenuItemRegistLoan.Size = new Size(113, 24);
            ToolStripMenuItemRegistLoan.Text = "登记图书借阅";
            ToolStripMenuItemRegistLoan.Click += ToolStripMenuItemRegistLoan_Click;
            // 
            // ToolStripMenuItemRegistReturn
            // 
            ToolStripMenuItemRegistReturn.Name = "ToolStripMenuItemRegistReturn";
            ToolStripMenuItemRegistReturn.Size = new Size(113, 24);
            ToolStripMenuItemRegistReturn.Text = "登记图书归还";
            ToolStripMenuItemRegistReturn.Click += ToolStripMenuItemRegistReturn_Click;
            // 
            // ToolStripMenuItemMore
            // 
            ToolStripMenuItemMore.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemSearchBook, ToolStripMenuItemChgPWD });
            ToolStripMenuItemMore.Name = "ToolStripMenuItemMore";
            ToolStripMenuItemMore.Size = new Size(75, 24);
            ToolStripMenuItemMore.Text = "更多>>";
            // 
            // ToolStripMenuItemSearchBook
            // 
            ToolStripMenuItemSearchBook.Name = "ToolStripMenuItemSearchBook";
            ToolStripMenuItemSearchBook.Size = new Size(224, 26);
            ToolStripMenuItemSearchBook.Text = "查询图书";
            ToolStripMenuItemSearchBook.Click += ToolStripMenuItemSearchBook_Click;
            // 
            // ToolStripMenuItemChgPWD
            // 
            ToolStripMenuItemChgPWD.Name = "ToolStripMenuItemChgPWD";
            ToolStripMenuItemChgPWD.Size = new Size(224, 26);
            ToolStripMenuItemChgPWD.Text = "修改密码";
            ToolStripMenuItemChgPWD.Click += ToolStripMenuItemChgPWD_Click;
            // 
            // GuestMdiContainer
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStripMain);
            IsMdiContainer = true;
            MainMenuStrip = menuStripMain;
            Name = "GuestMdiContainer";
            Text = "游客界面";
            WindowState = FormWindowState.Maximized;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem ToolStripMenuItemLoanInfo;
        private ToolStripMenuItem ToolStripMenuItemRegistLoan;
        private ToolStripMenuItem ToolStripMenuItemRegistReturn;
        private ToolStripMenuItem ToolStripMenuItemMore;
        private ToolStripMenuItem ToolStripMenuItemChgPWD;
        private ToolStripMenuItem ToolStripMenuItemSearchBook;
    }
}