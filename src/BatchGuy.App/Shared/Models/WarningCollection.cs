using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Models
{
    public class WarningCollection : List<Warning>
    {
        public string GetWarningMessage()
        {
            if (this != null && this.Count() > 0)
                return string.Format("{0} Warnings found: {1}", this.Count() ,string.Join(Environment.NewLine,this.Select(e => e.Description)));
            else
                return string.Empty;
        }
    }
}
