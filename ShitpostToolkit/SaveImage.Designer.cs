using System.ComponentModel;

namespace ShitpostToolkit
{
    partial class SaveImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.Pathbox = new System.Windows.Forms.TextBox();
            this.Choosefilebutton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.saveImgDialog = new System.Windows.Forms.SaveFileDialog();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.UpdateHelpCheck = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize) (this.UpdateHelpCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // Pathbox
            // 
            this.Pathbox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.Pathbox.Location = new System.Drawing.Point(12, 12);
            this.Pathbox.Name = "Pathbox";
            this.Pathbox.ReadOnly = true;
            this.Pathbox.Size = new System.Drawing.Size(287, 20);
            this.Pathbox.TabIndex = 0;
            // 
            // Choosefilebutton
            // 
            this.Choosefilebutton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Choosefilebutton.Location = new System.Drawing.Point(305, 12);
            this.Choosefilebutton.Name = "Choosefilebutton";
            this.Choosefilebutton.Size = new System.Drawing.Size(75, 23);
            this.Choosefilebutton.TabIndex = 1;
            this.Choosefilebutton.Text = "Choose";
            this.Choosefilebutton.UseVisualStyleBackColor = true;
            this.Choosefilebutton.Click += new System.EventHandler(this.Choosefilebutton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 38);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(368, 124);
            this.checkedListBox1.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(12, 169);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(368, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // saveImgDialog
            // 
            this.saveImgDialog.DefaultExt = "png";
            this.saveImgDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" + " *.png";
            this.saveImgDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveImgDialog_FileOk);
            // 
            // HelpLabel
            // 
            this.HelpLabel.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpLabel.Location = new System.Drawing.Point(12, 199);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(368, 23);
            this.HelpLabel.TabIndex = 4;
            // 
            // UpdateHelpCheck
            // 
            this.UpdateHelpCheck.Enabled = true;
            this.UpdateHelpCheck.Interval = 10D;
            this.UpdateHelpCheck.SynchronizingObject = this;
            // 
            // SaveImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 231);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Choosefilebutton);
            this.Controls.Add(this.Pathbox);
            this.Name = "SaveImage";
            this.Text = "SaveImage";
            ((System.ComponentModel.ISupportInitialize) (this.UpdateHelpCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Timers.Timer UpdateHelpCheck;

        private System.Windows.Forms.Label HelpLabel;

        private System.Windows.Forms.TextBox Pathbox;

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog saveImgDialog;

        private System.Windows.Forms.CheckedListBox checkedListBox1;

        private System.Windows.Forms.Button Choosefilebutton;

        #endregion
    }
}