using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

using Microsoft.Office;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Drawing;

namespace ExcelArtist
{
    public class Image2ExcelArtist : Artist
    {
        Application application;
        Workbook workbook;
        Worksheet worksheet;

        public override BackgroundWorker ArtistWorker { get; } = new BackgroundWorker()
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true,
        };

        public Image2ExcelArtist()
        {
            ArtistWorker.DoWork += new DoWorkEventHandler(ArtistWorker_DoWork);
        }

        private void CreateExcel(string ImageName)
        {
            application = new Application();
            
            workbook = application.Workbooks.Add(true);
            //TODO: 在这里给文档增加打开密码
            //workbook.Password = "testpass";
            workbook.Title = ImageName + " - Leon";
            workbook.Author = "Leon-ExcelArtist";
            workbook.Comments = "此表格由 ExcelArtist 生成，访问：https://github.com/CuteLeon/ExcelArtist";

            worksheet = workbook.ActiveSheet;
            worksheet.Name = ImageName + "_Leon";
        }

        private void SaveAndCloseExcel(string ExcelPath)
        {
            application.DisplayAlerts = false;
            application.EnableLargeOperationAlert = false;
            application.AlertBeforeOverwriting = false;
            workbook.SaveAs(ExcelPath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            workbook.Close();
            application.Quit();
        }

        public override void Vary(string inPath, string outPath)
        {
            ArtistWorker.RunWorkerAsync(new VaryObject() { InPath = inPath, OutPath = outPath });
        }

        private void ArtistWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string ImagePath = (e.Argument as VaryObject).InPath;
            string ExcelPath = (e.Argument as VaryObject).OutPath;
            int LastProgressPersent = -1, ProgressPercent = 0;

            //加载图像
            Bitmap OriginalImage;
            using (FileStream ImageStream = new FileStream(ImagePath, FileMode.Open))
                OriginalImage = Bitmap.FromStream(ImageStream) as Bitmap;
            if (OriginalImage == null) throw new Exception("加载图片文件失败：" + ImagePath);

            //创建表格
            CreateExcel(Path.GetFileNameWithoutExtension(ImagePath));
            
            //核心：遍历图像像素并转存到Excel
            for (int Y = 0; Y < OriginalImage.Height; Y++)
            {
                for (int X = 0; X < OriginalImage.Width; X++)
                {
                    //System.Diagnostics.Debug.Print(OriginalImage.GetPixel(X, Y).ToString());
                }

                ProgressPercent = 100 * Y / OriginalImage.Height;
                if (LastProgressPersent != ProgressPercent)
                {
                    LastProgressPersent = ProgressPercent;
                    System.Diagnostics.Debug.Print("报告进度：" + ProgressPercent);
                    ArtistWorker.ReportProgress(LastProgressPersent);
                }
            }

            //保存并关闭表格文件
            SaveAndCloseExcel(ExcelPath);
        }

    }
}
