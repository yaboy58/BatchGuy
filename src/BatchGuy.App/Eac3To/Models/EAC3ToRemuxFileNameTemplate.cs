namespace BatchGuy.App.Eac3To.Models
{
    public class EAC3ToRemuxFileNameTemplate
    {
        public string SeriesName  { get; set; }
        public string SeasonNumber { get; set; }
        public string SeasonYear { get; set; }
        public string VideoResolution { get; set; }
        public string AudioType { get; set; }
        public string Tag { get; set; }
        public string Medium { get; set; }
        public string VideoFormat { get; set; }
        public bool UsePeriodsInFileName { get; set; }
        public string Country { get; set; }
    }
}
