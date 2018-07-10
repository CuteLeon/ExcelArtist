using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

using System.IO;
using System.Drawing;
using OfficeOpenXml;

namespace ExcelArtist
{
    public class EPPlusImage2ExcelArtist : Artist
    {   
        public override BackgroundWorker ArtistWorker { get; } = new BackgroundWorker()
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true,
        };

        public EPPlusImage2ExcelArtist()
        {
            ArtistWorker.DoWork += new DoWorkEventHandler(ArtistWorker_DoWork);
        }
        
        public override void Vary(string inPath, string outPath)
        {
            ArtistWorker.RunWorkerAsync(new VaryObject() { InPath = inPath, OutPath = outPath });
        }

        private void ArtistWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string ImagePath = (e.Argument as VaryObject).InPath;
            string ExcelPath = (e.Argument as VaryObject).OutPath;
            string WorkName = Path.GetFileNameWithoutExtension(ImagePath);
            int LastProgressPersent = -1, ProgressPercent = 0;

            //加载图像
            Bitmap OriginalImage;
            using (FileStream ImageStream = new FileStream(ImagePath, FileMode.Open))
                OriginalImage = Bitmap.FromStream(ImageStream) as Bitmap;
            if (OriginalImage == null) throw new Exception("加载图片文件失败：" + ImagePath);

            //缩小图像，太大了处理费时
            if(OriginalImage.Height>200)
                OriginalImage = new Bitmap(OriginalImage, new Size(200 * OriginalImage.Width / OriginalImage.Height, 200));

            using (ExcelPackage excel = new ExcelPackage(new FileInfo(ExcelPath)))
            {
                //设置文档属性
                OfficeProperties properties = excel.Workbook.Properties;
                properties.Author = "Leon - Excel Artist";
                properties.Category = "Leon - Excel Artist";
                properties.Comments = "此表格由 ExcelArtist 生成，访问：https://github.com/CuteLeon/ExcelArtist";
                properties.Company = "Leon - Excel Artist";
                properties.Created = DateTime.Now;
                properties.HyperlinkBase = new Uri("https://github.com/CuteLeon/ExcelArtist");
                properties.Manager = "Leon - Excel Artist";
                properties.Subject = WorkName + " - Leon";
                properties.Title = WorkName + " - Leon";
                if (ArtistWorker.CancellationPending) { e.Cancel = true; return; }

                string ImageHash = OriginalImage.GetHashCode().ToString("X");
                //初始化表
                if (excel.Workbook.Worksheets.FirstOrDefault(s => s.Name == ImageHash) != null)
                    excel.Workbook.Worksheets.Delete(ImageHash);
                excel.Workbook.Worksheets.Add(ImageHash);
                ExcelWorksheet sheet = excel.Workbook.Worksheets[ImageHash];
                if (sheet == null) throw new Exception("创建 Sheet 失败");

                /* 注意：
                 * 查阅资料得知，[X,Y] 从1开始，不是0
                 * Excel行高和列宽单位不统一，需要特殊设置
                 * ( 基础设置：RowHeight=1 & ColumnWidth=0.1 )
                 */

                //设置默认列宽和行高
                //sheet.DefaultColWidth = 0.7;
                //sheet.DefaultRowHeight = 4.2;
                if (ArtistWorker.CancellationPending) { e.Cancel = true; return; }

                //开始核心任务
                using (ExcelRange range = sheet.Cells[1, 1, OriginalImage.Height, OriginalImage.Width])
                {
                    //设置列宽和行高
                    for (int Column = 0; Column < OriginalImage.Width; Column++)
                        sheet.Column(Column + 1).Width = 0.35; ;
                    for (int Line = 0; Line < OriginalImage.Height; Line++)
                        sheet.Row(Line + 1).Height = 2.1;
                    if (ArtistWorker.CancellationPending) { e.Cancel = true; return; }

                    for (int Line = 0; Line < OriginalImage.Height; Line++)
                    {
                        for (int Column = 0; Column < OriginalImage.Width; Column++)
                        {
                            //System.Diagnostics.Debug.Print("第 {0} 行, 第 {1} 列", Line, Column);
                            range[Line + 1, Column + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            range[Line + 1, Column + 1].Style.Fill.BackgroundColor.SetColor(OriginalImage.GetPixel(Column, Line));
                            if (ArtistWorker.CancellationPending) { e.Cancel = true; return; }
                        }

                        ProgressPercent = 100 * Line / OriginalImage.Height;
                        if (LastProgressPersent != ProgressPercent)
                        {
                            LastProgressPersent = ProgressPercent;
                            //System.Diagnostics.Debug.Print("报告进度：" + ProgressPercent);
                            ArtistWorker.ReportProgress(LastProgressPersent);
                        }
                    }
                }
                if (ArtistWorker.CancellationPending) { e.Cancel = true; return; }

                //保存文档
                excel.Save();
            }
        }

    }
}
