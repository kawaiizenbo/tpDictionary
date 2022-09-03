using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tpDictionary
{
    public partial class MainForm : Form
    {
        public WordsList wordsList;

        public MainForm()
        {
            InitializeComponent();
            wordsList = new WordsList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach(KeyValuePair<string, WordInfo> w in WordsList.Words)
            {
                ListViewItem lvi = new ListViewItem(w.Value.name);
                sitelenPonaList.Images.Add((Image)SitelenPona.ResourceManager.GetObject(w.Value.name));
                lvi.ImageIndex = i;
                wordsListView.Items.Add(lvi);
                i++;
            }
        }

        private void defineButton_Click(object sender, EventArgs e)
        {
            defineWord();
        }

        private void wordsListView_ItemActivate(object sender, EventArgs e)
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm f = new SearchForm();
            f.ShowDialog();
        }
    }
}