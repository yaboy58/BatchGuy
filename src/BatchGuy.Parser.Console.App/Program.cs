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
            //Build command line for blu ray summary ie eac3to disc
            CommandLineProcessStartInfo commandLineProcessStartInfoSummary = new CommandLineProcessStartInfo() 
            { 
                FileName = @"C:\exe\eac3to\eac3to.exe",
                Arguments = @"""C:\temp\My Torrent Encodes\Blu-ray\DISC\Les.Revenants.S02D01.FRENCH.COMPLETE.BLURAY-MELBA"""
            };

            //Service will allow you to get each line outputted on the screen
            ICommandLineProcessService commandLineProcessServiceSummary = new CommandLineProcessService(commandLineProcessStartInfoSummary);
            
            //Checking eac3to errors
            if (commandLineProcessServiceSummary.Errors.Count() == 0)
            {
                //Get line items outputted on screen for blu ray summary
                List<ProcessOutputLineItem> processOutputLineItemsSummary = commandLineProcessServiceSummary.GetProcessOutputLineItems();
                foreach (var line in processOutputLineItemsSummary)
                {
                    //System.Console.WriteLine(line.Text); //write out if we choose too
                }

                //Group the summary line items ie 1), 2) etc etc
                ILineItemIdentifierService lineItemServiceSummary = new BluRaySummaryLineItemIdentifierService();
                IBluRaySummaryParserService parserServiceSummary = new BluRaySummaryParserService(lineItemServiceSummary, processOutputLineItemsSummary);
                List<BluRaySummaryInfo> summaryList = parserServiceSummary.GetSummaryList();

                //Loop and output summary list if we choose
                foreach (var summary in summaryList)
                {
                    //System.Console.WriteLine(string.Format("Header: {0}",summary.HeaderText)); //write out if we choose
                    //System.Console.WriteLine(string.Format("Detail: {0}", summary.DetailText)); //write out if we choose
                }

                //Build command line for blu ray title ie eac3to disc1 1)
                CommandLineProcessStartInfo commandLineProcessStartInfoTitle = new CommandLineProcessStartInfo()
                {
                    FileName = @"C:\exe\eac3to\eac3to.exe",
                    Arguments = string.Format(@"""C:\temp\My Torrent Encodes\Blu-ray\DISC\Les.Revenants.S02D01.FRENCH.COMPLETE.BLURAY-MELBA"" {0}", summaryList[1].Id)
                };

                //Service will allow you to get each line outputted on the screen
                ICommandLineProcessService commandLineProcessServiceTitle = new CommandLineProcessService(commandLineProcessStartInfoTitle);

                //Check for errors
                if (commandLineProcessServiceTitle.Errors.Count() == 0)
                {
                    //Get outputted lines
                    List<ProcessOutputLineItem> processOutputLineItemsTitle = commandLineProcessServiceTitle.GetProcessOutputLineItems();
                    //Loop and output lines if we choose too
                    foreach (var line in processOutputLineItemsTitle)
                    {
                        //System.Console.WriteLine(line.Text); //write out if we choose too
                    }

                    //This service is used to identify the title line type ie audio, video, subtitle etc etc
                    ILineItemIdentifierService lineItemServiceTitle = new BluRayTitleLineItemIdentifierService();
                    //This service will parse the line items and return an info object that tells about the specific title
                    IBluRayTitleParserService parserServiceTitle = new BluRayTitleParserService(lineItemServiceTitle, processOutputLineItemsTitle);
                    //Get the title info object
                    BluRayTitleInfo info = parserServiceTitle.GetTitleInfo();
                    if (info != null)
                    {
                        System.Console.WriteLine(string.Format("Title: {0}",info.HeaderText)); //print header text if we choose too
                        System.Console.WriteLine(string.Format("Chapters Id: {0}", info.Chapter.Id)); //print chapter id if we choose too
                        System.Console.WriteLine(string.Format("Video Id: {0}", info.Video.Id)); //print video id if we choose too
                        System.Console.WriteLine(string.Format("Audio1 ID and Language: {0} - {1}",info.AudioList[0].Id, info.AudioList[0].Language)); //print audio id/language if we choose too
                        System.Console.WriteLine(string.Format("Subtitle1 ID and Language: {0} - {1}", info.Subtitles[0].Id, info.Subtitles[0].Language)); //print subtitle id/language if we choose too
                        //can also print out other fields for testing
                    }
                }
                else
                {
                    //title parsing errors
                    System.Console.WriteLine("The following errors were found:");
                    foreach (var error in commandLineProcessServiceTitle.Errors)
                    {
                        System.Console.WriteLine(error.Description);
                    }
                }
            }
            else
            {
                //summary parsing errors
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
