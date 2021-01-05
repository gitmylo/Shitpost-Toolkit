using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShitpostToolkit
{
    public partial class Form1 : Form
    {
        private double version = 0.01;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String changelogTxt = "Could not retrieve info at this time";
            try
            {
                using (WebClient client = new WebClient())
                {
                    Stream response = client.OpenRead(
                        "https://raw.githubusercontent.com/gitmylo/Shitpost-Toolkit/master/ShitpostToolkit/Readme.stpt");
                    StreamReader responseReader = new StreamReader(response);
                    changelogTxt = "your current running version: " + version + Environment.NewLine;
                    while (!responseReader.EndOfStream)
                    {
                        changelogTxt += responseReader.ReadLine();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            Changelog.Text = changelogTxt;
        }
    }
}