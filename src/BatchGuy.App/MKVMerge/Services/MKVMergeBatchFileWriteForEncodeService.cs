using BatchGuy.App.MKVMerge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Eac3To.Abstracts;
using log4net;
using BatchGuy.App.Eac3To.Models;
using BatchGuy.App.Eac3to.Models;
using System.IO;
using System.Reflection;
using BatchGuy.App.X264.Models;

namespace BatchGuy.App.MKVMerge.Services
{
    public class MKVMergeBatchFileWriteForEncodeService : IMKVMergeBatchFileWriteService
    {
        private ErrorCollection _errors = new ErrorCollection();
        private List<BluRayDiscInfo> _bluRayDiscInfoList;
        private EAC3ToConfiguration _eac3toConfiguration;
        private IDirectorySystemService _directorySystemService;
        private IAudioService _audioService;
        private AbstractEAC3ToOutputNamingService _eac3ToOutputNamingService;
        private BatchGuyEAC3ToSettings _batchGuyEAC3ToSettings;

        public static readonly ILog _log = LogManager.GetLogger(typeof(MKVMergeBatchFileWriteForEncodeService));

        public ErrorCollection Errors
        {
            get { return _errors; }
        }

        public MKVMergeBatchFileWriteForEncodeService(BatchGuyEAC3ToSettings batchGuyEAC3ToSettings, IDirectorySystemService directorySystemService, IAudioService audioService, AbstractEAC3ToOutputNamingService eac3ToOutputNamingService)
        {
            _batchGuyEAC3ToSettings = batchGuyEAC3ToSettings;
            _bluRayDiscInfoList = _batchGuyEAC3ToSettings.BluRayDiscs;
            _eac3toConfiguration = _batchGuyEAC3ToSettings.EAC3ToSettings;
            _directorySystemService = directorySystemService;
            _audioService = audioService;
            _eac3ToOutputNamingService = eac3ToOutputNamingService;
            _errors = new ErrorCollection();
        }

        public ErrorCollection Write()
        {
            if (this.IsValid())
            {
                try
                {
                    this.Delete();

                    foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
                    {
                        foreach (BluRaySummaryInfo summary in disc.BluRaySummaryInfoList.Where(s => s.IsSelected).OrderBy(s => s.EpisodeNumber))
                        {
                            IMKVMergeOutputService mkvMergeOutputService = new MKVMergeOutputService(_eac3toConfiguration, _eac3ToOutputNamingService, disc.BluRayPath, summary);
                            string mkvMergePathPart = mkvMergeOutputService.GetMKVMergePathPart();
                            string mkvMergeOutputPart = mkvMergeOutputService.GetOutputPart();
                            string mkvMergeVideoPart = mkvMergeOutputService.GetVideoPart();
                            string mkvMergeAudioPart = mkvMergeOutputService.GetAudioPart();
                            string mkvMergeSubtitlePart = mkvMergeOutputService.GetSubtitlePart();
                            string mkvMergeChaptersPart = mkvMergeOutputService.GetChaptersPart();
                            string mkvMergeTrackOrderPart = mkvMergeOutputService.GetTrackOrderPart();

                            using (StreamWriter sw = new StreamWriter(_eac3toConfiguration.MKVMergeBatchFilePath, true))
                            {
                                sw.WriteLine(string.Format("{0} {1} {2} {3} {4} {5} {6}", mkvMergePathPart, mkvMergeOutputPart, mkvMergeVideoPart, mkvMergeAudioPart, mkvMergeSubtitlePart,
                                    mkvMergeChaptersPart, mkvMergeTrackOrderPart));
                                sw.WriteLine();
                                sw.WriteLine();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, MethodBase.GetCurrentMethod().Name);
                    _errors.Add(new Error() { Description = "There was an error while creating the mkvmerge batch file." });
                }
            }
            return _errors;
        }

        public bool IsValid()
        {
            if (!this.IsAtLeastOneDiscSelected())
                return false;
            if (!this.IsAtLeastOneSummarySelected())
                return false;
            if (!this.WhenSummarySelectedAtLeastOneStreamSelected())
                return false;
            if (!this.IsAllBluRayEpisodeNumbersSet())
                return false;
            if (!this.IsAllBluRayPathsValid())
                return false;
            if (!this.IsAllX264EpisodeNumbersSet())
                return false;
            if (!this.IsAllX264EpisodeNumbersUnique())
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

        private bool IsAllBluRayEpisodeNumbersSet()
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
                this._errors.Add(new Error() { Description = "Episode number not set for all titles." });
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

        private bool IsAllX264EpisodeNumbersSet()
        {
            bool isValid = true;

            foreach (X264File file in _batchGuyEAC3ToSettings.X264Files)
            {
                if (file.EpisodeNumber == null || file.EpisodeNumber == string.Empty)
                {
                    isValid = false;
                }
            }

            if (!isValid)
            {
                this._errors.Add(new Error() { Description = "Episode number not set for all AviSynth Files on the Create x264 Batch File Screen." });
            }
            return isValid;
        }

        private bool IsAllX264EpisodeNumbersUnique()
        {
            bool isValid = true;

            foreach (X264File file in _batchGuyEAC3ToSettings.X264Files)
            {
                if (_batchGuyEAC3ToSettings.X264Files.Where(f => f.EpisodeNumber == file.EpisodeNumber).Count() > 1)
                {
                    isValid = false;
                }
            }

            if (!isValid)
            {
                this._errors.Add(new Error() { Description = "Episode number not unique for all AviSynth Files on the Create x264 Batch File Screen." });
            }
            return isValid;
        }

        public void Delete()
        {
            if (File.Exists(_eac3toConfiguration.MKVMergeBatchFilePath))
                File.Exists(_eac3toConfiguration.MKVMergeBatchFilePath);
        }
    }
}
