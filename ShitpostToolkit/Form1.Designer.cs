namespace ShitpostToolkit
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.IntroPage = new System.Windows.Forms.TabPage();
            this.Changelog = new System.Windows.Forms.RichTextBox();
            this.ImagePage = new System.Windows.Forms.TabPage();
            this.containerControl1 = new System.Windows.Forms.ContainerControl();
            this.imagePreview = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VideoPage = new System.Windows.Forms.TabPage();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.IntroPage.SuspendLayout();
            this.ImagePage.SuspendLayout();
            this.containerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.imagePreview)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.IntroPage);
            this.tabControl1.Controls.Add(this.ImagePage);
            this.tabControl1.Controls.Add(this.VideoPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // IntroPage
            // 
            this.IntroPage.Controls.Add(this.Changelog);
            this.IntroPage.Location = new System.Drawing.Point(4, 22);
            this.IntroPage.Name = "IntroPage";
            this.IntroPage.Padding = new System.Windows.Forms.Padding(3);
            this.IntroPage.Size = new System.Drawing.Size(704, 406);
            this.IntroPage.TabIndex = 0;
            this.IntroPage.Text = "Intro";
            this.IntroPage.UseVisualStyleBackColor = true;
            // 
            // Changelog
            // 
            this.Changelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Changelog.Location = new System.Drawing.Point(3, 3);
            this.Changelog.Name = "Changelog";
            this.Changelog.ReadOnly = true;
            this.Changelog.Size = new System.Drawing.Size(698, 400);
            this.Changelog.TabIndex = 0;
            this.Changelog.Text = "";
            this.Changelog.WordWrap = false;
            // 
            // ImagePage
            // 
            this.ImagePage.Controls.Add(this.containerControl1);
            this.ImagePage.Controls.Add(this.menuStrip1);
            this.ImagePage.Location = new System.Drawing.Point(4, 22);
            this.ImagePage.Name = "ImagePage";
            this.ImagePage.Padding = new System.Windows.Forms.Padding(3);
            this.ImagePage.Size = new System.Drawing.Size(704, 406);
            this.ImagePage.TabIndex = 1;
            this.ImagePage.Text = "Image";
            this.ImagePage.UseVisualStyleBackColor = true;
            // 
            // containerControl1
            // 
            this.containerControl1.AutoScroll = true;
            this.containerControl1.Controls.Add(this.imagePreview);
            this.containerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerControl1.Location = new System.Drawing.Point(3, 27);
            this.containerControl1.Name = "containerControl1";
            this.containerControl1.Size = new System.Drawing.Size(698, 376);
            this.containerControl1.TabIndex = 2;
            this.containerControl1.Text = "containerControl1";
            // 
            // imagePreview
            // 
            this.imagePreview.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("imagePreview.BackgroundImage")));
            this.imagePreview.Location = new System.Drawing.Point(0, 0);
            this.imagePreview.Name = "imagePreview";
            this.imagePreview.Size = new System.Drawing.Size(698, 376);
            this.imagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imagePreview.TabIndex = 0;
            this.imagePreview.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.openToolStripMenuItem, this.saveToolStripMenuItem, this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // VideoPage
            // 
            this.VideoPage.Location = new System.Drawing.Point(4, 22);
            this.VideoPage.Name = "VideoPage";
            this.VideoPage.Padding = new System.Windows.Forms.Padding(3);
            this.VideoPage.Size = new System.Drawing.Size(704, 406);
            this.VideoPage.TabIndex = 2;
            this.VideoPage.Text = "Video";
            this.VideoPage.UseVisualStyleBackColor = true;
            // 
            // openImage
            // 
            this.openImage.DefaultExt = "png";
            this.openImage.FileName = "image";
            this.openImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" + " *.png";
            this.openImage.Title = "Open an image";
            this.openImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openImage_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 432);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Shitposting Toolkit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.IntroPage.ResumeLayout(false);
            this.ImagePage.ResumeLayout(false);
            this.ImagePage.PerformLayout();
            this.containerControl1.ResumeLayout(false);
            this.containerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.imagePreview)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ContainerControl containerControl1;

        private System.Windows.Forms.PictureBox imagePreview;

        private System.Windows.Forms.OpenFileDialog openImage;

        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;

        private System.Windows.Forms.RichTextBox Changelog;

        private System.Windows.Forms.TabPage ImagePage;
        private System.Windows.Forms.TabPage IntroPage;
        private System.Windows.Forms.TabPage VideoPage;

        private System.Windows.Forms.TabControl tabControl1;

        #endregion
    }
}