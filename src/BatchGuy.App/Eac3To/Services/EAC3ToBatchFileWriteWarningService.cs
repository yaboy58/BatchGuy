using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Eac3To.Services
{
    public class EAC3ToBatchFileWriteWarningService : IEAC3ToBatchFileWriteWarningService
    {
        private WarningCollection _warnings;
        private List<BluRayDiscInfo> _discs;

        public EAC3ToBatchFileWriteWarningService(List<BluRayDiscInfo> discs)
        {
            _discs = discs;
            _warnings = new WarningCollection();
        }

        public WarningCollection GetWarnings()
        {
            this.DiscSelectedWithNoSummarySelected();
            this.SummaryAndTitleSelectedWithNoDiscSelected();
            this.TitleSelectedWithNoDiscAndSummarySelected();

            return _warnings;
        }

        private bool DiscSelectedWithNoSummarySelected()
        {
            bool hasWarning = false;

            foreach (BluRayDiscInfo disc in _discs.Where(d => d.IsSelected))
            {
                if (disc.BluRaySummaryInfoList == null || disc.BluRaySummaryInfoList.Where(s => s.IsSelected == true).Count() == 0)
                {
                    _warnings.Add(new Warning() { Description = string.Format("Disc {0} selected but no summary selected", disc.DiscName) });
                    hasWarning = true;
                }
            }
            return hasWarning;
        }

        private bool SummaryAndTitleSelectedWithNoDiscSelected()
        {
            bool hasWarning = false;
            foreach (BluRayDiscInfo disc in _discs)
            {
                if (disc.BluRaySummaryInfoList != null)
                {
                    foreach (BluRaySummaryInfo summary in disc.BluRaySummaryInfoList.Where(s => s.IsSelected))
                    {
                        if (disc.IsSelected == false && summary.BluRayTitleInfo != null)
                        {
                            if (summary.BluRayTitleInfo.Video != null && summary.BluRayTitleInfo.Video.IsSelected)
                            {
                                _warnings.Add(new Warning() { Description = string.Format("Disc {0} is not selected but has selected summary and video",  disc.DiscName) });
                                hasWarning = true;
                            }
                            if (summary.BluRayTitleInfo.AudioList != null && summary.BluRayTitleInfo.AudioList.Where(a => a.IsSelected).Count() > 0)
                            {
                                _warnings.Add(new Warning() { Description = string.Format("Disc {0} is not selected but has selected summary and audio", disc.DiscName) });
                                hasWarning = true;
                            }
                            if (summary.BluRayTitleInfo.Subtitles != null && summary.BluRayTitleInfo.Subtitles.Where(s => s.IsSelected).Count() > 0)
                            {
                                _warnings.Add(new Warning() { Description = string.Format("Disc {0} is not selected but has selected summary and subtitles", disc.DiscName) });
                                hasWarning = true;
                            }
                            if (summary.BluRayTitleInfo.Chapter != null && summary.BluRayTitleInfo.Chapter.IsSelected)
                            {
                                _warnings.Add(new Warning() { Description = string.Format("Disc {0} is not selected but has selected summary and chapters", disc.DiscName) });
                                hasWarning = true;
                            }
                        }
                    }
                }
            }

            return hasWarning;
        }

        private bool TitleSelectedWithNoDiscAndSummarySelected()
        {
            bool hasWarning = false;

            foreach (BluRayDiscInfo disc in _discs)
            {
                if (disc.BluRaySummaryInfoList != null)
                {
                    foreach (BluRaySummaryInfo summary in disc.BluRaySummaryInfoList)
                    {
                        if (disc.IsSelected == false && summary.IsSelected == false && summary.BluRayTitleInfo != null)
                        {
                            if (summary.BluRayTitleInfo.AudioList != null && summary.BluRayTitleInfo.AudioList.Where(a => a.IsSelected).Count() > 0)
                            {
                                _warnings.Add(new Warning() { Description = string.Format("Disc {0} summary {1} is not selected but has selected audio", disc.DiscName, summary.Eac3ToId) });
                                hasWarning = true;
                            }
                            if (summary.BluRayTitleInfo.Chapter != null && summary.BluRayTitleInfo.Chapter.IsSelected)
                            {
                                _warnings.Add(new Warning() { Description = string.Format("Disc {0} summary {1} is not selected but has selected chapter", disc.DiscName, summary.Eac3ToId) });
                                hasWarning = true;
                            }
                            if (summary.BluRayTitleInfo.Subtitles != null && summary.BluRayTitleInfo.Subtitles.Where(s => s.IsSelected).Count() > 0)
                            {
                                _warnings.Add(new Warning() { Description = string.Format("Disc {0} summary {1} is not selected but has selected subtitles", disc.DiscName, summary.Eac3ToId) });
                                hasWarning = true;
                            }
                            if (summary.BluRayTitleInfo.Video != null && summary.BluRayTitleInfo.Video.IsSelected)
                            {
                                _warnings.Add(new Warning() { Description = string.Format("Disc {0} summary {1} is not selected but has selected video", disc.DiscName, summary.Eac3ToId) });
                                hasWarning = true;
                            }
                        }
                    }
                }
            }

            return hasWarning;
        }

    }
}
