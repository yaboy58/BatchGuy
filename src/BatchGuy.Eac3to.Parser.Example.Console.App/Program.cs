using BatchGuy.App.Eac3to.Interfaces;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3to.Services;
using BatchGuy.App.Eac3To.Abstracts;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Eac3To.Services;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Models;
using BatchGuy.App.MKVMerge.Services;
using BatchGuy.App.Parser.Interfaces;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Parser.Services;
using BatchGuy.App.Shared.Interface;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.Eac3to.Parser.Example.Console.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //config
            string batchFilePath = @"C:\temp\My Encodes\Blu-ray";
            string bluRayDiscPath = @"C:\temp\My Encodes\Blu-ray\DISC\D1";
            string eac3ToPath = @"C:\exe\eac3to\eac3to.exe";
            EAC3ToConfiguration eac3toConfiguation = new EAC3ToConfiguration()
            {
                BatchFilePath = batchFilePath,
                EAC3ToPath = eac3ToPath,
                 IsExtractForRemux = false
            };


            //Main object
            List<BluRayDiscInfo> bluRayDiscList = new List<BluRayDiscInfo>();

            BluRayDiscInfo bluRayDisc = new BluRayDiscInfo()
            {
                Id = 1,
                IsSelected = true,
                BluRayPath = bluRayDiscPath
            };
            bluRayDiscList.Add(bluRayDisc);

            //Build command line for blu ray summary ie eac3to disc
            CommandLineProcessStartInfo commandLineProcessStartInfoSummary = new CommandLineProcessStartInfo() 
            { 
                FileName = eac3ToPath,
                Arguments = string.Format("\"{0}\"", bluRayDiscPath)
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
                bluRayDisc.BluRaySummaryInfoList = parserServiceSummary.GetSummaryList();

                //Loop and output summary list if we choose
                foreach (var summary in bluRayDisc.BluRaySummaryInfoList)
                {
                    //System.Console.WriteLine(string.Format("Header: {0}",summary.HeaderText)); //write out if we choose
                    //System.Console.WriteLine(string.Format("Detail: {0}", summary.DetailText)); //write out if we choose
                }

                //Build command line for blu ray title ie eac3to disc1 1)
                CommandLineProcessStartInfo commandLineProcessStartInfoTitle = new CommandLineProcessStartInfo()
                {
                    FileName = eac3ToPath,
                    Arguments = string.Format("\"{0}\" {1}", bluRayDiscPath, bluRayDisc.BluRaySummaryInfoList[1].Eac3ToId)
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

                    //language service
                    IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
                    IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
                    //This service is used to identify the title line type ie audio, video, subtitle etc etc
                    ILineItemIdentifierService lineItemServiceTitle = new BluRayTitleLineItemIdentifierService();
                    //This service will parse the line items and return an info object that tells about the specific title
                    IBluRayTitleParserService parserServiceTitle = new BluRayTitleParserService(lineItemServiceTitle, processOutputLineItemsTitle, languageService);
                    //Get the title info object
                    bluRayDisc.BluRaySummaryInfoList[1].BluRayTitleInfo = parserServiceTitle.GetTitleInfo();
                    if (bluRayDisc.BluRaySummaryInfoList[1].BluRayTitleInfo != null)
                    {
                        //System.Console.WriteLine(string.Format("Title: {0}",bluRayDisc.BluRaySummaryInfoList[1].BluRayTitleInfo.HeaderText)); //print header text if we choose too
                        //System.Console.WriteLine(string.Format("Chapters Id: {0}", bluRayDisc.BluRaySummaryInfoList[1].BluRayTitleInfo.Chapter.Id)); //print chapter id if we choose too
                        //System.Console.WriteLine(string.Format("Video Id: {0}", bluRayDisc.BluRaySummaryInfoList[1].BluRayTitleInfo.Video.Id)); //print video id if we choose too
                        //System.Console.WriteLine(string.Format("Audio1 ID and Language: {0} - {1}",bluRayDisc.BluRaySummaryInfoList[1].BluRayTitleInfo.AudioList[0].Id, bluRayDisc.BluRaySummaryInfoList[1].BluRayTitleInfo.AudioList[0].Language)); //print audio id/language if we choose too
                        //System.Console.WriteLine(string.Format("Subtitle1 ID and Language: {0} - {1}", bluRayDisc.BluRaySummaryInfoList[1].BluRayTitleInfo.Subtitles[0].Id, bluRayDisc.BluRaySummaryInfoList[1].BluRayTitleInfo.Subtitles[0].Language)); //print subtitle id/language if we choose too
                        //can also print out other fields for testing
                    }

                    //select/set items
                    bluRayDiscList[0].IsSelected = true;
                    bluRayDiscList[0].BluRaySummaryInfoList[1].IsSelected = true;
                    bluRayDiscList[0].BluRaySummaryInfoList[1].BluRayTitleInfo.Video.IsSelected = true;
                    bluRayDiscList[0].BluRaySummaryInfoList[1].BluRayTitleInfo.Chapter.IsSelected = true;
                    bluRayDiscList[0].BluRaySummaryInfoList[1].BluRayTitleInfo.EpisodeNumber = "1";
                    foreach (BluRayTitleAudio audio in bluRayDiscList[0].BluRaySummaryInfoList[1].BluRayTitleInfo.AudioList)
                    {
                        audio.IsSelected = true;
                    }
                    foreach (BluRayTitleSubtitle subtitle in bluRayDiscList[0].BluRaySummaryInfoList[1].BluRayTitleInfo.Subtitles)
                    {
                        subtitle.IsSelected = true;
                    }

                    //now time to write out the batch file
                    IDirectorySystemService directorySystemService = new DirectorySystemService();
                    IAudioService audioService = new AudioService();
                    AbstractEAC3ToOutputNamingService eac3ToOutputNamingService = new EncodeTemplate1EAC3ToOutputNamingService(audioService);
                    IEAC3ToBatchFileWriteService batchFileWriteService = new EAC3ToBatchFileWriteService(eac3toConfiguation, directorySystemService, bluRayDiscList, audioService, eac3ToOutputNamingService);
                    batchFileWriteService.Write();
                    if (batchFileWriteService.Errors.Count() == 0)
                    {
                        System.Console.WriteLine("Batch file created successfully!");
                    }
                    else
                    {
                        foreach (var error in batchFileWriteService.Errors)
                        {
                            System.Console.WriteLine(string.Format("Error: {0}", error.Description));
                        }
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
