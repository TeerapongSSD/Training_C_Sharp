namespace GofPattern
{
    partial class frmLinq
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
            this.btnAll = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSkipWhile = new System.Windows.Forms.Button();
            this.btnOf = new System.Windows.Forms.Button();
            this.btnCast = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(27, 12);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(178, 36);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "All / Any";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(27, 47);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(178, 36);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Count / Sum";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(27, 82);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(178, 36);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "Max / Min";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(27, 117);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(178, 36);
            this.btnSkip.TabIndex = 3;
            this.btnSkip.Text = "Skip / Take";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSkipWhile
            // 
            this.btnSkipWhile.Location = new System.Drawing.Point(27, 152);
            this.btnSkipWhile.Name = "btnSkipWhile";
            this.btnSkipWhile.Size = new System.Drawing.Size(178, 36);
            this.btnSkipWhile.TabIndex = 4;
            this.btnSkipWhile.Text = "SkipWhile / TakeWhile";
            this.btnSkipWhile.UseVisualStyleBackColor = true;
            this.btnSkipWhile.Click += new System.EventHandler(this.btnSkipWhile_Click);
            // 
            // btnOf
            // 
            this.btnOf.Location = new System.Drawing.Point(27, 222);
            this.btnOf.Name = "btnOf";
            this.btnOf.Size = new System.Drawing.Size(178, 36);
            this.btnOf.TabIndex = 6;
            this.btnOf.Text = "OfType / Where";
            this.btnOf.UseVisualStyleBackColor = true;
            this.btnOf.Click += new System.EventHandler(this.btnOf_Click);
            // 
            // btnCast
            // 
            this.btnCast.Location = new System.Drawing.Point(27, 187);
            this.btnCast.Name = "btnCast";
            this.btnCast.Size = new System.Drawing.Size(178, 36);
            this.btnCast.TabIndex = 5;
            this.btnCast.Text = "Cast / Select";
            this.btnCast.UseVisualStyleBackColor = true;
            this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
            // 
            // btnTree
            // 
            this.btnTree.Location = new System.Drawing.Point(27, 257);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(178, 36);
            this.btnTree.TabIndex = 7;
            this.btnTree.Text = "ExpressionTree";
            this.btnTree.UseVisualStyleBackColor = true;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 199);
            this.listBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(224, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 246);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // frmLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 312);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTree);
            this.Controls.Add(this.btnOf);
            this.Controls.Add(this.btnCast);
            this.Controls.Add(this.btnSkipWhile);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnAll);
            this.Name = "frmLinq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linq Sample";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSkipWhile;
        private System.Windows.Forms.Button btnOf;
        private System.Windows.Forms.Button btnCast;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}