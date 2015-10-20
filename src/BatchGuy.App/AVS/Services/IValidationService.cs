using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.AVS;
using BatchGuy.App.AVS.Models;
using BatchGuy.App.Models;

namespace BatchGuy.App.AVS.Services
{
    public interface IValidationService
    {
        List<Error> Validate();
    }
}
