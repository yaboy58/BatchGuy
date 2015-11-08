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
            CommandLineProcessStartInfo commandLineProcessStartInfo1 = new CommandLineProcessStartInfo() 
            { 
                FileName = @"C:\exe\eac3to\eac3to.exe",
                Arguments = @"""C:\temp\My Torrent Encodes\Blu-ray\DISC\Les.Revenants.S02D01.FRENCH.COMPLETE.BLURAY-MELBA"""
            };

            ICommandLineProcessService commandLineProcessService1 = new CommandLineProcessService(commandLineProcessStartInfo1);
            
            if (commandLineProcessService1.Errors.Count() == 0)
            {
                ////Get line items
                List<ProcessOutputLineItem> processOutputLineItems1 = commandLineProcessService1.GetProcessOutputLineItems();
                foreach (var line in processOutputLineItems1)
                {
                    //System.Console.WriteLine(line.Text); write out if we choose too
                }

                ////Get the Blu ray summary list
                ILineItemIdentifierService lineItemService = new BluRaySummaryLineItemIdentifierService();
                IBluRaySummaryParserService parserService = new BluRaySummaryParserService(lineItemService, processOutputLineItems1);
                List<BluRaySummaryInfo> summaryList = parserService.GetSummaryList();

                foreach (var summary in summaryList)
                {
                    System.Console.WriteLine(string.Format("Header: {0}",summary.HeaderText));
                    System.Console.WriteLine(string.Format("Detail: {0}", summary.DetailText));    
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
