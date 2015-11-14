using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Helpers
{
    public static class HelperFunctions
    {
        public static string PadNumberWithZeros(int batchCount, int fileNumber)
        {
            string paddedNumber = string.Empty;
            string batchCountString = batchCount.ToString();

            if (batchCountString.Length == 1)
            {
                paddedNumber = fileNumber.ToString().PadLeft(2, '0');    
            }
            else
            {
                if (fileNumber.ToString().Length < batchCountString.Length)
                {
                    paddedNumber = fileNumber.ToString().PadLeft(batchCountString.Length, '0');                        
                }
                else
                {
                    paddedNumber = fileNumber.ToString();       
                }
            }
            return paddedNumber;
        }

        public static string ReplaceBackspace(string hasBackspace)
        {
            if (string.IsNullOrEmpty(hasBackspace))
                return hasBackspace;

            StringBuilder result = new StringBuilder(hasBackspace.Length);
            foreach (char c in hasBackspace)
            {
                if (c != '\b')
                {
                    result.Append(c);
                }
            }
            return result.ToString().Trim();
        }
    }
}
