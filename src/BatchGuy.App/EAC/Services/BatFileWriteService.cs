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
    public class BatFileWriteService : IBatFileWriteService
    {
        private List<Error> _errors = new List<Error>();
        private List<BluRayDiscInfo> _bluRayDiscInfoList;

        public BatFileWriteService(List<BluRayDiscInfo> bluRayDiscInfo)
        {
            _bluRayDiscInfoList = bluRayDiscInfo;
            _errors = new List<Error>();
        }

        public List<Error> Write()
        {
            if (File.Exists(_bluRayDiscInfoList[0].EAC3ToConfiguration.BatFilePath))
            {
                File.Delete(_bluRayDiscInfoList[0].EAC3ToConfiguration.BatFilePath);
                File.Create(_bluRayDiscInfoList[0].EAC3ToConfiguration.BatFilePath);
            }
            foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
            {
                foreach (BluRaySummaryInfo summary in disc.BluRaySummaryInfoList.Where(s => s.IsSelected))
                {
                    IEACOutputService eacOutputService = new EACOutputService(disc.EAC3ToConfiguration, summary.Id, summary.BluRayTitleInfo);
                    string eac3ToPathPart = eacOutputService.GetEAC3ToPathPart();
                    string bluRayStreamPart = eacOutputService.GetBluRayStreamPart();
                    string chapterStreamPart = eacOutputService.GetChapterStreamPart();
                    string videoStreamPart = eacOutputService.GetVideoStreamPart();
                    string audioStreamPart = eacOutputService.GetAudioStreamPart();
                    string subtitleStreamPart = eacOutputService.GetSubtitleStreamPart();

                    using (StreamWriter sw = new StreamWriter(disc.EAC3ToConfiguration.BatFilePath, true))
                    {
                        sw.WriteLine(string.Format("{0} {1} {2} {3} {4} {5} -progressnumbers", eac3ToPathPart, bluRayStreamPart, chapterStreamPart, videoStreamPart, audioStreamPart,
                            subtitleStreamPart));
                        sw.WriteLine();
                        sw.WriteLine();
                    }                    
                }
            }
            return _errors;
        }

        public bool IsValid()
        {
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
                foreach (BluRaySummaryInfo info in disc.BluRaySummaryInfoList)
                {
                    if (info.EpisodeNumber == string.Empty)
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
