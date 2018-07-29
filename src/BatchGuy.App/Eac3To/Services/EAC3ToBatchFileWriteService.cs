using System;
using System.Collections.Generic;
using System.Linq;
using BatchGuy.App.Eac3to.Models;
using System.IO;
using BatchGuy.App.Eac3to.Interfaces;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Eac3To.Interfaces;
using log4net;
using System.Reflection;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Eac3To.Abstracts;

namespace BatchGuy.App.Eac3to.Services
{
    public class EAC3ToBatchFileWriteService : IEAC3ToBatchFileWriteService
    {
        private ErrorCollection _errors = new ErrorCollection();
        private List<BluRayDiscInfo> _bluRayDiscInfoList;
        private EAC3ToConfiguration _eac3toConfiguration;
        private IDirectorySystemService _directorySystemService;
        private IAudioService _audioService;
        private AbstractEAC3ToOutputNamingService _eac3ToOutputNamingService;
        private IEAC3ToCommonRulesValidatorService _eac3ToCommonRulesValidatorService;

        public static readonly ILog _log = LogManager.GetLogger(typeof(EAC3ToBatchFileWriteService));

        public ErrorCollection Errors
        {
            get { return _errors; }
        }

        public EAC3ToBatchFileWriteService(EAC3ToConfiguration eac3toConfiguration, IDirectorySystemService directorySystemService, List<BluRayDiscInfo> bluRayDiscInfo, IAudioService audioService, AbstractEAC3ToOutputNamingService eac3ToOutputNamingService, IEAC3ToCommonRulesValidatorService eac3ToCommonRulesValidatorService)
        {
            _bluRayDiscInfoList = bluRayDiscInfo;
            _eac3toConfiguration = eac3toConfiguration;
            _directorySystemService = directorySystemService;
            _audioService = audioService;
            _eac3ToOutputNamingService = eac3ToOutputNamingService;
            _eac3ToCommonRulesValidatorService = eac3ToCommonRulesValidatorService;
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
                            IEAC3ToOutputService eacOutputService = new EAC3ToOutputService(_eac3toConfiguration, _eac3ToOutputNamingService, disc.BluRayPath, summary);
                            string eac3ToPathPart = eacOutputService.GetEAC3ToPathPart();
                            string bluRayStreamPart = eacOutputService.GetBluRayStreamPart();
                            string chapterStreamPart = eacOutputService.GetChapterStreamPart();
                            string videoStreamPart = eacOutputService.GetVideoStreamPart();
                            string audioStreamPart = eacOutputService.GetAudioStreamPart();
                            string subtitleStreamPart = eacOutputService.GetSubtitleStreamPart();
                            string logPart = eacOutputService.GetLogPart();
                            string showProgressNumbersPart = eacOutputService.GetShowProgressNumbersPart();

                            using (StreamWriter sw = new StreamWriter(_eac3toConfiguration.BatchFilePath, true))
                            {
                                sw.WriteLine(string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", eac3ToPathPart, bluRayStreamPart, chapterStreamPart, videoStreamPart, audioStreamPart,
                                    subtitleStreamPart, logPart, showProgressNumbersPart));
                                sw.WriteLine();
                                sw.WriteLine();
                            }
                        }
                    } 
                }
                catch (Exception ex)
                {
                    _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, ex.StackTrace, MethodBase.GetCurrentMethod().Name);
                    _errors.Add(new Error() { Description = "There was an error while creating the eac3to batch file." });
                }
            }
            return _errors;
        }

        public bool IsValid()
        {
            if (!_eac3ToCommonRulesValidatorService.IsAtLeastOneDiscSelected())
            {
                _errors = _eac3ToCommonRulesValidatorService.Errors;
                return false;
            }
            if (!_eac3ToCommonRulesValidatorService.IsAtLeastOneSummarySelected())
            {
                _errors = _eac3ToCommonRulesValidatorService.Errors;
                return false;
            }
            if (!_eac3ToCommonRulesValidatorService.WhenSummarySelectedAtLeastOneStreamSelected())
            {
                _errors = _eac3ToCommonRulesValidatorService.Errors;
                return false;
            }
            if (!_eac3ToCommonRulesValidatorService.IsAllEpisodeNumbersSet())
            {
                _errors = _eac3ToCommonRulesValidatorService.Errors;
                return false;
            }
            if (!_eac3ToCommonRulesValidatorService.IsAllBluRayPathsValid())
            {
                _errors = _eac3ToCommonRulesValidatorService.Errors;
                return false;
            }
            return true;
        }

        public void Delete()
        {
            if (File.Exists(_eac3toConfiguration.BatchFilePath))
                File.Delete(_eac3toConfiguration.BatchFilePath);
        }
    }
}
