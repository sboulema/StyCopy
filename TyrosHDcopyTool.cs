using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StyCopy
{

    public partial class TyrosHDCopy : Form

    {
        public TyrosHDCopy()
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
                progressBar1.Maximum = Directory.EnumerateFiles(folderBrowserDialog1.SelectedPath, $"*.{ExtensieComboBox.Text}", SearchOption.AllDirectories).Count();
                progressBar1.Step = 1;
                
                var files = Directory.EnumerateFiles(folderBrowserDialog1.SelectedPath, $"*.{ExtensieComboBox.Text}", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    containerAListView.Items.Add(file);
                    progressBar1.PerformStep();
                    CountLabelAllFiles.Text = $"{containerAListView.Items.Count}/{progressBar1.Maximum}";
                    CountLabelAllFiles.Update();
                }
            }
        }

        private void AToBButton_Click(object sender, EventArgs e)
        {
            int Teller = Int32.Parse(NumberOfFiles.Text);
            if (containerAListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in containerAListView.SelectedItems)
                {
                    containerAListView.Items.Remove(item);
                    containerBListView.Items.Add(item);
                    progressBar1.Increment(-1);
                    progressBar2.Increment(1);
                    CountLabelAllFiles.Text = ($"{containerAListView.Items.Count}");
                }
            }
            else
            {
                foreach (ListViewItem item in containerAListView.Items.Cast<ListViewItem>().Take(Teller))
                {
                    containerAListView.Items.Remove(item);
                    progressBar1.Increment(-1);
                    progressBar2.Increment(1);
                    containerBListView.Items.Add(item);
                    CountLabelAllFiles.Text = ($"{containerAListView.Items.Count}");
                }
            }
            
            countLabel.Text = $"{containerBListView.Items.Count}//{Teller}";                    
        }

        private void BToAButton_Click(object sender, EventArgs e)
        {
            int Teller = Int32.Parse(NumberOfFiles.Text);
            foreach (ListViewItem item in containerBListView.SelectedItems)
            {
                containerBListView.Items.Remove(item);
                progressBar2.Increment(-1);
                progressBar1.Increment(1);
                containerAListView.Items.Add(item);
                CountLabelAllFiles.Text = ($"{containerAListView.Items.Count}");
            }
            countLabel.Text = $"{containerBListView.Items.Count}/{Teller}";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int amountOfFiles = containerAListView.Items.Count;
            int maxAmountOfFilesInFolder = int.Parse(NumberOfFiles.Text);
            int neededFolders = (amountOfFiles / maxAmountOfFilesInFolder) + 1;

            for (int i = 0; i < neededFolders; i++)
            {
                foreach (var item in containerAListView.Items.Cast<ListViewItem>().Skip(i * maxAmountOfFilesInFolder).Take(maxAmountOfFilesInFolder))
                {
                    Directory.CreateDirectory(Path.Combine(OverAllDirPath.Text, $"Files{i}"));
                    File.Copy(item.Text, Path.Combine(OverAllDirPath.Text, $"Files{i}", Path.GetFileName(item.Text)), true);
                }
            }                  
        }

        private void containerAListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Teller = Int32.Parse(NumberOfFiles.Text);
            
            if (containerAListView.SelectedItems.Count + containerBListView.Items.Count > 500)
            {
                AToBButton.Enabled = false;
            }
            else
            {
                AToBButton.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NumberOfFiles_keypress(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExtensieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void TyrosHDCopy_Load(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog2.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                OverAllDirPath.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void CountLabelAllFiles_Click(object sender, EventArgs e)
        {
            
        }

        private void OverAllDirPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
