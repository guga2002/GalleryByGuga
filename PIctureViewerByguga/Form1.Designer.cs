namespace PIctureViewerByguga
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonadddir = new System.Windows.Forms.Button();
            this.buttonremovedir = new System.Windows.Forms.Button();
            this.buttonpreviouspic = new System.Windows.Forms.Button();
            this.buttonnextpic = new System.Windows.Forms.Button();
            this.checkBoxisloop = new System.Windows.Forms.CheckBox();
            this.buttonrefresh = new System.Windows.Forms.Button();
            this.buttonplay = new System.Windows.Forms.Button();
            this.textBoxtimeforslideshow = new System.Windows.Forms.TextBox();
            this.pictureBoxMainbox = new System.Windows.Forms.PictureBox();
            this.pictureBoxlefside = new System.Windows.Forms.PictureBox();
            this.pictureBoxrightside = new System.Windows.Forms.PictureBox();
            this.directoryEntrydir = new System.DirectoryServices.DirectoryEntry();
            this.listBoxfordirectories = new System.Windows.Forms.ListBox();
            this.forpictures = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlefside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxrightside)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonadddir
            // 
            this.buttonadddir.Location = new System.Drawing.Point(33, 156);
            this.buttonadddir.Name = "buttonadddir";
            this.buttonadddir.Size = new System.Drawing.Size(106, 23);
            this.buttonadddir.TabIndex = 2;
            this.buttonadddir.Text = "Add Directory";
            this.buttonadddir.UseVisualStyleBackColor = true;
            this.buttonadddir.Click += new System.EventHandler(this.buttonadddir_Click);
            // 
            // buttonremovedir
            // 
            this.buttonremovedir.Location = new System.Drawing.Point(313, 156);
            this.buttonremovedir.Name = "buttonremovedir";
            this.buttonremovedir.Size = new System.Drawing.Size(117, 23);
            this.buttonremovedir.TabIndex = 3;
            this.buttonremovedir.Text = "Remove Directory";
            this.buttonremovedir.UseVisualStyleBackColor = true;
            this.buttonremovedir.Click += new System.EventHandler(this.buttonremovedir_Click);
            // 
            // buttonpreviouspic
            // 
            this.buttonpreviouspic.Location = new System.Drawing.Point(447, 471);
            this.buttonpreviouspic.Name = "buttonpreviouspic";
            this.buttonpreviouspic.Size = new System.Drawing.Size(106, 23);
            this.buttonpreviouspic.TabIndex = 5;
            this.buttonpreviouspic.Text = "Previous";
            this.buttonpreviouspic.UseVisualStyleBackColor = true;
            this.buttonpreviouspic.Click += new System.EventHandler(this.buttonpreviouspic_Click);
            // 
            // buttonnextpic
            // 
            this.buttonnextpic.Location = new System.Drawing.Point(802, 471);
            this.buttonnextpic.Name = "buttonnextpic";
            this.buttonnextpic.Size = new System.Drawing.Size(111, 23);
            this.buttonnextpic.TabIndex = 6;
            this.buttonnextpic.Text = "Next";
            this.buttonnextpic.UseVisualStyleBackColor = true;
            this.buttonnextpic.Click += new System.EventHandler(this.buttonnextpic_Click);
            // 
            // checkBoxisloop
            // 
            this.checkBoxisloop.AutoSize = true;
            this.checkBoxisloop.Location = new System.Drawing.Point(276, 416);
            this.checkBoxisloop.Name = "checkBoxisloop";
            this.checkBoxisloop.Size = new System.Drawing.Size(50, 17);
            this.checkBoxisloop.TabIndex = 7;
            this.checkBoxisloop.Text = "Loop";
            this.checkBoxisloop.UseVisualStyleBackColor = true;
            // 
            // buttonrefresh
            // 
            this.buttonrefresh.Location = new System.Drawing.Point(33, 414);
            this.buttonrefresh.Name = "buttonrefresh";
            this.buttonrefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonrefresh.TabIndex = 8;
            this.buttonrefresh.Text = "Refresh";
            this.buttonrefresh.UseVisualStyleBackColor = true;
            this.buttonrefresh.Click += new System.EventHandler(this.buttonrefresh_Click);
            // 
            // buttonplay
            // 
            this.buttonplay.Location = new System.Drawing.Point(355, 414);
            this.buttonplay.Name = "buttonplay";
            this.buttonplay.Size = new System.Drawing.Size(75, 23);
            this.buttonplay.TabIndex = 9;
            this.buttonplay.Text = "Play";
            this.buttonplay.UseVisualStyleBackColor = true;
            // 
            // textBoxtimeforslideshow
            // 
            this.textBoxtimeforslideshow.Location = new System.Drawing.Point(158, 414);
            this.textBoxtimeforslideshow.Name = "textBoxtimeforslideshow";
            this.textBoxtimeforslideshow.Size = new System.Drawing.Size(75, 20);
            this.textBoxtimeforslideshow.TabIndex = 10;
            // 
            // pictureBoxMainbox
            // 
            this.pictureBoxMainbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainbox.BackgroundImage")));
            this.pictureBoxMainbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxMainbox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainbox.Image")));
            this.pictureBoxMainbox.Location = new System.Drawing.Point(501, 12);
            this.pictureBoxMainbox.Name = "pictureBoxMainbox";
            this.pictureBoxMainbox.Size = new System.Drawing.Size(737, 338);
            this.pictureBoxMainbox.TabIndex = 11;
            this.pictureBoxMainbox.TabStop = false;
            this.pictureBoxMainbox.MouseCaptureChanged += new System.EventHandler(this.pictureBox1_MouseCaptureChanged);
            this.pictureBoxMainbox.Resize += new System.EventHandler(this.pictureBox1_MouseCaptureChanged);
            // 
            // pictureBoxlefside
            // 
            this.pictureBoxlefside.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxlefside.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxlefside.Image")));
            this.pictureBoxlefside.Location = new System.Drawing.Point(460, 356);
            this.pictureBoxlefside.Name = "pictureBoxlefside";
            this.pictureBoxlefside.Size = new System.Drawing.Size(117, 101);
            this.pictureBoxlefside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxlefside.TabIndex = 12;
            this.pictureBoxlefside.TabStop = false;
            this.pictureBoxlefside.Click += new System.EventHandler(this.pictureBoxlefside_Click);
            // 
            // pictureBoxrightside
            // 
            this.pictureBoxrightside.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxrightside.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxrightside.Image")));
            this.pictureBoxrightside.Location = new System.Drawing.Point(1110, 356);
            this.pictureBoxrightside.Name = "pictureBoxrightside";
            this.pictureBoxrightside.Size = new System.Drawing.Size(111, 101);
            this.pictureBoxrightside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxrightside.TabIndex = 13;
            this.pictureBoxrightside.TabStop = false;
            this.pictureBoxrightside.Click += new System.EventHandler(this.pictureBoxrightside_Click);
            // 
            // listBoxfordirectories
            // 
            this.listBoxfordirectories.FormattingEnabled = true;
            this.listBoxfordirectories.Location = new System.Drawing.Point(33, 30);
            this.listBoxfordirectories.Name = "listBoxfordirectories";
            this.listBoxfordirectories.Size = new System.Drawing.Size(397, 121);
            this.listBoxfordirectories.TabIndex = 14;
            this.listBoxfordirectories.SelectedIndexChanged += new System.EventHandler(this.listBoxfordirectories_SelectedIndexChanged);
            // 
            // forpictures
            // 
            this.forpictures.FormattingEnabled = true;
            this.forpictures.Location = new System.Drawing.Point(33, 196);
            this.forpictures.Name = "forpictures";
            this.forpictures.Size = new System.Drawing.Size(397, 212);
            this.forpictures.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 534);
            this.Controls.Add(this.forpictures);
            this.Controls.Add(this.listBoxfordirectories);
            this.Controls.Add(this.pictureBoxrightside);
            this.Controls.Add(this.pictureBoxlefside);
            this.Controls.Add(this.pictureBoxMainbox);
            this.Controls.Add(this.textBoxtimeforslideshow);
            this.Controls.Add(this.buttonplay);
            this.Controls.Add(this.buttonrefresh);
            this.Controls.Add(this.checkBoxisloop);
            this.Controls.Add(this.buttonnextpic);
            this.Controls.Add(this.buttonpreviouspic);
            this.Controls.Add(this.buttonremovedir);
            this.Controls.Add(this.buttonadddir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Picture Viewer";
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlefside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxrightside)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonadddir;
        private System.Windows.Forms.Button buttonremovedir;
        private System.Windows.Forms.Button buttonpreviouspic;
        private System.Windows.Forms.Button buttonnextpic;
        private System.Windows.Forms.CheckBox checkBoxisloop;
        private System.Windows.Forms.Button buttonrefresh;
        private System.Windows.Forms.Button buttonplay;
        private System.Windows.Forms.TextBox textBoxtimeforslideshow;
        private System.Windows.Forms.PictureBox pictureBoxMainbox;
        private System.Windows.Forms.PictureBox pictureBoxlefside;
        private System.Windows.Forms.PictureBox pictureBoxrightside;
        private System.DirectoryServices.DirectoryEntry directoryEntrydir;
        private System.Windows.Forms.ListBox listBoxfordirectories;
        private System.Windows.Forms.ListBox forpictures;
    }
}

