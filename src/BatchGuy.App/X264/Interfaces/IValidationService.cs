using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.X264.Interfaces
{
    public interface IValidationService
    {
        ErrorCollection Validate();
    }
}
