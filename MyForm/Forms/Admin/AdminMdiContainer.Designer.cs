namespace MyForm.Forms.Admin
{
    partial class AdminMdiContainer
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
            ToolStripMenuItemEditBookInfo = new ToolStripMenuItem();
            ToolStripMenuItemEditLoan = new ToolStripMenuItem();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemEditBookInfo, ToolStripMenuItemEditLoan });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(1233, 28);
            menuStripMain.TabIndex = 1;
            menuStripMain.Text = "menuStrip1";
            // 
            // ToolStripMenuItemEditBookInfo
            // 
            ToolStripMenuItemEditBookInfo.Name = "ToolStripMenuItemEditBookInfo";
            ToolStripMenuItemEditBookInfo.Size = new Size(83, 24);
            ToolStripMenuItemEditBookInfo.Text = "图书编辑";
            ToolStripMenuItemEditBookInfo.Click += ToolStripMenuItemEditBookInfo_Click;
            // 
            // ToolStripMenuItemEditLoan
            // 
            ToolStripMenuItemEditLoan.Name = "ToolStripMenuItemEditLoan";
            ToolStripMenuItemEditLoan.Size = new Size(113, 24);
            ToolStripMenuItemEditLoan.Text = "借阅记录编辑";
            ToolStripMenuItemEditLoan.Click += ToolStripMenuItemEditLoan_Click;
            // 
            // AdminMdiContainer
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 621);
            Controls.Add(menuStripMain);
            IsMdiContainer = true;
            Name = "AdminMdiContainer";
            Text = "管理员界面";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem ToolStripMenuItemEditBookInfo;
        private ToolStripMenuItem ToolStripMenuItemEditLoan;
    }
}