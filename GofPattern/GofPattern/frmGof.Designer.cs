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
            this.btnIterator = new System.Windows.Forms.Button();
            this.btnFactory = new System.Windows.Forms.Button();
            this.btnFacade = new System.Windows.Forms.Button();
            this.btnObsever = new System.Windows.Forms.Button();
            this.btnChain = new System.Windows.Forms.Button();
            this.btnCommand = new System.Windows.Forms.Button();
            this.btnDecorator = new System.Windows.Forms.Button();
            this.btnBridge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSingleton
            // 
            this.btnSingleton.Location = new System.Drawing.Point(15, 14);
            this.btnSingleton.Name = "btnSingleton";
            this.btnSingleton.Size = new System.Drawing.Size(282, 42);
            this.btnSingleton.TabIndex = 0;
            this.btnSingleton.Text = "Singleton";
            this.btnSingleton.UseVisualStyleBackColor = true;
            this.btnSingleton.Click += new System.EventHandler(this.btnSingleton_Click);
            // 
            // btnTemplate
            // 
            this.btnTemplate.Location = new System.Drawing.Point(15, 57);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(282, 42);
            this.btnTemplate.TabIndex = 1;
            this.btnTemplate.Text = "Template Method";
            this.btnTemplate.UseVisualStyleBackColor = true;
            this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click);
            // 
            // btnComposite
            // 
            this.btnComposite.Location = new System.Drawing.Point(15, 100);
            this.btnComposite.Name = "btnComposite";
            this.btnComposite.Size = new System.Drawing.Size(282, 42);
            this.btnComposite.TabIndex = 2;
            this.btnComposite.Text = "Composite";
            this.btnComposite.UseVisualStyleBackColor = true;
            this.btnComposite.Click += new System.EventHandler(this.btnComposite_Click);
            // 
            // btnAbstract
            // 
            this.btnAbstract.Location = new System.Drawing.Point(15, 143);
            this.btnAbstract.Name = "btnAbstract";
            this.btnAbstract.Size = new System.Drawing.Size(282, 42);
            this.btnAbstract.TabIndex = 3;
            this.btnAbstract.Text = "Abstract Factory";
            this.btnAbstract.UseVisualStyleBackColor = true;
            this.btnAbstract.Click += new System.EventHandler(this.btnAbstract_Click);
            // 
            // btnState
            // 
            this.btnState.Location = new System.Drawing.Point(15, 186);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(282, 42);
            this.btnState.TabIndex = 4;
            this.btnState.Text = "State";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // btnIterator
            // 
            this.btnIterator.Location = new System.Drawing.Point(15, 230);
            this.btnIterator.Name = "btnIterator";
            this.btnIterator.Size = new System.Drawing.Size(282, 42);
            this.btnIterator.TabIndex = 5;
            this.btnIterator.Text = "Iterator";
            this.btnIterator.UseVisualStyleBackColor = true;
            this.btnIterator.Click += new System.EventHandler(this.btnIterator_Click);
            // 
            // btnFactory
            // 
            this.btnFactory.Location = new System.Drawing.Point(14, 274);
            this.btnFactory.Name = "btnFactory";
            this.btnFactory.Size = new System.Drawing.Size(282, 42);
            this.btnFactory.TabIndex = 6;
            this.btnFactory.Text = "Factory";
            this.btnFactory.UseVisualStyleBackColor = true;
            this.btnFactory.Click += new System.EventHandler(this.btnFactory_Click);
            // 
            // btnFacade
            // 
            this.btnFacade.Location = new System.Drawing.Point(14, 317);
            this.btnFacade.Name = "btnFacade";
            this.btnFacade.Size = new System.Drawing.Size(282, 42);
            this.btnFacade.TabIndex = 7;
            this.btnFacade.Text = "Facade";
            this.btnFacade.UseVisualStyleBackColor = true;
            this.btnFacade.Click += new System.EventHandler(this.btnFacade_Click);
            // 
            // btnObsever
            // 
            this.btnObsever.Location = new System.Drawing.Point(14, 360);
            this.btnObsever.Name = "btnObsever";
            this.btnObsever.Size = new System.Drawing.Size(282, 42);
            this.btnObsever.TabIndex = 8;
            this.btnObsever.Text = "Observer";
            this.btnObsever.UseVisualStyleBackColor = true;
            this.btnObsever.Click += new System.EventHandler(this.btnObsever_Click);
            // 
            // btnChain
            // 
            this.btnChain.Location = new System.Drawing.Point(299, 144);
            this.btnChain.Name = "btnChain";
            this.btnChain.Size = new System.Drawing.Size(282, 42);
            this.btnChain.TabIndex = 12;
            this.btnChain.Text = "Chain Of Responsibility";
            this.btnChain.UseVisualStyleBackColor = true;
            this.btnChain.Click += new System.EventHandler(this.btnChain_Click);
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(299, 101);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(282, 42);
            this.btnCommand.TabIndex = 11;
            this.btnCommand.Text = "Command";
            this.btnCommand.UseVisualStyleBackColor = true;
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // btnDecorator
            // 
            this.btnDecorator.Location = new System.Drawing.Point(299, 58);
            this.btnDecorator.Name = "btnDecorator";
            this.btnDecorator.Size = new System.Drawing.Size(282, 42);
            this.btnDecorator.TabIndex = 10;
            this.btnDecorator.Text = "Decorator";
            this.btnDecorator.UseVisualStyleBackColor = true;
            this.btnDecorator.Click += new System.EventHandler(this.btnDecorator_Click);
            // 
            // btnBridge
            // 
            this.btnBridge.Location = new System.Drawing.Point(299, 14);
            this.btnBridge.Name = "btnBridge";
            this.btnBridge.Size = new System.Drawing.Size(282, 42);
            this.btnBridge.TabIndex = 9;
            this.btnBridge.Text = "Bridge";
            this.btnBridge.UseVisualStyleBackColor = true;
            this.btnBridge.Click += new System.EventHandler(this.btnBridge_Click);
            // 
            // frmGof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 413);
            this.Controls.Add(this.btnChain);
            this.Controls.Add(this.btnCommand);
            this.Controls.Add(this.btnDecorator);
            this.Controls.Add(this.btnBridge);
            this.Controls.Add(this.btnObsever);
            this.Controls.Add(this.btnFacade);
            this.Controls.Add(this.btnFactory);
            this.Controls.Add(this.btnIterator);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.btnAbstract);
            this.Controls.Add(this.btnComposite);
            this.Controls.Add(this.btnTemplate);
            this.Controls.Add(this.btnSingleton);
            this.Name = "frmGof";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gang Of Four Pattern";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSingleton;
        private System.Windows.Forms.Button btnTemplate;
        private System.Windows.Forms.Button btnComposite;
        private System.Windows.Forms.Button btnAbstract;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.Button btnIterator;
        private System.Windows.Forms.Button btnFactory;
        private System.Windows.Forms.Button btnFacade;
        private System.Windows.Forms.Button btnObsever;
        private System.Windows.Forms.Button btnChain;
        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.Button btnDecorator;
        private System.Windows.Forms.Button btnBridge;
    }
}

