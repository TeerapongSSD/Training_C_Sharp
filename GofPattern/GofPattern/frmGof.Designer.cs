namespace GofPattern
{
    partial class frmGof
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
            this.btnSingleton = new System.Windows.Forms.Button();
            this.btnTemplate = new System.Windows.Forms.Button();
            this.btnComposite = new System.Windows.Forms.Button();
            this.btnAbstract = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSingleton
            // 
            this.btnSingleton.Location = new System.Drawing.Point(28, 16);
            this.btnSingleton.Name = "btnSingleton";
            this.btnSingleton.Size = new System.Drawing.Size(239, 42);
            this.btnSingleton.TabIndex = 0;
            this.btnSingleton.Text = "Singleton";
            this.btnSingleton.UseVisualStyleBackColor = true;
            this.btnSingleton.Click += new System.EventHandler(this.btnSingleton_Click);
            // 
            // btnTemplate
            // 
            this.btnTemplate.Location = new System.Drawing.Point(28, 59);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(239, 42);
            this.btnTemplate.TabIndex = 1;
            this.btnTemplate.Text = "Template Method";
            this.btnTemplate.UseVisualStyleBackColor = true;
            this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click);
            // 
            // btnComposite
            // 
            this.btnComposite.Location = new System.Drawing.Point(28, 102);
            this.btnComposite.Name = "btnComposite";
            this.btnComposite.Size = new System.Drawing.Size(239, 42);
            this.btnComposite.TabIndex = 2;
            this.btnComposite.Text = "Composite";
            this.btnComposite.UseVisualStyleBackColor = true;
            this.btnComposite.Click += new System.EventHandler(this.btnComposite_Click);
            // 
            // btnAbstract
            // 
            this.btnAbstract.Location = new System.Drawing.Point(28, 145);
            this.btnAbstract.Name = "btnAbstract";
            this.btnAbstract.Size = new System.Drawing.Size(239, 42);
            this.btnAbstract.TabIndex = 3;
            this.btnAbstract.Text = "Abstract Factory";
            this.btnAbstract.UseVisualStyleBackColor = true;
            this.btnAbstract.Click += new System.EventHandler(this.btnAbstract_Click);
            // 
            // btnState
            // 
            this.btnState.Location = new System.Drawing.Point(28, 188);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(239, 42);
            this.btnState.TabIndex = 4;
            this.btnState.Text = "State";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // frmGof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 246);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.btnAbstract);
            this.Controls.Add(this.btnComposite);
            this.Controls.Add(this.btnTemplate);
            this.Controls.Add(this.btnSingleton);
            this.Name = "frmGof";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gang Of Four Pattern";
            this.Load += new System.EventHandler(this.frmGof_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSingleton;
        private System.Windows.Forms.Button btnTemplate;
        private System.Windows.Forms.Button btnComposite;
        private System.Windows.Forms.Button btnAbstract;
        private System.Windows.Forms.Button btnState;
    }
}

