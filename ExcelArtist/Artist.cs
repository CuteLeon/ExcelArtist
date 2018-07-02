using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelArtist
{
    /// <summary>
    /// 艺术家
    /// </summary>
    public abstract class Artist
    {
        public class VaryObject
        {
            public string InPath;
            public string OutPath;
        }

        public abstract BackgroundWorker ArtistWorker { get; }

        /// <summary>
        /// 变化
        /// </summary>
        /// <param name="InPath">输入路径</param>
        /// <param name="OutPath">输出路径</param>
        public abstract void Vary(string InPath, string OutPath);

    }
}
