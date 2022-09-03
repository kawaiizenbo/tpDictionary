using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tpDictionary
{
    public partial class SearchResultsForm : Form
    {
        public string SearchQuery { get; set; }
        public string SearchType { get; set; }

        public SearchResultsForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void definitionButton_Click(object sender, EventArgs e)
        {
            defineWord();
        }

        private void defineWord()
        {
            if (wordsListView.SelectedIndices.Count != 0)
            {
                DefinitionForm df = new DefinitionForm();
                df.DefWordInfo = WordsList.Words[wordsListView.Items[wordsListView.SelectedIndices[0]].Text];
                df.ShowDialog();
            }
        }

        private void SearchResultsForm_Load(object sender, EventArgs e)
        {
            Text = "Search results: " + SearchQuery;
            int i = 0;
            foreach (KeyValuePair<string, WordInfo> w in WordsList.Words)
            {
                if (EvalResults(w.Value))
                {
                    ListViewItem lvi = new ListViewItem(w.Value.name);
                    lvi.ImageIndex = i;
                    wordsListView.Items.Add(lvi);
                }
                sitelenPonaList.Images.Add((Image)SitelenPona.ResourceManager.GetObject(w.Value.name));
                i++;
            }
        }

        private bool EvalResults(WordInfo a)
        {
            switch (SearchType)
            {
                case "Word":
                    return a.name.IndexOf(SearchQuery, StringComparison.Ordinal) >= 0;
                case "Definition":
                    return (a.def1.IndexOf(SearchQuery, StringComparison.Ordinal) >= 0) || 
                        (a.def2.IndexOf(SearchQuery, StringComparison.Ordinal) >= 0);
                case "Part of Speech":
                    return (a.type1.IndexOf(SearchQuery, StringComparison.Ordinal) >= 0) || 
                        (a.type2.IndexOf(SearchQuery, StringComparison.Ordinal) >= 0);
            }
            return false;
        }

        private void wordsListView_ItemActivate(object sender, EventArgs e)
        {
            defineWord();
        }
    }
}