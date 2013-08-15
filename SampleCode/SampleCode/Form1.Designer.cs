namespace SampleCode
{
    partial class Form1
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
            this.btnEnum = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.btnYield = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnLambda = new System.Windows.Forms.Button();
            this.btnVar = new System.Windows.Forms.Button();
            this.btnHashSet = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvResult = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnum
            // 
            this.btnEnum.Location = new System.Drawing.Point(19, 24);
            this.btnEnum.Name = "btnEnum";
            this.btnEnum.Size = new System.Drawing.Size(146, 23);
            this.btnEnum.TabIndex = 0;
            this.btnEnum.Text = "IEnumerable";
            this.btnEnum.UseVisualStyleBackColor = true;
            this.btnEnum.Click += new System.EventHandler(this.btnEnum_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.Location = new System.Drawing.Point(19, 51);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(146, 23);
            this.btnForeach.TabIndex = 1;
            this.btnForeach.Text = "Foreach";
            this.btnForeach.UseVisualStyleBackColor = true;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // btnYield
            // 
            this.btnYield.Location = new System.Drawing.Point(19, 80);
            this.btnYield.Name = "btnYield";
            this.btnYield.Size = new System.Drawing.Size(146, 23);
            this.btnYield.TabIndex = 2;
            this.btnYield.Text = "Yield";
            this.btnYield.UseVisualStyleBackColor = true;
            this.btnYield.Click += new System.EventHandler(this.btnYield_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(19, 25);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(146, 23);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "List<T>";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnLambda
            // 
            this.btnLambda.Location = new System.Drawing.Point(19, 136);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(146, 23);
            this.btnLambda.TabIndex = 4;
            this.btnLambda.Text = "Lambda";
            this.btnLambda.UseVisualStyleBackColor = true;
            this.btnLambda.Click += new System.EventHandler(this.btnLambda_Click);
            // 
            // btnVar
            // 
            this.btnVar.Location = new System.Drawing.Point(19, 108);
            this.btnVar.Name = "btnVar";
            this.btnVar.Size = new System.Drawing.Size(146, 23);
            this.btnVar.TabIndex = 3;
            this.btnVar.Text = "Var";
            this.btnVar.UseVisualStyleBackColor = true;
            this.btnVar.Click += new System.EventHandler(this.btnVar_Click);
            // 
            // btnHashSet
            // 
            this.btnHashSet.Location = new System.Drawing.Point(19, 50);
            this.btnHashSet.Name = "btnHashSet";
            this.btnHashSet.Size = new System.Drawing.Size(146, 23);
            this.btnHashSet.TabIndex = 6;
            this.btnHashSet.Text = "HashSet<T>";
            this.btnHashSet.UseVisualStyleBackColor = true;
            this.btnHashSet.Click += new System.EventHandler(this.btnHashSet_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Location = new System.Drawing.Point(19, 75);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(146, 23);
            this.btnDictionary.TabIndex = 7;
            this.btnDictionary.Text = "Dictionary<TKey,TValue>";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnum);
            this.groupBox1.Controls.Add(this.btnForeach);
            this.groupBox1.Controls.Add(this.btnLambda);
            this.groupBox1.Controls.Add(this.btnYield);
            this.groupBox1.Controls.Add(this.btnVar);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 173);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnList);
            this.groupBox2.Controls.Add(this.btnHashSet);
            this.groupBox2.Controls.Add(this.btnDictionary);
            this.groupBox2.Location = new System.Drawing.Point(235, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 118);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generic Collections";
            // 
            // lsvResult
            // 
            this.lsvResult.FormattingEnabled = true;
            this.lsvResult.Location = new System.Drawing.Point(19, 18);
            this.lsvResult.Name = "lsvResult";
            this.lsvResult.Size = new System.Drawing.Size(146, 69);
            this.lsvResult.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsvResult);
            this.groupBox3.Location = new System.Drawing.Point(235, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 242);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample Code C#";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnum;
        private System.Windows.Forms.Button btnForeach;
        private System.Windows.Forms.Button btnYield;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnLambda;
        private System.Windows.Forms.Button btnVar;
        private System.Windows.Forms.Button btnHashSet;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsvResult;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

