using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Models
{
    [Serializable]
    public class Setting
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
