namespace ShowsTracker
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.listView_shows = new System.Windows.Forms.ListView();
            this.show = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList_shows = new System.Windows.Forms.ImageList(this.components);
            this.textBox_show = new System.Windows.Forms.TextBox();
            this.toolTip_main = new System.Windows.Forms.ToolTip(this.components);
            this.button_add = new System.Windows.Forms.Button();
            this.button_showsCount = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_shows
            // 
            this.listView_shows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_shows.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_shows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.show,
            this.number});
            this.listView_shows.FullRowSelect = true;
            this.listView_shows.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_shows.HideSelection = false;
            this.listView_shows.LargeImageList = this.imageList_shows;
            this.listView_shows.Location = new System.Drawing.Point(13, 38);
            this.listView_shows.Name = "listView_shows";
            this.listView_shows.Size = new System.Drawing.Size(483, 368);
            this.listView_shows.SmallImageList = this.imageList_shows;
            this.listView_shows.TabIndex = 4;
            this.listView_shows.UseCompatibleStateImageBehavior = false;
            this.listView_shows.View = System.Windows.Forms.View.Details;
            this.listView_shows.DoubleClick += new System.EventHandler(this.listView_shows_DoubleClick);
            // 
            // show
            // 
            this.show.Text = "Show";
            this.show.Width = 200;
            // 
            // number
            // 
            this.number.Text = "Episode to watch next";
            this.number.Width = 200;
            // 
            // imageList_shows
            // 
            this.imageList_shows.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_shows.ImageStream")));
            this.imageList_shows.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_shows.Images.SetKeyName(0, "film");
            this.imageList_shows.Images.SetKeyName(1, "next");
            // 
            // textBox_show
            // 
            this.textBox_show.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_show.Location = new System.Drawing.Point(13, 10);
            this.textBox_show.Multiline = true;
            this.textBox_show.Name = "textBox_show";
            this.textBox_show.Size = new System.Drawing.Size(369, 22);
            this.textBox_show.TabIndex = 0;
            this.textBox_show.TextChanged += new System.EventHandler(this.textBox_show_TextChanged);
            // 
            // toolTip_main
            // 
            this.toolTip_main.IsBalloon = true;
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Image = global::ShowsTracker.Properties.Resources.add;
            this.button_add.Location = new System.Drawing.Point(388, 9);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(32, 23);
            this.button_add.TabIndex = 1;
            this.toolTip_main.SetToolTip(this.button_add, "Add new show");
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_showsCount
            // 
            this.button_showsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_showsCount.AutoSize = true;
            this.button_showsCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_showsCount.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_showsCount.FlatAppearance.BorderSize = 0;
            this.button_showsCount.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_showsCount.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_showsCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showsCount.Image = global::ShowsTracker.Properties.Resources.video_mode;
            this.button_showsCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_showsCount.Location = new System.Drawing.Point(415, 410);
            this.button_showsCount.Name = "button_showsCount";
            this.button_showsCount.Size = new System.Drawing.Size(83, 25);
            this.button_showsCount.TabIndex = 6;
            this.button_showsCount.Text = "0";
            this.button_showsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_showsCount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip_main.SetToolTip(this.button_showsCount, "Shows count");
            this.button_showsCount.UseVisualStyleBackColor = true;
            // 
            // button_about
            // 
            this.button_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_about.FlatAppearance.BorderSize = 0;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_about.Image = global::ShowsTracker.Properties.Resources.help;
            this.button_about.Location = new System.Drawing.Point(13, 412);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(32, 23);
            this.button_about.TabIndex = 5;
            this.toolTip_main.SetToolTip(this.button_about, "About");
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_remove
            // 
            this.button_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_remove.Image = global::ShowsTracker.Properties.Resources.delete;
            this.button_remove.Location = new System.Drawing.Point(464, 9);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(32, 23);
            this.button_remove.TabIndex = 3;
            this.toolTip_main.SetToolTip(this.button_remove, "Remove selected shows");
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_edit
            // 
            this.button_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_edit.Image = global::ShowsTracker.Properties.Resources.pencil;
            this.button_edit.Location = new System.Drawing.Point(426, 9);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(32, 23);
            this.button_edit.TabIndex = 2;
            this.toolTip_main.SetToolTip(this.button_edit, "Edit selected show");
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // Form_Main
            // 
            this.AcceptButton = this.button_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 443);
            this.Controls.Add(this.button_showsCount);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.textBox_show);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.listView_shows);
            this.Controls.Add(this.button_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shows Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ListView listView_shows;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.TextBox textBox_show;
        private System.Windows.Forms.ToolTip toolTip_main;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_showsCount;
        private System.Windows.Forms.ImageList imageList_shows;
        private System.Windows.Forms.ColumnHeader show;
        private System.Windows.Forms.ColumnHeader number;
    }
}