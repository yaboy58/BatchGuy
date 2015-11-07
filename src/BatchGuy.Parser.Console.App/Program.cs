using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.Parser.Console.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string error = string.Empty;

            ProcessStartInfo cmdStartInfo = new ProcessStartInfo();
            //cmdStartInfo.CreateNoWindow = false;
            cmdStartInfo.UseShellExecute = false;
            cmdStartInfo.FileName = @"C:\exe\eac3to\eac3to.exe";
            cmdStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //cmdStartInfo.Arguments = @"""C:\temp\My Torrent Downloads\War.Pigs.2015.COMPLETE.BLURAY""";
            cmdStartInfo.Arguments = @"""\\KENSHIRO\My Torrent Encodes\Blu-ray\DISC\ARN_D1-BluHD""";

            cmdStartInfo.CreateNoWindow = true;
            cmdStartInfo.RedirectStandardOutput = true;
            cmdStartInfo.RedirectStandardError = true;
            cmdStartInfo.RedirectStandardInput = true;
            cmdStartInfo.UseShellExecute = false;

            Process process = Process.Start(cmdStartInfo);
            using (StreamReader streamReader = process.StandardOutput)
            {
                int i = 1;
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                   System.Console.WriteLine(line);
                    i++;
                }
            }

            using (StreamReader streamReader = process.StandardError)
            {
                error = streamReader.ReadToEnd();
            }


            if (!string.IsNullOrEmpty(error))
            {
                System.Console.WriteLine("The following error was detected:");
                System.Console.WriteLine(error);
            }

            System.Console.Read();
        }
    }
}
