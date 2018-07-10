using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelArtist
{
    public partial class MainForm : CCWin.Skin_Mac
    {
        private enum TaskStates
        {
            NoTask = 0,
            Working =1,
            Finished=2,
        }

        private TaskStates _taskState = TaskStates.NoTask;
        private TaskStates TaskState
        {
            get => _taskState;
            set
            {
                _taskState = value;
                switch (value)
                {
                    case TaskStates.NoTask:
                        {
                            ImageTextBox.Enabled = true;
                            DocumentTextBox.Enabled = true;
                            TaskButton.Text = "开始";
                            TaskProgressBar.Value = 0;
                            TaskProgressBar.Hide();
                            break;
                        }
                    case TaskStates.Working:
                        {
                            ImageTextBox.Enabled = false;
                            DocumentTextBox.Enabled = false;
                            TaskButton.Text = "取消";
                            TaskProgressBar.Show();
                            TaskProgressBar.Value = 0;
                            break;
                        }
                    case TaskStates.Finished:
                        {
                            ImageTextBox.Enabled = true;
                            DocumentTextBox.Enabled = true;
                            TaskProgressBar.Show();
                            TaskProgressBar.Value = 100;
                            break;
                        }
                }
                this.Refresh();
            }
        }

        Artist ExcelArtist;

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
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
                Filter = "Excel 表格文件|*.xlsx",
                FileName = string.IsNullOrEmpty(ImageTextBox.Text) ? string.Empty : 
                    Path.GetFileNameWithoutExtension(ImageTextBox.Text) + "_ExcelArtist",
                DefaultExt = ".xlsx",
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
            if (TaskState == TaskStates.NoTask)
            {
                try
                {
                    if (!File.Exists(ImageTextBox.Text))
                        throw new Exception("图像路径不存在，请重新选择...");
                    if (string.IsNullOrEmpty(DocumentTextBox.Text))
                        throw new Exception("文档存储路径为空，请重新选择...");
                    if (!Directory.Exists(Path.GetDirectoryName(DocumentTextBox.Text)))
                        throw new Exception("文档存储目录不存在，请重新选择...");
                }
                catch (Exception ex)
                {
                    CCWin.MessageBoxEx.Show(ex.Message, "遇到异常：");
                    return;
                }

                //ExcelArtist = new Image2ExcelArtist();
                ExcelArtist = new EPPlusImage2ExcelArtist();
                ExcelArtist.ArtistWorker.ProgressChanged += new ProgressChangedEventHandler(ArtistWorker_ProgressChanged);
                ExcelArtist.ArtistWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ExcelArtist_RunWorkerCompleted);

                TaskState = TaskStates.Working;
                ExcelArtist.Vary(ImageTextBox.Text, DocumentTextBox.Text);
            }
            else if (TaskState == TaskStates.Working)
            {
                ExcelArtist.ArtistWorker.CancelAsync();
            }
            else if (TaskState == TaskStates.Finished)
            {
                TaskState = TaskStates.NoTask;
            }
        }

        private void ArtistWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //System.Diagnostics.Debug.Print("接受进度：{0}", e.ProgressPercentage);
            TaskProgressBar.Value = e.ProgressPercentage;
            TaskProgressBar.Invalidate();
        }

        private void ExcelArtist_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                TaskState = TaskStates.Finished;
                if (e.Error != null)
                {
                    TaskButton.Text = "任务异常";
                    TaskButton.Refresh();
                    CCWin.MessageBoxEx.Show(e.Error.Message, "任务执行期间遇到异常：");
                    return;
                }
                TaskButton.Text = e.Cancelled ? "取消任务" : "任务完成";
                TaskButton.Refresh();
                CCWin.MessageBoxEx.Show(TaskButton.Text);
                TaskState = TaskStates.NoTask;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("任务结束遇到异常：{0}", ex.Message);
            }
            finally
            {
                ExcelArtist = null;
                GC.Collect();
            }
        }

        private void ImageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ImageTextBox.Text)) return;
            DocumentTextBox.Text = string.Format(
                "{0}\\{1}_ExcelArtist.xlsx",
                Path.GetDirectoryName(ImageTextBox.Text),
                Path.GetFileNameWithoutExtension(ImageTextBox.Text));
        }
    }
}
