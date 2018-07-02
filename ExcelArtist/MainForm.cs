using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelArtist
{
    public partial class MainForm : CCWin.Skin_Mac
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ImageTextBox_ButtonClicked()
        {
            using (var ImageDialog = new OpenFileDialog() {
                Title = ImageTextBox.Watermark.Text,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "*.jpg",
                Filter = "所有文件|*.*|JPG 图像文件|*.jpg|JPEG 图像文件|*.jpeg|PNG 图像文件|*.png|GIF 图像文件|*.gif|BMP 图像文件|*.bmp|TIFF 图像文件|*.tiff",
                Multiselect = false,
            })
            {
                if (ImageDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageTextBox.Text = ImageDialog.FileName;
                }
            }
        }

        private void DocumentTextBox_ButtonClicked()
        {
            using (var DocumentDialog = new SaveFileDialog()
            {
                Title = DocumentTextBox.Watermark.Text,
                AddExtension = true,
                AutoUpgradeEnabled = true,
                CheckPathExists = true,
                Filter = "Excel 表格文件|*.xls",
                FileName = string.IsNullOrEmpty(ImageTextBox.Text) ? string.Empty : 
                    Path.GetFileNameWithoutExtension(ImageTextBox.Text) + "_ExcelArtist",
                DefaultExt = ".xls",
                OverwritePrompt = true

            })
            {
                if (DocumentDialog.ShowDialog() == DialogResult.OK)
                {
                    DocumentTextBox.Text = DocumentDialog.FileName;
                }
            }
        }

        private void TaskButton_Click(object sender, EventArgs e)
        {

        }
    }
}
