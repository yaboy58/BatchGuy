using BatchGuy.App.Parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchGuy.App.Extensions
{
    public static class ExtensionMethods
    {
        public static int StringToInt(this string value)
        {
            int outValue;
            bool isValid = int.TryParse(value, out outValue);
            return outValue;
        }

        public static int? StringToNullInt(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            int outValue;
            bool isValid = int.TryParse(value, out outValue);
            return outValue;
        }

        public static bool IsNumeric(this string value)
        {
            int outValue;
            bool isValid = int.TryParse(value, out outValue);
            return isValid;
        }

        public static void SetEnabled(this Control control, bool enabled)
        {
            control.Enabled = enabled;
            if (enabled)
            {
                control.Cursor = Cursors.Default;
            }
            else
            {
                control.Cursor = Cursors.WaitCursor;
            }
        }

        public static string RemoveBackspaces(this string value)
        {
            if (string.IsNullOrEmpty(value)) //put -1 for last index of as well
                return value;

            int lastOccurrence = value.LastIndexOf('\b');

            if (lastOccurrence == -1)
                return value;

            lastOccurrence += 1;

            StringBuilder result = new StringBuilder((value.Length - lastOccurrence) + 1);
            result.Append(value.Substring(lastOccurrence,  (value.Length - lastOccurrence)));

            return result.ToString().Trim();
        }

        public static int NumberOfEpisodes(this List<BluRayDiscInfo> value)
        {
            int count = 0;

            foreach (BluRayDiscInfo disc in value.Where(d => d.IsSelected))
            {
                if (disc.BluRaySummaryInfoList != null)
                    count += disc.BluRaySummaryInfoList.Where(s => s.IsSelected).Count();
            }

            return count;
        }

        public static string RemoveDoubleSpaces(this string value)
        {
            string result = Regex.Replace(value, @"\s+", " ");
            return result;
        }

        public static string RemoveColons(this string value)
        {
            string result = value.Replace(":", string.Empty);

            return result;
        }

        public static string RemoveDoubleQuotes(this string value)
        {
            string result = value.Replace("\"", string.Empty);

            return result;
        }
    }
}
