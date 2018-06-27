namespace _20180607ExtendableApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snapInModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadsnapins = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file2ToolStripMenuItem
            // 
            this.file2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snapInModuleToolStripMenuItem});
            this.file2ToolStripMenuItem.Name = "file2ToolStripMenuItem";
            this.file2ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.file2ToolStripMenuItem.Text = "file2";
            // 
            // snapInModuleToolStripMenuItem
            // 
            this.snapInModuleToolStripMenuItem.Name = "snapInModuleToolStripMenuItem";
            this.snapInModuleToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.snapInModuleToolStripMenuItem.Text = "snap in module!!";
            this.snapInModuleToolStripMenuItem.Click += new System.EventHandler(this.snapInModuleToolStripMenuItem_Click);
            // 
            // loadsnapins
            // 
            this.loadsnapins.FormattingEnabled = true;
            this.loadsnapins.ItemHeight = 12;
            this.loadsnapins.Location = new System.Drawing.Point(12, 76);
            this.loadsnapins.Name = "loadsnapins";
            this.loadsnapins.Size = new System.Drawing.Size(260, 172);
            this.loadsnapins.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.loadsnapins);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snapInModuleToolStripMenuItem;
        private System.Windows.Forms.ListBox loadsnapins;
    }
}

