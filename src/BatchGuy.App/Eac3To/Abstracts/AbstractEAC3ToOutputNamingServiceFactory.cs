using BatchGuy.App.Eac3To.Services;
using BatchGuy.App.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Eac3To.Abstracts
{
    public class AbstractEAC3ToOutputNamingServiceFactory
    {
        protected IAudioService _audioService;
        public AbstractEAC3ToOutputNamingServiceFactory(IAudioService audioService)
        {
            _audioService = audioService;
        }
        public AbstractEAC3ToOutputNamingService CreateNewEncodeTemplate1EAC3ToOutputNamingService()
        {
            return new EncodeTemplate1EAC3ToOutputNamingService(_audioService);
        }
        public AbstractEAC3ToOutputNamingService CreateNewRemuxTemplate1EAC3ToOutputNamingService()
        {
            return new RemuxTemplate1EAC3ToOutputNamingService(_audioService);
        }
    }
}
