namespace tpDictionary
{
    partial class DefinitionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu menuBar;

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
            this.menuBar = new System.Windows.Forms.MainMenu();
            this.backButton = new System.Windows.Forms.MenuItem();
            this.pronounceButton = new System.Windows.Forms.MenuItem();
            this.wordLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.definitionLabel = new System.Windows.Forms.Label();
            this.definitionLabel2 = new System.Windows.Forms.Label();
            this.typeLabel2 = new System.Windows.Forms.Label();
            this.spChara = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.MenuItems.Add(this.backButton);
            this.menuBar.MenuItems.Add(this.pronounceButton);
            // 
            // backButton
            // 
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pronounceButton
            // 
            this.pronounceButton.Text = "Pronounce";
            this.pronounceButton.Click += new System.EventHandler(this.pronounceButton_Click);
            // 
            // wordLabel
            // 
            this.wordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wordLabel.Font = new System.Drawing.Font("Segoe Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.wordLabel.Location = new System.Drawing.Point(3, 0);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(260, 30);
            this.wordLabel.Text = "word";
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLabel.Font = new System.Drawing.Font("Segoe Condensed", 8F, System.Drawing.FontStyle.Regular);
            this.typeLabel.Location = new System.Drawing.Point(3, 30);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(260, 20);
            this.typeLabel.Text = "type";
            // 
            // definitionLabel
            // 
            this.definitionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.definitionLabel.Font = new System.Drawing.Font("Segoe Condensed", 10F, System.Drawing.FontStyle.Regular);
            this.definitionLabel.Location = new System.Drawing.Point(3, 50);
            this.definitionLabel.Name = "definitionLabel";
            this.definitionLabel.Size = new System.Drawing.Size(314, 50);
            this.definitionLabel.Text = "definition";
            // 
            // definitionLabel2
            // 
            this.definitionLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.definitionLabel2.Font = new System.Drawing.Font("Segoe Condensed", 10F, System.Drawing.FontStyle.Regular);
            this.definitionLabel2.Location = new System.Drawing.Point(3, 120);
            this.definitionLabel2.Name = "definitionLabel2";
            this.definitionLabel2.Size = new System.Drawing.Size(314, 50);
            this.definitionLabel2.Text = "definition2";
            // 
            // typeLabel2
            // 
            this.typeLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLabel2.Font = new System.Drawing.Font("Segoe Condensed", 8F, System.Drawing.FontStyle.Regular);
            this.typeLabel2.Location = new System.Drawing.Point(3, 100);
            this.typeLabel2.Name = "typeLabel2";
            this.typeLabel2.Size = new System.Drawing.Size(314, 20);
            this.typeLabel2.Text = "type2";
            // 
            // spChara
            // 
            this.spChara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spChara.Location = new System.Drawing.Point(269, 3);
            this.spChara.Name = "spChara";
            this.spChara.Size = new System.Drawing.Size(48, 48);
            this.spChara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // DefinitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(131F, 131F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(320, 186);
            this.Controls.Add(this.spChara);
            this.Controls.Add(this.definitionLabel2);
            this.Controls.Add(this.typeLabel2);
            this.Controls.Add(this.definitionLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.wordLabel);
            this.Menu = this.menuBar;
            this.Name = "DefinitionForm";
            this.Text = "Definition";
            this.Load += new System.EventHandler(this.DefinitionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.MenuItem backButton;
        private System.Windows.Forms.MenuItem pronounceButton;
        private System.Windows.Forms.Label definitionLabel;
        private System.Windows.Forms.Label definitionLabel2;
        private System.Windows.Forms.Label typeLabel2;
        private System.Windows.Forms.PictureBox spChara;
    }
}