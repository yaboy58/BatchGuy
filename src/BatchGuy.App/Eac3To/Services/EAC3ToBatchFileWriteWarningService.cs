using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
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
            if (this.DiscSelectedWithNoSummarySelected())
                _warnings.Add(new Warning() { Description = "Selected discs found with no summary selected" });
            if (this.SummaryAndTitleSelectedWithNoDiscSelected())
                _warnings.Add(new Warning() { Description = "Selected summary and titles found with no disc selected" });            

            return _warnings;
        }

        private bool DiscSelectedWithNoSummarySelected()
        {
            bool hasWarning = false;

            foreach (BluRayDiscInfo disc in _discs.Where(d => d.IsSelected))
            {
                if (disc.BluRaySummaryInfoList == null || disc.BluRaySummaryInfoList.Where(s => s.IsSelected == false).Count() > 0)
                {
                    hasWarning = true;
                    break;
                }
            }
            return hasWarning;
        }

        public bool SummaryAndTitleSelectedWithNoDiscSelected()
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
                            if (summary.BluRayTitleInfo.AudioList != null && summary.BluRayTitleInfo.AudioList.Where(a => a.IsSelected).Count() > 0)
                            {
                                return true;
                            }
                            if (summary.BluRayTitleInfo.Chapter != null && summary.BluRayTitleInfo.Chapter.IsSelected)
                            {
                                return true;
                            }
                            if (summary.BluRayTitleInfo.Subtitles != null && summary.BluRayTitleInfo.Subtitles.Where(s => s.IsSelected).Count() > 0)
                            {
                                return true;
                            }
                            if (summary.BluRayTitleInfo.Video != null && summary.BluRayTitleInfo.Video.IsSelected)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return hasWarning;
        }

    }
}
