using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.IO.Compression;
using System.Diagnostics;

namespace DboxLinkMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateTips();
        }

        private void CreateTips()
        {
            InputLinkBox.ForeColor = Color.Gray;
            InputLinkBox.Text = "Insert link here!";

            OutputLinkBox.ForeColor = Color.Gray;
            OutputLinkBox.Text = "Converted link will be here!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InputLinkBox.Text != "")
            {
                string firstlink = "";
                firstlink = InputLinkBox.Text.Remove(0,26);
                firstlink = firstlink.Remove(firstlink.Length - 5, 5);
                string secondlink = "https://dl.dropboxusercontent.com/s/" + firstlink + "?dl=1";
                OutputLinkBox.Text = secondlink;
                OutputLinkBox.SelectAll();
                OutputLinkBox.Copy();
                StatusTextBox.Text = "New link has been copied to clipboard!";

                Int32 FirstValue = LinkList.Items.Count;

                if (LinkList.Items.Contains(OutputLinkBox.Text))
                { }
                else
                {
                    LinkList.Items.Add(OutputLinkBox.Text);

                }

                Int32 SecondValue = LinkList.Items.Count;

                if (SecondValue > FirstValue)
                {
                    if (LinkList.Items.Count >= 2)
                    {
                        LinkListPanel.Height = LinkListPanel.Height + 13;
                        LinkList.Height = LinkList.Height + 13;
                        this.Height = this.Height + 13;
                    }
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           StatusTextBox.Text = LinkList.SelectedItem.ToString();
            StatusTextBox.SelectAll();
            StatusTextBox.Copy();
            StatusTextBox.Text = "Copied to clipboard: " + LinkList.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportLinksToFile();
            MessageBox.Show("All links are exported in ExportedLinks.txt , which is in same directory as this application.");
            Process.Start(Application.StartupPath);
        }

        private void ExportLinksToFile()
        {
            OutTxt.Text = "====== " + DateTime.Now.ToString("dd/MM/yyyy") + " / " + string.Format("{0:HH:mm:ss tt}", DateTime.Now) + "======" + Environment.NewLine;

            foreach (var item in LinkList.Items)
            {
                OutTxt.Text = OutTxt.Text + item.ToString() + Environment.NewLine;              
            }

            OutTxt.Text = OutTxt.Text + "===================================" + Environment.NewLine;

            if (File.Exists("ExportedLinks.txt"))
                OutTxt.Text = OutTxt.Text + Environment.NewLine + File.ReadAllText("ExportedLinks.txt");

            File.WriteAllText("ExportedLinks.txt", OutTxt.Text);
        }

        private void InputLinkBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (InputLinkBox.Text == "Insert link here!")
            {
                InputLinkBox.ForeColor = Color.Black;
                InputLinkBox.Text = "";
            }
        }

        private void InputLinkBox_Leave(object sender, EventArgs e)
        {
            if (InputLinkBox.Text == "")
            {
                InputLinkBox.ForeColor = Color.Gray;
                InputLinkBox.Text = "Insert link here!";
            }
        }
    }
}
 