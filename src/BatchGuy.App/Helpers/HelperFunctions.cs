using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
