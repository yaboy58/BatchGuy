using BatchGuy.App.X264Log.Interfaces;
using BatchGuy.App.X264Log.Models;
using BatchGuy.App.X264Log.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BatchGuy.X264Log.Parser.Example.Console.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //line item identifier service used to identify the line type read from log file
            IX264LogLineItemIdentifierService x264LogLineItemIdentifierService = new X264LogLineItemIdentifierService();
            
            //x264 log file settings
            X264LogFileSettings x264LogFileSerttings = new X264LogFileSettings() { BBCodeBoldLogFileName = true, BBCodeHiddenAroundLogs = true };
            
            //log files
            List<X264LogFile> logFiles = new List<X264LogFile>() { 
                new X264LogFile() { FileNameOnly = "Les Revenants S02E01 The Child 720p BluRay DTS x264.mkv.x264.log", FilePath = @"C:\temp\My Encodes\Blu-ray\Les Revenants S02E01 The Child 720p BluRay DTS x264.mkv.x264.log" }, 
                new X264LogFile() { FileNameOnly = "Les Revenants S02E02 Milan 720p BluRay DTS x264.mkv.x264.log", FilePath = @"C:\temp\My Encodes\Blu-ray\Les Revenants S02E02 Milan 720p BluRay DTS x264.mkv.x264.log" },
                new X264LogFile() {  FileNameOnly = "Les Revenants S02E03 Morgane 720p BluRay DTS x264.mkv.x264.log", FilePath = @"C:\temp\My Encodes\Blu-ray\Les Revenants S02E03 Morgane 720p BluRay DTS x264.mkv.x264.log" }, 
                new X264LogFile() {  FileNameOnly = "Les Revenants S02E04 Virgil 720p BluRay DTS x264.mkv.x264.log", FilePath = @"C:\temp\My Encodes\Blu-ray\Les Revenants S02E04 Virgil 720p BluRay DTS x264.mkv.x264.log" }, 
                new X264LogFile() {  FileNameOnly = "Les Revenants S02E05 Madame Costa 720p BluRay DTS x264.mkv.x264.log", FilePath = @"C:\temp\My Encodes\Blu-ray\Les Revenants S02E05 Madame Costa 720p BluRay DTS x264.mkv.x264.log" },
                new X264LogFile() {  FileNameOnly = "Les Revenants S02E06 Esther 720p BluRay DTS x264.mkv.x264.log", FilePath = @"C:\temp\My Encodes\Blu-ray\Les Revenants S02E06 Esther 720p BluRay DTS x264.mkv.x264.log" }, 
                new X264LogFile() {  FileNameOnly = "Les Revenants S02E07 Étienne 720p BluRay DTS x264.mkv.x264.log", FilePath = @"C:\temp\My Encodes\Blu-ray\Les Revenants S02E07 Étienne 720p BluRay DTS x264.mkv.x264.log" }, 
                new X264LogFile() {  FileNameOnly = "Les Revenants S02E08 Les Revenants 720p BluRay DTS x264.mkv.x264.log", FilePath = @"C:\temp\My Encodes\Blu-ray\Les Revenants S02E08 Les Revenants 720p BluRay DTS x264.mkv.x264.log" }};

            //parser service
            IX264LogParserService parserService = new X264LogParserService(x264LogLineItemIdentifierService, x264LogFileSerttings, logFiles);

            Stopwatch watch = new Stopwatch();
            watch.Start();

            //get log text
            string logs = parserService.GetLogs();                

            if (parserService.Errors.Count() == 0)
            {
                System.Console.WriteLine(logs);
            }
            else
            {
                System.Console.WriteLine(parserService.Errors[0].Description);
            }
            watch.Stop();

            System.Console.WriteLine(string.Format("The process took {0} seconds", watch.Elapsed.TotalSeconds.ToString()));

            System.Console.ReadLine();
        }
    }
}
