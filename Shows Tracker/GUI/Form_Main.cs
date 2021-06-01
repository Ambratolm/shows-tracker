using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ShowsTracker
{
    public partial class Form_Main : Form
    {
        public WatchList WatchList { get; set; }

        public Form_Main(WatchList watchList = null)
        {
            InitializeComponent();
            this.WatchList = watchList == null ? new WatchList() : watchList;
        }

        public void UpdateShowsList(List<Show> shows = null)
        {
            shows = (shows == null) ? WatchList.Shows : shows;
            listView_shows.Items.Clear();
            foreach (Show show in shows)
            {
                ListViewItem item = new ListViewItem();
                item.Name = show.ID.ToString();
                item.Text = show.Title;
                item.ImageKey = "film";
                item.SubItems.Add(show.NextEpisodeNumber.ToString());
                listView_shows.Items.Add(item);
            }
            button_showsCount.Text = listView_shows.Items.Count.ToString();
        }

        public void SelectShowItem(Guid id, bool focus = false)
        {
            int index = listView_shows.Items.IndexOfKey(id.ToString());
            listView_shows.Items[index].Selected = true;
            if (focus)
            {
                listView_shows.Focus();
            }
        }

        public void SelectShowItem(Guid[] ids, bool focus = false)
        {
            foreach (Guid id in ids)
            {
                SelectShowItem(id, focus);
            }
        }

        public void Save()
        {
            try
            {
                WatchList.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            try
            {
                WatchList.Load();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateShowsList();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void textBox_show_TextChanged(object sender, EventArgs e)
        {
            if (textBox_show.Text.Trim() != string.Empty)
            {
                SelectShowItem(WatchList.SearchIDs(textBox_show.Text));
            }
            else
            {
                listView_shows.SelectedItems.Clear();
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Form_Show form_show = new Form_Show(WatchList);
            form_show.TextBox_Title.Text = textBox_show.Text;
            DialogResult dialogResult = form_show.ShowDialog(this);
            if (dialogResult != DialogResult.Cancel)
            {
                Save();
                UpdateShowsList();
                SelectShowItem(WatchList.LatestAddedShow.ID);
                textBox_show.Focus();
                textBox_show.SelectAll();
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (listView_shows.SelectedItems.Count != 0)
            {
                Guid id = Guid.Parse(listView_shows.SelectedItems[0].Name);
                Show showToEdit = WatchList.Find(id);
                if (showToEdit != null)
                {
                    DialogResult dialogResult = new Form_Show(WatchList, showToEdit).ShowDialog(this);
                    if (dialogResult != DialogResult.Cancel)
                    {
                        Save();
                        UpdateShowsList();
                        SelectShowItem(WatchList.LatestEditedShow.ID);
                        textBox_show.Focus();
                        textBox_show.SelectAll();
                    }
                }
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listView_shows.SelectedItems.Count != 0)
            {
                string[] titlesArray = listView_shows
                    .SelectedItems.Cast<ListViewItem>()
                    .Select(item => item.Text).ToArray();
                string titles = String.Join("\n", titlesArray);

                DialogResult dialogResult = MessageBox.Show(
                    string.Format("Are you sure to remove these shows:\n{0} ?", titles),
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (ListViewItem item in listView_shows.SelectedItems)
                    {
                        Guid id = Guid.Parse(item.Name);
                        WatchList.Remove(id);
                    }
                    Save();
                    UpdateShowsList();
                    textBox_show.Focus();
                    textBox_show.SelectAll();
                }
            }
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            new Form_About().ShowDialog(this);
        }

        private void listView_shows_DoubleClick(object sender, EventArgs e)
        {
            button_edit.PerformClick();
        }
    }
}
