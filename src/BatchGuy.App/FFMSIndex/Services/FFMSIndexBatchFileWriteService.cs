using BatchGuy.App.FFMSIndex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Eac3To.Abstracts;
using log4net;
using System.IO;
using System.Reflection;
using BatchGuy.App.Eac3to.Interfaces;
using BatchGuy.App.Eac3to.Services;

namespace BatchGuy.App.FFMSIndex.Services
{
    public class FFMSIndexBatchFileWriteService : IFFMSIndexBatchFileWriteService
    {
        private ErrorCollection _errors = new ErrorCollection();
        private List<BluRayDiscInfo> _bluRayDiscInfoList;
        private EAC3ToConfiguration _eac3toConfiguration;
        private IDirectorySystemService _directorySystemService;
        private AbstractEAC3ToOutputNamingService _eac3ToOutputNamingService;

        public static readonly ILog _log = LogManager.GetLogger(typeof(FFMSIndexBatchFileWriteService));

        public ErrorCollection Errors
        {
            get { return _errors; }
        }

        public FFMSIndexBatchFileWriteService(EAC3ToConfiguration eac3toConfiguration, IDirectorySystemService directorySystemService, List<BluRayDiscInfo> bluRayDiscInfo, AbstractEAC3ToOutputNamingService eac3ToOutputNamingService)
        {
            _bluRayDiscInfoList = bluRayDiscInfo;
            _eac3toConfiguration = eac3toConfiguration;
            _directorySystemService = directorySystemService;
            _eac3ToOutputNamingService = eac3ToOutputNamingService;
            _errors = new ErrorCollection();
        }

        public ErrorCollection Write()
        {
            if (_eac3toConfiguration.ShouldCreateFFMSIndexBatchFile && this.IsValid())
            {
                try
                {
                    this.Delete();

                    foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
                    {
                        foreach (BluRaySummaryInfo summary in disc.BluRaySummaryInfoList.Where(s => s.IsSelected).OrderBy(s => s.EpisodeNumber))
                        {
                            IEAC3ToOutputService eacOutputService = new EAC3ToOutputService(_eac3toConfiguration, _eac3ToOutputNamingService, disc.BluRayPath, summary);
                            string videoStreamPart = eacOutputService.GetVideoStreamPart();

                            using (StreamWriter sw = new StreamWriter(_eac3toConfiguration.FFMSIndextBatchFilePath, true))
                            {
                                sw.WriteLine(string.Format("\"{0}\" -f -v {1}",_eac3toConfiguration.FFMSIndexPath, videoStreamPart));
                                sw.WriteLine();
                                sw.WriteLine();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, MethodBase.GetCurrentMethod().Name);
                    _errors.Add(new Error() { Description = "There was an error while creating the ffmsindex batch file." });
                }
            }
            return _errors;
        }

        public bool IsValid()
        {
            if (!this.IsFFMSIndexExePathValid())
                return false;
            if (!this.IsAtLeastOneDiscSelected())
                return false;
            if (!this.IsAtLeastOneSummarySelected())
                return false;
            if (!this.WhenSummarySelectedAtLeastOneStreamSelected())
                return false;
            if (!this.IsAllEpisodeNumbersSet())
                return false;
            if (!this.IsAllBluRayPathsValid())
                return false;

            return true;
        }

        private bool IsFFMSIndexExePathValid()
        {
            bool isValid = true;
            if (!File.Exists(_eac3toConfiguration.FFMSIndextBatchFilePath))
                isValid = false;

            if (!isValid)
            {
                this._errors.Add(new Error() { Description = "Could not find the ffmsindex.exe." });
            }

            return isValid;
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

        private bool IsAtLeastOneSummarySelected()
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
                this._errors.Add(new Error() { Description = "No episodes selected." });
            }
            return isValid;
        }

        private bool WhenSummarySelectedAtLeastOneStreamSelected()
        {
            bool isValid = false;

            foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
            {
                foreach (BluRaySummaryInfo summary in disc.BluRaySummaryInfoList.Where(s => s.IsSelected))
                {
                    if (summary.BluRayTitleInfo != null && summary.BluRayTitleInfo.Video.IsSelected)
                    {
                        isValid = true;
                    }
                    if (summary.BluRayTitleInfo != null && summary.BluRayTitleInfo.AudioList != null && summary.BluRayTitleInfo.AudioList.Where(a => a.IsSelected).Count() > 0)
                    {
                        isValid = true;
                    }
                    if (summary.BluRayTitleInfo != null && summary.BluRayTitleInfo.Subtitles != null && summary.BluRayTitleInfo.Subtitles.Where(s => s.IsSelected).Count() > 0)
                    {
                        isValid = true;
                    }
                    if (summary.BluRayTitleInfo != null && summary.BluRayTitleInfo.Chapter != null && summary.BluRayTitleInfo.Chapter.IsSelected)
                    {
                        isValid = true;
                    }
                    if (!isValid)
                    {
                        this._errors.Add(new Error() { Description = "Some selected titles have no streams selected." });
                        return isValid;
                    }
                    isValid = false;
                }

            }
            return true;
        }

        private bool IsAllEpisodeNumbersSet()
        {
            bool isValid = true;

            foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
            {
                foreach (BluRaySummaryInfo info in disc.BluRaySummaryInfoList.Where(s => s.IsSelected))
                {
                    if (info.EpisodeNumber == null)
                    {
                        isValid = false;
                    }
                }
            }

            if (!isValid)
            {
                this._errors.Add(new Error() { Description = "Episode number not set for all selected titles." });
            }
            return isValid;
        }

        private bool IsAllBluRayPathsValid()
        {
            bool isValid = true;

            foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
            {
                foreach (BluRaySummaryInfo info in disc.BluRaySummaryInfoList.Where(s => s.IsSelected))
                {
                    if (info.BluRayTitleInfo != null)
                    {
                        if ((info.BluRayTitleInfo.AudioList != null && info.BluRayTitleInfo.AudioList.Where(a => a.IsSelected).Count() > 0) || (info.BluRayTitleInfo.Chapter != null && info.BluRayTitleInfo.Chapter.IsSelected)
                            || (info.BluRayTitleInfo.Subtitles != null && info.BluRayTitleInfo.Subtitles.Where(s => s.IsSelected).Count() > 0) || (info.BluRayTitleInfo.Video != null && info.BluRayTitleInfo.Video.IsSelected))
                        {
                            if (!_directorySystemService.Exists(disc.BluRayPath))
                                isValid = false;
                        }
                    }
                }
            }

            if (!isValid)
            {
                this._errors.Add(new Error() { Description = "Invalid Blu-ray disc directories found." });
            }
            return isValid;
        }

        public void Delete()
        {
            if (File.Exists(_eac3toConfiguration.FFMSIndextBatchFilePath))
                File.Delete(_eac3toConfiguration.FFMSIndextBatchFilePath);
        }
    }
}
