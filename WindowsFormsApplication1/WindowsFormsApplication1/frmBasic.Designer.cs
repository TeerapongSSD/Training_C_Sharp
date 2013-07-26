namespace WindowsFormsApplication1
{
    partial class frmBasic
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
            this.btnParameter = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtResult1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLower2 = new System.Windows.Forms.Button();
            this.btnUpper2 = new System.Windows.Forms.Button();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.txtStr2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTestInher = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTestPoly = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnTestInter = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnNumE = new System.Windows.Forms.Button();
            this.cmbEnum = new System.Windows.Forms.ComboBox();
            this.btnEnum = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnGeneric = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnDelegate = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnLambda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnParameter
            // 
            this.btnParameter.Location = new System.Drawing.Point(116, 30);
            this.btnParameter.Name = "btnParameter";
            this.btnParameter.Size = new System.Drawing.Size(75, 23);
            this.btnParameter.TabIndex = 0;
            this.btnParameter.Text = "Ok";
            this.btnParameter.UseVisualStyleBackColor = true;
            this.btnParameter.Click += new System.EventHandler(this.btnParameter_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(10, 30);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 1;
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            // 
            // txtResult1
            // 
            this.txtResult1.Location = new System.Drawing.Point(10, 53);
            this.txtResult1.Name = "txtResult1";
            this.txtResult1.ReadOnly = true;
            this.txtResult1.Size = new System.Drawing.Size(100, 20);
            this.txtResult1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnParameter);
            this.groupBox1.Controls.Add(this.txtResult1);
            this.groupBox1.Controls.Add(this.txtNum1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameter Test";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLower2);
            this.groupBox2.Controls.Add(this.btnUpper2);
            this.groupBox2.Controls.Add(this.txtResult2);
            this.groupBox2.Controls.Add(this.txtStr2);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 86);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UpperLower Test";
            // 
            // btnLower2
            // 
            this.btnLower2.Location = new System.Drawing.Point(116, 51);
            this.btnLower2.Name = "btnLower2";
            this.btnLower2.Size = new System.Drawing.Size(75, 23);
            this.btnLower2.TabIndex = 3;
            this.btnLower2.Text = "Lower";
            this.btnLower2.UseVisualStyleBackColor = true;
            this.btnLower2.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnUpper2
            // 
            this.btnUpper2.Location = new System.Drawing.Point(116, 28);
            this.btnUpper2.Name = "btnUpper2";
            this.btnUpper2.Size = new System.Drawing.Size(75, 23);
            this.btnUpper2.TabIndex = 0;
            this.btnUpper2.Text = "Upper";
            this.btnUpper2.UseVisualStyleBackColor = true;
            this.btnUpper2.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(10, 53);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.ReadOnly = true;
            this.txtResult2.Size = new System.Drawing.Size(100, 20);
            this.txtResult2.TabIndex = 2;
            // 
            // txtStr2
            // 
            this.txtStr2.Location = new System.Drawing.Point(10, 30);
            this.txtStr2.Name = "txtStr2";
            this.txtStr2.Size = new System.Drawing.Size(100, 20);
            this.txtStr2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTestInher);
            this.groupBox3.Location = new System.Drawing.Point(12, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 86);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inheritance Test";
            // 
            // btnTestInher
            // 
            this.btnTestInher.Location = new System.Drawing.Point(51, 36);
            this.btnTestInher.Name = "btnTestInher";
            this.btnTestInher.Size = new System.Drawing.Size(88, 23);
            this.btnTestInher.TabIndex = 0;
            this.btnTestInher.Text = "Test";
            this.btnTestInher.UseVisualStyleBackColor = true;
            this.btnTestInher.Click += new System.EventHandler(this.btnTest3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTestPoly);
            this.groupBox4.Location = new System.Drawing.Point(12, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 86);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Polymorphism Test";
            // 
            // btnTestPoly
            // 
            this.btnTestPoly.Location = new System.Drawing.Point(51, 36);
            this.btnTestPoly.Name = "btnTestPoly";
            this.btnTestPoly.Size = new System.Drawing.Size(88, 23);
            this.btnTestPoly.TabIndex = 0;
            this.btnTestPoly.Text = "Test";
            this.btnTestPoly.UseVisualStyleBackColor = true;
            this.btnTestPoly.Click += new System.EventHandler(this.btnTest4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnTestInter);
            this.groupBox5.Location = new System.Drawing.Point(12, 380);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 86);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Interface Test";
            // 
            // btnTestInter
            // 
            this.btnTestInter.Location = new System.Drawing.Point(51, 36);
            this.btnTestInter.Name = "btnTestInter";
            this.btnTestInter.Size = new System.Drawing.Size(88, 23);
            this.btnTestInter.TabIndex = 0;
            this.btnTestInter.Text = "Test";
            this.btnTestInter.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnNumE);
            this.groupBox6.Controls.Add(this.cmbEnum);
            this.groupBox6.Controls.Add(this.btnEnum);
            this.groupBox6.Location = new System.Drawing.Point(233, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 86);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Enum Test";
            // 
            // btnNumE
            // 
            this.btnNumE.Location = new System.Drawing.Point(99, 54);
            this.btnNumE.Name = "btnNumE";
            this.btnNumE.Size = new System.Drawing.Size(88, 23);
            this.btnNumE.TabIndex = 2;
            this.btnNumE.Text = "Enum 1-10";
            this.btnNumE.UseVisualStyleBackColor = true;
            this.btnNumE.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // cmbEnum
            // 
            this.cmbEnum.FormattingEnabled = true;
            this.cmbEnum.Location = new System.Drawing.Point(43, 28);
            this.cmbEnum.Name = "cmbEnum";
            this.cmbEnum.Size = new System.Drawing.Size(121, 21);
            this.cmbEnum.TabIndex = 1;
            // 
            // btnEnum
            // 
            this.btnEnum.Location = new System.Drawing.Point(6, 54);
            this.btnEnum.Name = "btnEnum";
            this.btnEnum.Size = new System.Drawing.Size(87, 23);
            this.btnEnum.TabIndex = 0;
            this.btnEnum.Text = "Test";
            this.btnEnum.UseVisualStyleBackColor = true;
            this.btnEnum.Click += new System.EventHandler(this.btnEnum_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnGeneric);
            this.groupBox7.Location = new System.Drawing.Point(233, 104);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 86);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Generics Test";
            // 
            // btnGeneric
            // 
            this.btnGeneric.Location = new System.Drawing.Point(51, 36);
            this.btnGeneric.Name = "btnGeneric";
            this.btnGeneric.Size = new System.Drawing.Size(88, 23);
            this.btnGeneric.TabIndex = 0;
            this.btnGeneric.Text = "Test";
            this.btnGeneric.UseVisualStyleBackColor = true;
            this.btnGeneric.Click += new System.EventHandler(this.btnGeneric_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnDelegate);
            this.groupBox8.Location = new System.Drawing.Point(234, 196);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 86);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Delegates Test";
            // 
            // btnDelegate
            // 
            this.btnDelegate.Location = new System.Drawing.Point(51, 36);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(88, 23);
            this.btnDelegate.TabIndex = 0;
            this.btnDelegate.Text = "Test";
            this.btnDelegate.UseVisualStyleBackColor = true;
            this.btnDelegate.Click += new System.EventHandler(this.btnDelegate_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnLambda);
            this.groupBox9.Location = new System.Drawing.Point(233, 288);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 86);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Lambda Test";
            // 
            // btnLambda
            // 
            this.btnLambda.Location = new System.Drawing.Point(51, 36);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(88, 23);
            this.btnLambda.TabIndex = 0;
            this.btnLambda.Text = "Test";
            this.btnLambda.UseVisualStyleBackColor = true;
            this.btnLambda.Click += new System.EventHandler(this.btnLambda_Click);
            // 
            // frmBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 484);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBasic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmBasic_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParameter;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtResult1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpper2;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.TextBox txtStr2;
        private System.Windows.Forms.Button btnLower2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTestInher;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTestPoly;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnTestInter;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnEnum;
        private System.Windows.Forms.ComboBox cmbEnum;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnGeneric;
        private System.Windows.Forms.Button btnNumE;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnLambda;
    }
}