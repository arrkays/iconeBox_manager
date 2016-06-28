using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iconeBox_manager
{
    class R
    {
        public static string ici;
        public static List<Box> boxToRemove = new List<Box>();

        public static void log(string log)
        {
            Debug.WriteLine(log);
        }

        public static void cp(string source, string dest)
        {
            cmd("copy /y \"" + source + "\" \"" + dest + "\"");
        }

        public static void cpd(string source, string dest)
        {
            string folderToCopy = source.Substring(source.LastIndexOf("\\") + 1);

            //Directory.CreateDirectory(folderToCopy);
            cmd("XCOPY /E /H /K /C /Y \"" + source + "\" \"" + dest + "\\" + folderToCopy + "\\\"");
        }

        static void cmd(string command)
        {
            R.log("cmd   " + command);
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            //processInfo.RedirectStandardError = true;
            //processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            process.WaitForExit();
            process.Close();
        }
    }

}
