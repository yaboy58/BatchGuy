using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.EAC.Models;
using System.IO;
using BatchGuy.App.Helpers;
using BatchGuy.App.EAC.Interfaces;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Parser.Models;

namespace BatchGuy.App.EAC.Services
{
    public class BatchFileWriteService : IBatchFileWriteService
    {
        private List<Error> _errors = new List<Error>();
        private List<BluRayDiscInfo> _bluRayDiscInfoList;

        public List<Error> Errors
        {
            get { return _errors; }
        }
        
        public BatchFileWriteService(List<BluRayDiscInfo> bluRayDiscInfo)
        {
            _bluRayDiscInfoList = bluRayDiscInfo;
            _errors = new List<Error>();
        }

        public List<Error> Write()
        {
            if (this.IsValid())
            {
                try
                {
                    /*TODO: Do you really want to delete files without the user's permission?
                    if (File.Exists(_bluRayDiscInfoList[0].EAC3ToConfiguration.BatchFilePath))
                    {
                        File.Delete(_bluRayDiscInfoList[0].EAC3ToConfiguration.BatchFilePath);
                        File.Create(_bluRayDiscInfoList[0].EAC3ToConfiguration.BatchFilePath);
                    }
                    */
                    foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
                    {
                        foreach (BluRaySummaryInfo summary in disc.BluRaySummaryInfoList.Where(s => s.IsSelected))
                        {
                            IEAC3ToOutputService eacOutputService = new EAC3ToOutputService(disc.EAC3ToConfiguration, summary.Id, summary.BluRayTitleInfo);
                            string eac3ToPathPart = eacOutputService.GetEAC3ToPathPart();
                            string bluRayStreamPart = eacOutputService.GetBluRayStreamPart();
                            string chapterStreamPart = eacOutputService.GetChapterStreamPart();
                            string videoStreamPart = eacOutputService.GetVideoStreamPart();
                            string audioStreamPart = eacOutputService.GetAudioStreamPart();
                            string subtitleStreamPart = eacOutputService.GetSubtitleStreamPart();

                            using (StreamWriter sw = new StreamWriter(string.Format("{0}\\bluray.bat",disc.EAC3ToConfiguration.BatchFilePath), true))
                            {
                                sw.WriteLine(string.Format("{0} {1} {2} {3} {4} {5} -progressnumbers", eac3ToPathPart, bluRayStreamPart, chapterStreamPart, videoStreamPart, audioStreamPart,
                                    subtitleStreamPart));
                                sw.WriteLine();
                                sw.WriteLine();
                            }
                        }
                    } 
                }
                catch (Exception ex)
                {
                    //introduce logging at some point
                    _errors.Add(new Error() { Description = string.Format("Error occurred: {0}", ex.Message) });
                }
            }
            return _errors;
        }

        public bool IsValid()
        {
            if (!this.IsAtLeastOneDiscSelected())
                return false;
            if (!this.IsAtLeastOneEpisodeSelected())
                return false;
            if (!this.IsAllEpisodeNumbersSet())
                return false;

            return true;
        }

        private bool IsAtLeastOneDiscSelected()
        {
            bool isValid = true;

            if (_bluRayDiscInfoList.Where(d => d.IsSelected).Count() == 0)
            {
                isValid = false;
                this._errors.Add(new Error() { Description = "No Disc was selected." });
            }
            return isValid;
        }

        private bool IsAtLeastOneEpisodeSelected()
        {
            bool isValid = false;

            foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
            {
                if (disc.BluRaySummaryInfoList.Where(s => s.IsSelected).Count() > 0)
                {
                    isValid = true;
                }                
            }

            if (!isValid)
            {
                this._errors.Add(new Error() { Description="No episodes selected." });
            }
            return isValid;
        }

        private bool IsAllEpisodeNumbersSet()
        {
            bool isValid = true;

            foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
            {
                foreach (BluRaySummaryInfo info in disc.BluRaySummaryInfoList.Where(s => s.IsSelected))
                {
                    if (((info.EpisodeNumber == string.Empty || info.EpisodeNumber == null)  && info.BluRayTitleInfo.Video.IsSelected))
                    {
                        isValid = false;
                    }
                }
            }

            if (!isValid)
            {
                this._errors.Add(new Error() { Description = "Episode not set for all titles." });
            }
            return isValid;
        }
    }
}
