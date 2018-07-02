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

        private void CloseAndSaveExcel(string ExcelPath)
        {
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
            string ExcelPath = (e.Argument as VaryObject).OutPath;
            CreateExcel(Path.GetFileNameWithoutExtension(ExcelPath));
            CloseAndSaveExcel(ExcelPath);
            return;
            int i = 0;
            while (i < 100)
            {
                if (ArtistWorker.CancellationPending)
                {
                    e.Cancel = true;
                    //e.Result = null;
                    return;
                }
                else
                {
                    i += 10;
                    if (i == 60)
                        throw new Exception("2783462347");
                    ArtistWorker.ReportProgress(i);
                    System.Diagnostics.Debug.Print("报告进度：{0}", i);
                    System.Threading.Thread.Sleep(500);
                }
            }
        }

    }
}
