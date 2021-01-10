using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ShitpostToolkit
{
    public partial class SaveImage : Form
    {
        private Image img;
        public SaveImage(Image imageToSave)
        {
            img = imageToSave;
            InitializeComponent();
        }

        private void Choosefilebutton_Click(object sender, EventArgs e)
        {
            saveImgDialog.ShowDialog();
        }

        private void saveImgDialog_FileOk(object sender, CancelEventArgs e)
        {
            Pathbox.Text = saveImgDialog.FileName;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Pathbox.Text != String.Empty)
            {
                Image imageModified = img;
                imageModified.Save(saveImgDialog.FileName);
                MessageBox.Show("Saved to " + saveImgDialog.FileName, "Saved");
            }
            else
            {
                MessageBox.Show("Please select a file", "No file error");
            }
        }
    }
}