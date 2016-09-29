using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Abstracts;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.MKVMerge.Services
{
    public class MKVMergeBatchFileWriteForMovieService : IMKVMergeBatchFileWriteService
    {
        private ErrorCollection _errors = new ErrorCollection();
        private List<BluRayDiscInfo> _bluRayDiscInfoList;
        private EAC3ToConfiguration _eac3toConfiguration;
        private IDirectorySystemService _directorySystemService;
        private IAudioService _audioService;
        private AbstractEAC3ToOutputNamingService _eac3ToOutputNamingService;
        private IEAC3ToCommonRulesValidatorService _eac3ToCommonRulesValidatorService;

        public static readonly ILog _log = LogManager.GetLogger(typeof(MKVMergeBatchFileWriteForMovieService));

        public ErrorCollection Errors
        {
            get { return _errors; }
        }

        public MKVMergeBatchFileWriteForMovieService(EAC3ToConfiguration eac3toConfiguration, IDirectorySystemService directorySystemService, List<BluRayDiscInfo> bluRayDiscInfo, IAudioService audioService, AbstractEAC3ToOutputNamingService eac3ToOutputNamingService, IEAC3ToCommonRulesValidatorService eac3ToCommonRulesValidatorService)
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
                            _eac3ToOutputNamingService.SetCurrentBluRaySummaryInfo(summary);
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
            if (!_eac3ToCommonRulesValidatorService.AllMoviesHaveNames())
            {
                _errors = _eac3ToCommonRulesValidatorService.Errors;
                return false;
            }
            if (!_eac3ToCommonRulesValidatorService.IsAllMovieNameYearCombinationUnique())
            {
                _errors = _eac3ToCommonRulesValidatorService.Errors;
                return false;
            }
            return true;
        }

        public void Delete()
        {
            if (File.Exists(_eac3toConfiguration.MKVMergeBatchFilePath))
                File.Delete(_eac3toConfiguration.MKVMergeBatchFilePath);
        }
    }
}
