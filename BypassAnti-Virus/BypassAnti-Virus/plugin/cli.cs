using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BypassAnti_Virus.plugin
{
    internal class CLI
    {
        public static bool Powershell(string arg)
        {
            System.Diagnostics.Process Process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "powershell.exe";
            startInfo.Arguments = arg;
            Process.StartInfo = startInfo;
            Process.Start();
            return true;
        }
        public static bool CommandPrompt(string arg)
        {
            System.Diagnostics.Process Process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = arg;
            Process.StartInfo = startInfo;
            Process.Start();
            return true;
        }
    }
}
