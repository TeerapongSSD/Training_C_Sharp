namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fizzBuzzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testForCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lambdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.basicCToolStripMenuItem,
            this.advancedCToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fizzBuzzToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.lambdaToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // fizzBuzzToolStripMenuItem
            // 
            this.fizzBuzzToolStripMenuItem.Name = "fizzBuzzToolStripMenuItem";
            this.fizzBuzzToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fizzBuzzToolStripMenuItem.Text = "FizzBuzz";
            this.fizzBuzzToolStripMenuItem.Click += new System.EventHandler(this.fizzBuzzToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // basicCToolStripMenuItem
            // 
            this.basicCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.basicCToolStripMenuItem.Name = "basicCToolStripMenuItem";
            this.basicCToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.basicCToolStripMenuItem.Text = "Connect Database";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.searchToolStripMenuItem.Text = "Search By Linq And Add Edit Delete";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // advancedCToolStripMenuItem
            // 
            this.advancedCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testForCToolStripMenuItem});
            this.advancedCToolStripMenuItem.Name = "advancedCToolStripMenuItem";
            this.advancedCToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.advancedCToolStripMenuItem.Text = "Basic C#";
            // 
            // testForCToolStripMenuItem
            // 
            this.testForCToolStripMenuItem.Name = "testForCToolStripMenuItem";
            this.testForCToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.testForCToolStripMenuItem.Text = "Test for C#";
            this.testForCToolStripMenuItem.Click += new System.EventHandler(this.testForCToolStripMenuItem_Click);
            // 
            // lambdaToolStripMenuItem
            // 
            this.lambdaToolStripMenuItem.Name = "lambdaToolStripMenuItem";
            this.lambdaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lambdaToolStripMenuItem.Text = "Lambda";
            this.lambdaToolStripMenuItem.Click += new System.EventHandler(this.lambdaToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 596);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fizzBuzzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testForCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lambdaToolStripMenuItem;
    }
}