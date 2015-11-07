using BatchGuy.App.Parser.Models;
using BatchGuy.App.Parser.Services;
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
            ////:Blu ray streams
            CommandLineProcessStartInfo commandLineProcessStartInfo1 = new CommandLineProcessStartInfo() { FileName = @"C:\exe\eac3to\eac3to.exe", 
                Arguments = @"""\\KENSHIRO\My Torrent Encodes\Blu-ray\DISC\ARN_D1-BluHD""" };

            ICommandLineProcessService commandLineProcessService1 = new CommandLineProcessService(commandLineProcessStartInfo1);
            
            if (commandLineProcessService1.Errors.Count() == 0)
            {
                List<ProcessOutputLineItem> processOutputLineItem = commandLineProcessService1.GetProcessOutputLineItems();
                foreach (var line in processOutputLineItem)
                {
                    System.Console.WriteLine(line.Text);
                }
            }
            else
            {
                System.Console.WriteLine("The following errors were found:");
                foreach (var error in commandLineProcessService1.Errors)
                {
                    System.Console.WriteLine(error.Description);
                }
            }


            System.Console.Read();
        }
    }
}
