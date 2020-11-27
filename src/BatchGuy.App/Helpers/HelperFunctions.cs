using System.Linq;

namespace BatchGuy.App.Helpers
{
    public static class HelperFunctions
    {
        public static string PadNumberWithZeros(int batchCount, int number)
        {
            string paddedNumber = string.Empty;
            string batchCountString = batchCount.ToString();

            if (batchCountString.Length == 1)
            {
                paddedNumber = number.ToString().PadLeft(2, '0');    
            }
            else
            {
                if (number.ToString().Length < batchCountString.Length)
                {
                    paddedNumber = number.ToString().PadLeft(batchCountString.Length, '0');                        
                }
                else
                {
                    paddedNumber = number.ToString();       
                }
            }
            return paddedNumber;
        }

        public static string GetVideoExtension(string text)
        {
            string[] values = new string[] { "hevc", "h265", "2160" };

            bool isHevc = values.Any(v => text.ToLower().Contains(v));

            if (string.IsNullOrEmpty(text) || isHevc == false)
                return "mkv";
            else
                return "h265";
        }
    }
}
