namespace tpDictionary
{
    partial class SearchResultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.wordsListView = new System.Windows.Forms.ListView();
            this.backButton = new System.Windows.Forms.MenuItem();
            this.definitionButton = new System.Windows.Forms.MenuItem();
            this.sitelenPonaList = new System.Windows.Forms.ImageList();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.backButton);
            this.mainMenu1.MenuItems.Add(this.definitionButton);
            // 
            // wordsListView
            // 
            this.wordsListView.LargeImageList = this.sitelenPonaList;
            this.wordsListView.Location = new System.Drawing.Point(0, 0);
            this.wordsListView.Name = "wordsListView";
            this.wordsListView.Size = new System.Drawing.Size(320, 186);
            this.wordsListView.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // definitionButton
            // 
            this.definitionButton.Text = "Definition";
            this.definitionButton.Click += new System.EventHandler(this.definitionButton_Click);
            // 
            // sitelenPonaList
            // 
            this.sitelenPonaList.ImageSize = new System.Drawing.Size(32, 32);
            // 
            // SearchResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(131F, 131F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(320, 186);
            this.Controls.Add(this.wordsListView);
            this.Menu = this.mainMenu1;
            this.Name = "SearchResultsForm";
            this.Text = "Search results - ";
            this.Load += new System.EventHandler(this.SearchResultsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView wordsListView;
        private System.Windows.Forms.MenuItem backButton;
        private System.Windows.Forms.MenuItem definitionButton;
        private System.Windows.Forms.ImageList sitelenPonaList;
    }
}