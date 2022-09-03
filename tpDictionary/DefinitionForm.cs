using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace tpDictionary
{
    public partial class DefinitionForm : Form
    {
        public WordInfo DefWordInfo { get; set; }

        public DefinitionForm()
        {
            InitializeComponent();
        }

        private void DefinitionForm_Load(object sender, EventArgs e)
        {
            wordLabel.Text = DefWordInfo.name;
            typeLabel.Text = DefWordInfo.type1;
            definitionLabel.Text = DefWordInfo.def1;
            typeLabel2.Text = DefWordInfo.type2;
            definitionLabel2.Text = DefWordInfo.def2;
            spChara.Image = (Image)SitelenPona.ResourceManager.GetObject(DefWordInfo.name);
            if (DefWordInfo.name == "li")
            {
                definitionLabel.Size = new Size(314, 100);
                typeLabel2.Visible = false;
                definitionLabel2.Visible = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pronounceButton_Click(object sender, EventArgs e)
        {
            Sound.PlayWord(DefWordInfo.name);
        }
    }
}