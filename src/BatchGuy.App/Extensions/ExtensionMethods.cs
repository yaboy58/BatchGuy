using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                Cursor.Current = Cursors.Default;
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
            }
        }
    }
}
