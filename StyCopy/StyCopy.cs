using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StyCopy
{
    public partial class StyCopy : Form
    {
        public StyCopy()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, $"*.{extensionTextBox.Text}", SearchOption.AllDirectories);
                containerAListBox.DataSource = files;
                label1.Text = files.Count().ToString();
            }
        }

        private void AToBButton_Click(object sender, EventArgs e)
        {
            if (containerAListBox.SelectedItems.Count > 0)
            {
                foreach (string file in containerAListBox.SelectedItems)
                {
                    containerAListBox.Items.Remove(file);
                    containerBListView.Items.Add(file);
                }
            }
            else
            {
                foreach (string item in containerAListBox.Items.Cast<string>().Take(500))
                {
                    containerAListBox.Items.Remove(item);
                    containerBListView.Items.Add(item);
                }
            }
            
            countLabel.Text = $"{containerBListView.Items.Count}/500";                    
        }

        private void BToAButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in containerBListView.SelectedItems)
            {
                containerBListView.Items.Remove(item);
                containerAListBox.Items.Add(item);
            }
            countLabel.Text = $"{containerBListView.Items.Count}/500";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (ListViewItem item in containerBListView.Items)
                {
                    File.Copy(item.Text, Path.Combine(folderBrowserDialog1.SelectedPath, Path.GetFileName(item.Text)));
                }

                containerBListView.Clear();
            }
            countLabel.Text = $"{containerBListView.Items.Count}/500";
        }

        private void containerAListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (containerAListBox.SelectedItems.Count + containerBListView.Items.Count > 500)
            {
                AToBButton.Enabled = false;
            }
            else
            {
                AToBButton.Enabled = true;
            }
        }
    }
}
