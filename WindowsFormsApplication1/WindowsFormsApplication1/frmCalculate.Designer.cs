namespace WindowsFormsApplication1
{
    partial class frmCalculate
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
            this.cmbCal = new System.Windows.Forms.ComboBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbFrist = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbCal
            // 
            this.cmbCal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCal.FormattingEnabled = true;
            this.cmbCal.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "Mod"});
            this.cmbCal.Location = new System.Drawing.Point(64, 66);
            this.cmbCal.Name = "cmbCal";
            this.cmbCal.Size = new System.Drawing.Size(55, 21);
            this.cmbCal.TabIndex = 2;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(18, 101);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(37, 13);
            this.lbResult.TabIndex = 16;
            this.lbResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(64, 98);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(126, 20);
            this.txtResult.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(18, 42);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 13);
            this.lbName.TabIndex = 15;
            this.lbName.Text = "Second";
            // 
            // lbFrist
            // 
            this.lbFrist.AutoSize = true;
            this.lbFrist.Location = new System.Drawing.Point(20, 20);
            this.lbFrist.Name = "lbFrist";
            this.lbFrist.Size = new System.Drawing.Size(26, 13);
            this.lbFrist.TabIndex = 14;
            this.lbFrist.Text = "First";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(129, 65);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(61, 26);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(64, 39);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(126, 20);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum2_KeyDown);
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(64, 18);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(126, 20);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum1_KeyDown);
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            // 
            // frmCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 139);
            this.Controls.Add(this.cmbCal);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbFrist);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "frmCalculate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate";
            this.Load += new System.EventHandler(this.frmCalculate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCal;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbFrist;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
    }
}