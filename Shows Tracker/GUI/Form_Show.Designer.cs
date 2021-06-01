namespace ShowsTracker
{
    partial class Form_Show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Show));
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label_nextEpisodeNumber = new System.Windows.Forms.Label();
            this.numUD_nextEpisodeNumber = new System.Windows.Forms.NumericUpDown();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_nextEpisodeNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(12, 13);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(58, 13);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Show title:";
            // 
            // textBox_title
            // 
            this.textBox_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_title.Location = new System.Drawing.Point(15, 29);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(257, 20);
            this.textBox_title.TabIndex = 1;
            this.textBox_title.TextChanged += new System.EventHandler(this.textBox_title_TextChanged);
            // 
            // label_nextEpisodeNumber
            // 
            this.label_nextEpisodeNumber.AutoSize = true;
            this.label_nextEpisodeNumber.Location = new System.Drawing.Point(12, 67);
            this.label_nextEpisodeNumber.Name = "label_nextEpisodeNumber";
            this.label_nextEpisodeNumber.Size = new System.Drawing.Size(171, 13);
            this.label_nextEpisodeNumber.TabIndex = 2;
            this.label_nextEpisodeNumber.Text = "Number of next episode to watch:";
            // 
            // numUD_nextEpisodeNumber
            // 
            this.numUD_nextEpisodeNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUD_nextEpisodeNumber.Location = new System.Drawing.Point(15, 84);
            this.numUD_nextEpisodeNumber.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numUD_nextEpisodeNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_nextEpisodeNumber.Name = "numUD_nextEpisodeNumber";
            this.numUD_nextEpisodeNumber.Size = new System.Drawing.Size(257, 20);
            this.numUD_nextEpisodeNumber.TabIndex = 3;
            this.numUD_nextEpisodeNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel.Font = new System.Drawing.Font("Tahoma", 8F);
            this.button_cancel.Location = new System.Drawing.Point(91, 128);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_save.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button_save.Image = global::ShowsTracker.Properties.Resources.diskette;
            this.button_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_save.Location = new System.Drawing.Point(172, 128);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 23);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Form_Show
            // 
            this.AcceptButton = this.button_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(284, 164);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.numUD_nextEpisodeNumber);
            this.Controls.Add(this.label_nextEpisodeNumber);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Show";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New show";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_nextEpisodeNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label_nextEpisodeNumber;
        private System.Windows.Forms.NumericUpDown numUD_nextEpisodeNumber;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
    }
}