using BatchGuy.App.Eac3To.Services;
using BatchGuy.App.Shared.Interfaces;

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
        public AbstractEAC3ToOutputNamingService CreateNewRemuxTemplate2EAC3ToOutputNamingService()
        {
            return new RemuxTemplate2EAC3ToOutputNamingService(_audioService);
        }

        public AbstractEAC3ToOutputNamingService CreateNewRemuxTemplate3EAC3ToOutputNamingService()
        {
            return new RemuxTemplate3EAC3ToOutputNamingService(_audioService);
        }
        public AbstractEAC3ToOutputNamingService CreateNewMovieRemuxTemplate1EAC3ToOutputNamingServiceService()
        {
            return new MovieRemuxTemplate1EAC3ToOutputNamingService(_audioService);
        }

    }
}
