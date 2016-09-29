using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Services
{
    public class EAC3ToCommonRulesValidatorService : IEAC3ToCommonRulesValidatorService
    {
        private List<BluRayDiscInfo> _bluRayDiscInfoList;
        private EAC3ToConfiguration _eac3toConfiguration;
        private IDirectorySystemService _directorySystemService;
        private ErrorCollection _errors = new ErrorCollection();

        public ErrorCollection Errors { get { return _errors; } }

        public EAC3ToCommonRulesValidatorService(EAC3ToConfiguration eac3toConfiguration, IDirectorySystemService directorySystemService, List<BluRayDiscInfo> bluRayDiscInfo)
        {
            _bluRayDiscInfoList = bluRayDiscInfo;
            _eac3toConfiguration = eac3toConfiguration;
            _directorySystemService = directorySystemService;
        }

        public bool IsAtLeastOneDiscSelected()
        {
            bool isValid = true;

            if (_bluRayDiscInfoList.Where(d => d.IsSelected).Count() == 0)
            {
                isValid = false;
                this._errors.Add(new Error() { Description = "No Disc was selected." });
            }
            return isValid;
        }

        public bool IsAtLeastOneSummarySelected()
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
                if (!_eac3toConfiguration.IfIsExtractForRemuxIsItForAMovie)
                    this._errors.Add(new Error() { Description = "No episodes selected." });
                else
                    this._errors.Add(new Error() { Description = "No movies selected." });
            }
            return isValid;
        }

        public bool IsAllBluRayPathsValid()
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
        public bool IsAllEpisodeNumbersSet()
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
                if (!_eac3toConfiguration.IfIsExtractForRemuxIsItForAMovie)
                    this._errors.Add(new Error() { Description = "Episode number not set for all selected titles." });
                else
                    this._errors.Add(new Error() { Description = "Movie number not set for all selected titles." });
            }
            return isValid;
        }

        public bool WhenSummarySelectedAtLeastOneStreamSelected()
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

        public bool AllMoviesHaveNames()
        {
            bool isValid = true;
            foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
            {
                foreach (BluRaySummaryInfo info in disc.BluRaySummaryInfoList.Where(s => s.IsSelected))
                {
                    if ((info.RemuxFileNameForMovieTemplate != null) && (info.RemuxFileNameForMovieTemplate.SeriesName == null || info.RemuxFileNameForMovieTemplate.SeriesName.Trim() == string.Empty))
                    {
                        isValid = false;
                    }
                }
            }

            if (!isValid)
            {
                this._errors.Add(new Error() { Description = "All movies must have a movie name." });
            }
            return isValid;
        }

        public bool IsAllMovieNamesUnique()
        {
            bool isValid = true;

            List<string> movieNames = new List<string>();
            foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
            {
                foreach (BluRaySummaryInfo info in disc.BluRaySummaryInfoList.Where(s => s.IsSelected))
                {
                    if (info.RemuxFileNameForMovieTemplate != null)
                    {
                        movieNames.Add(info.RemuxFileNameForMovieTemplate.SeriesName);
                    }
                }
            }

            foreach (string movieName in movieNames)
            {
                if (movieNames.Where(n => n == movieName).Count() > 1)
                {
                    isValid = false;
                }
            }

            if (!isValid)
            {
                this._errors.Add(new Error() { Description = "All movie names must be unique." });
            }
            return isValid;
        }
    }
}
