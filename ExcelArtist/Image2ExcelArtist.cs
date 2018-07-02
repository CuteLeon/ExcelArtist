using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

using Microsoft.Office;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;

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

        private void CreateExcel()
        {
            application = new Application();
            workbook = application.Workbooks.Add(true);
            worksheet = workbook.ActiveSheet;
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
            CreateExcel();
            CloseAndSaveExcel((e.Argument as VaryObject).OutPath);
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
