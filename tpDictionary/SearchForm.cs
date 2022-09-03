using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tpDictionary
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Trim() == "" || queryTypeComboBox.Text.Trim() == "") return;
            SearchResultsForm sf = new SearchResultsForm();
            sf.SearchQuery = searchTextBox.Text.Trim();
            sf.SearchType = queryTypeComboBox.Text.Trim();
            sf.ShowDialog();
        }
    }
}