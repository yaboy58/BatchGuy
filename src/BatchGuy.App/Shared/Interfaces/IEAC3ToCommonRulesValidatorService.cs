using BatchGuy.App.Shared.Models;

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
        bool IsAllMovieNameYearCombinationUnique();
    }
}
