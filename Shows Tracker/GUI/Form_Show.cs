using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShowsTracker
{
    public partial class Form_Show : Form
    {
        public WatchList WatchList { get; set; }
        public Show ShowToEdit { get; set; }
        public TextBox TextBox_Title 
        {
            get
            {
                return textBox_title;
            }
        }

        public Form_Show(WatchList watchList, Show showToEdit = null)
        {
            InitializeComponent();
            this.WatchList = watchList;
            this.ShowToEdit = showToEdit;
            PopulateControls();
        }

        public void PopulateControls()
        {
            if (ShowToEdit != null)
            {
                this.Text = string.Format("Edit show: {0}", ShowToEdit.Title);
                textBox_title.Text = ShowToEdit.Title;
                numUD_nextEpisodeNumber.Value = ShowToEdit.NextEpisodeNumber;
            }
        }

        private void textBox_title_TextChanged(object sender, EventArgs e)
        {
            button_save.Enabled = (sender as TextBox).Text.Trim() != string.Empty;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string title = textBox_title.Text.Trim();
            int nextEpisodeNumber = (int)numUD_nextEpisodeNumber.Value;
            Show newShow = new Show(title, nextEpisodeNumber);
            if (ShowToEdit == null)
            {
                WatchList.Add(newShow);
            }
            else
            {
                WatchList.Edit(ShowToEdit.ID, newShow);
            }
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
