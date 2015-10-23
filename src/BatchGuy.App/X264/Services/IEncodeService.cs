using BatchGuy.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.X264.Services
{
    public interface IEncodeService
    {
        List<Error> CreateX264File(); 
    }
}
