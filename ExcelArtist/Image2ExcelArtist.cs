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
        Range range;

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
            if (application == null) throw new Exception("无法启动 Excel.");

            application.DisplayAlerts = false;
            application.EnableLargeOperationAlert = false;
            application.AlertBeforeOverwriting = false;
            //会显示Excel窗口并显示逐行打印的效果
            application.Visible = true;
            
            workbook = application.Workbooks.Add(true);
            //TODO: 在这里给文档增加打开密码
            //workbook.Password = "testpass";
            workbook.Title = ImageName + " - Leon";
            workbook.Author = "Leon-ExcelArtist";
            workbook.Comments = "此表格由 ExcelArtist 生成，访问：https://github.com/CuteLeon/ExcelArtist";

            worksheet = workbook.ActiveSheet;
            worksheet.Name = ImageName + "_Leon";

            range = worksheet.Range["A1","A1"];
        }

        private void SaveAndCloseExcel(string ExcelPath)
        {
            range.EntireColumn.AutoFit();
            workbook.SaveAs(ExcelPath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            CloseExcel();
        }

        private void CloseExcel()
        {
            workbook.Close();
            application.Quit();

            range = null;
            workbook = null;
            worksheet = null;
            application = null;
            
            GC.Collect();
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

            //缩小图像，太大了处理费时
            if(OriginalImage.Height>100)
                OriginalImage = new Bitmap(OriginalImage, new Size(100 * OriginalImage.Width / OriginalImage.Height, 100));
            
            //创建表格
            CreateExcel(Path.GetFileNameWithoutExtension(ImagePath));

            /* 注意：
             * 查阅资料得知，[X,Y] 从1开始，不是0
             * Excel行高和列宽单位不统一，需要特殊设置
             * ( 基础设置：RowHeight=1 & ColumnWidth=0.1 )
             */
            range = range.Resize[OriginalImage.Width, OriginalImage.Height];

            if (ArtistWorker.CancellationPending) { e.Cancel = true; CloseExcel(); return; }
            //设置行高
            for (int Line = 1; Line <= OriginalImage.Height; Line++)
                range.Rows[Line].RowHeight = 4.2;

            if (ArtistWorker.CancellationPending) { e.Cancel = true; CloseExcel(); return; }
            //设置列宽
            for (int Column = 1; Column <= OriginalImage.Width; Column++)
                range.Columns[Column].ColumnWidth = 0.4;

            if (ArtistWorker.CancellationPending) { e.Cancel = true; CloseExcel(); return; }
            for (int Line = 0; Line < OriginalImage.Height; Line++)
            {
                for (int Column = 0; Column < OriginalImage.Width; Column++)
                {
                    //System.Diagnostics.Debug.Print("第 {0} 行, 第 {1} 列", Line, Column);
                    range.Cells[Line + 1, Column + 1].Interior.Color = OriginalImage.GetPixel(Column, Line);
                    if (ArtistWorker.CancellationPending) { e.Cancel = true; CloseExcel(); return; }
                }

                ProgressPercent = 100 * Line / OriginalImage.Height;
                if (LastProgressPersent != ProgressPercent)
                {
                    LastProgressPersent = ProgressPercent;
                    //System.Diagnostics.Debug.Print("报告进度：" + ProgressPercent);
                    ArtistWorker.ReportProgress(LastProgressPersent);
                }
            }
            
            //if (ArtistWorker.CancellationPending) { e.Cancel = true; return; }
            //保存并关闭表格文件
            SaveAndCloseExcel(ExcelPath);
        }

    }
}
