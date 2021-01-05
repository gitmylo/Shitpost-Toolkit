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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.IntroPage = new System.Windows.Forms.TabPage();
            this.ImagePage = new System.Windows.Forms.TabPage();
            this.VideoPage = new System.Windows.Forms.TabPage();
            this.Changelog = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.IntroPage.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(731, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // IntroPage
            // 
            this.IntroPage.Controls.Add(this.Changelog);
            this.IntroPage.Location = new System.Drawing.Point(4, 22);
            this.IntroPage.Name = "IntroPage";
            this.IntroPage.Padding = new System.Windows.Forms.Padding(3);
            this.IntroPage.Size = new System.Drawing.Size(723, 413);
            this.IntroPage.TabIndex = 0;
            this.IntroPage.Text = "Intro";
            this.IntroPage.UseVisualStyleBackColor = true;
            // 
            // ImagePage
            // 
            this.ImagePage.Location = new System.Drawing.Point(4, 22);
            this.ImagePage.Name = "ImagePage";
            this.ImagePage.Padding = new System.Windows.Forms.Padding(3);
            this.ImagePage.Size = new System.Drawing.Size(723, 413);
            this.ImagePage.TabIndex = 1;
            this.ImagePage.Text = "Image";
            this.ImagePage.UseVisualStyleBackColor = true;
            // 
            // VideoPage
            // 
            this.VideoPage.Location = new System.Drawing.Point(4, 22);
            this.VideoPage.Name = "VideoPage";
            this.VideoPage.Padding = new System.Windows.Forms.Padding(3);
            this.VideoPage.Size = new System.Drawing.Size(723, 413);
            this.VideoPage.TabIndex = 2;
            this.VideoPage.Text = "Video";
            this.VideoPage.UseVisualStyleBackColor = true;
            // 
            // Changelog
            // 
            this.Changelog.AllowNavigation = false;
            this.Changelog.AllowWebBrowserDrop = false;
            this.Changelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Changelog.IsWebBrowserContextMenuEnabled = false;
            this.Changelog.Location = new System.Drawing.Point(3, 3);
            this.Changelog.MinimumSize = new System.Drawing.Size(20, 20);
            this.Changelog.Name = "Changelog";
            this.Changelog.ScriptErrorsSuppressed = true;
            this.Changelog.Size = new System.Drawing.Size(717, 407);
            this.Changelog.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 439);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Shitposting Toolkit";
            this.tabControl1.ResumeLayout(false);
            this.IntroPage.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.WebBrowser Changelog;

        private System.Windows.Forms.TabPage ImagePage;
        private System.Windows.Forms.TabPage IntroPage;
        private System.Windows.Forms.TabPage VideoPage;

        private System.Windows.Forms.TabControl tabControl1;

        #endregion
    }
}