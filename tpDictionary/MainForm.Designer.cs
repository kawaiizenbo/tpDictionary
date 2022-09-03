namespace tpDictionary
{
    partial class MainForm
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
            this.defineButton = new System.Windows.Forms.MenuItem();
            this.searchButton = new System.Windows.Forms.MenuItem();
            this.wordsListView = new System.Windows.Forms.ListView();
            this.sitelenPonaList = new System.Windows.Forms.ImageList();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.MenuItems.Add(this.defineButton);
            this.menuBar.MenuItems.Add(this.searchButton);
            // 
            // defineButton
            // 
            this.defineButton.Text = "Definition";
            this.defineButton.Click += new System.EventHandler(this.defineButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // wordsListView
            // 
            this.wordsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wordsListView.LargeImageList = this.sitelenPonaList;
            this.wordsListView.Location = new System.Drawing.Point(0, 0);
            this.wordsListView.Name = "wordsListView";
            this.wordsListView.Size = new System.Drawing.Size(320, 186);
            this.wordsListView.TabIndex = 0;
            this.wordsListView.ItemActivate += new System.EventHandler(this.wordsListView_ItemActivate);
            // 
            // sitelenPonaList
            // 
            this.sitelenPonaList.ImageSize = new System.Drawing.Size(32, 32);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(131F, 131F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(320, 186);
            this.Controls.Add(this.wordsListView);
            this.Menu = this.menuBar;
            this.Name = "MainForm";
            this.Text = "toki pona Dictionary";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem defineButton;
        private System.Windows.Forms.MenuItem searchButton;
        private System.Windows.Forms.ListView wordsListView;
        private System.Windows.Forms.ImageList sitelenPonaList;
    }
}

