using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Interfaces
{
    public interface IEAC3ToCommonRulesValidatorService
    {
        ErrorCollection Errors { get; }
        bool IsAtLeastOneDiscSelected();
        bool IsAtLeastOneSummarySelected();
        bool WhenSummarySelectedAtLeastOneStreamSelected();
        bool IsAllBluRayPathsValid();
        bool IsAllEpisodeNumbersSet();
        bool AllMoviesHaveNames();
        bool IsAllMovieNamesUnique();
    }
}
