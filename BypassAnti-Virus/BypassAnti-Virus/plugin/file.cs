using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BypassAnti_Virus.plugin
{
    internal class file
    {
        public static bool download(string url,string path)
        {
            using (WebClient client = new WebClient())
            {
                //Download The File
                client.DownloadFile(url, path);
                Thread.Sleep(1000);
                if (File.Exists(path))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
