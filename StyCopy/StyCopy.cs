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
                containerAListView.Clear();

                progressBar1.Value = 0;
                progressBar1.Maximum = Directory.EnumerateFiles(folderBrowserDialog1.SelectedPath, $"*.{extensionTextBox.Text}", SearchOption.AllDirectories).Count();
                progressBar1.Step = 1;

                var files = Directory.EnumerateFiles(folderBrowserDialog1.SelectedPath, $"*.{extensionTextBox.Text}", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    containerAListView.Items.Add(file);
                    progressBar1.PerformStep();
                    label1.Text = $"{containerAListView.Items.Count}/{progressBar1.Maximum}";
                    label1.Update();
                }
            }
        }

        private void AToBButton_Click(object sender, EventArgs e)
        {
            if (containerAListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in containerAListView.SelectedItems)
                {
                    containerAListView.Items.Remove(item);
                    containerBListView.Items.Add(item);
                }
            }
            else
            {
                foreach (ListViewItem item in containerAListView.Items.Cast<ListViewItem>().Take(500))
                {
                    containerAListView.Items.Remove(item);
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
                containerAListView.Items.Add(item);
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
            if (containerAListView.SelectedItems.Count + containerBListView.Items.Count > 500)
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
