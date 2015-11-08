using BatchGuy.App.Parser.Interfaces;
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
            ////Blu ray summary streams
            CommandLineProcessStartInfo commandLineProcessStartInfoSummary = new CommandLineProcessStartInfo() 
            { 
                FileName = @"C:\exe\eac3to\eac3to.exe",
                Arguments = @"""C:\temp\My Torrent Encodes\Blu-ray\DISC\Les.Revenants.S02D01.FRENCH.COMPLETE.BLURAY-MELBA"""
            };

            ICommandLineProcessService commandLineProcessServiceSummary = new CommandLineProcessService(commandLineProcessStartInfoSummary);
            
            if (commandLineProcessServiceSummary.Errors.Count() == 0)
            {
                ////Get line items
                List<ProcessOutputLineItem> processOutputLineItemsSummary = commandLineProcessServiceSummary.GetProcessOutputLineItems();
                foreach (var line in processOutputLineItemsSummary)
                {
                    //System.Console.WriteLine(line.Text); //write out if we choose too
                }

                ////Get the Blu ray summary list
                ILineItemIdentifierService lineItemServiceSummary = new BluRaySummaryLineItemIdentifierService();
                IBluRaySummaryParserService parserServiceSummary = new BluRaySummaryParserService(lineItemServiceSummary, processOutputLineItemsSummary);
                List<BluRaySummaryInfo> summaryList = parserServiceSummary.GetSummaryList();

                foreach (var summary in summaryList)
                {
                    //System.Console.WriteLine(string.Format("Header: {0}",summary.HeaderText)); //write out if we choose
                    //System.Console.WriteLine(string.Format("Detail: {0}", summary.DetailText)); //write out if we choose
                }

                ////Blu ray title stream
                CommandLineProcessStartInfo commandLineProcessStartInfoTitle = new CommandLineProcessStartInfo()
                {
                    FileName = @"C:\exe\eac3to\eac3to.exe",
                    Arguments = string.Format(@"""C:\temp\My Torrent Encodes\Blu-ray\DISC\Les.Revenants.S02D01.FRENCH.COMPLETE.BLURAY-MELBA"" {0}", summaryList[1].Id)
                };

                ICommandLineProcessService commandLineProcessServiceTitle = new CommandLineProcessService(commandLineProcessStartInfoTitle);

                if (commandLineProcessServiceTitle.Errors.Count() == 0)
                {
                    ////Get line items
                    List<ProcessOutputLineItem> processOutputLineItemsIndividual = commandLineProcessServiceTitle.GetProcessOutputLineItems();
                    foreach (var line in processOutputLineItemsIndividual)
                    {
                        System.Console.WriteLine(line.Text); //write out if we choose too
                    }
                }
                else
                {
                    System.Console.WriteLine("The following errors were found:");
                    foreach (var error in commandLineProcessServiceTitle.Errors)
                    {
                        System.Console.WriteLine(error.Description);
                    }
                }

            }
            else
            {
                System.Console.WriteLine("The following errors were found:");
                foreach (var error in commandLineProcessServiceSummary.Errors)
                {
                    System.Console.WriteLine(error.Description);
                }
            }


            System.Console.Read();
        }
    }
}
