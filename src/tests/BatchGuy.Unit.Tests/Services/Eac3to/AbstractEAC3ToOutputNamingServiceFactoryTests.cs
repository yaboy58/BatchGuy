using BatchGuy.App.Eac3To.Abstracts;
using BatchGuy.App.Enums;
using BatchGuy.App.Shared.Services;
using FluentAssertions;
using NUnit.Framework;


namespace BatchGuy.Unit.Tests.Services.Eac3to
{
    [TestFixture]
    public class AbstractEAC3ToOutputNamingServiceFactoryTests
    {
        [Test]
        public void abstractEAC3ToOutputNamingServiceFactory_CreateNewEncodeTemplate1EAC3ToOutputNamingService_test()
        {
            //given
            AbstractEAC3ToOutputNamingServiceFactory factory = new AbstractEAC3ToOutputNamingServiceFactory(new AudioService());
            //when
            AbstractEAC3ToOutputNamingService service = factory.CreateNewEncodeTemplate1EAC3ToOutputNamingService();
            //then
            service.EnumEAC3ToNamingConventionType.Should().Be(EnumEAC3ToNamingConventionType.EncodeNamingConventionTemplate1);
        }

        [Test]
        public void abstractEAC3ToOutputNamingServiceFactory_CreateNewRemuxTemplate1EAC3ToOutputNamingService_test()
        {
            //given
            AbstractEAC3ToOutputNamingServiceFactory factory = new AbstractEAC3ToOutputNamingServiceFactory(new AudioService());
            //when
            AbstractEAC3ToOutputNamingService service = factory.CreateNewRemuxTemplate1EAC3ToOutputNamingService();
            //then
            service.EnumEAC3ToNamingConventionType.Should().Be(EnumEAC3ToNamingConventionType.RemuxNamingConventionTemplate1);
        }

        [Test]
        public void abstractEAC3ToOutputNamingServiceFactory_CreateNewRemuxTemplate2EAC3ToOutputNamingService_test()
        {
            //given
            AbstractEAC3ToOutputNamingServiceFactory factory = new AbstractEAC3ToOutputNamingServiceFactory(new AudioService());
            //when
            AbstractEAC3ToOutputNamingService service = factory.CreateNewRemuxTemplate2EAC3ToOutputNamingService();
            //then
            service.EnumEAC3ToNamingConventionType.Should().Be(EnumEAC3ToNamingConventionType.RemuxNamingConventionTemplate2);
        }

        [Test]
        public void abstractEAC3ToOutputNamingServiceFactory_CreateNewRemuxTemplate3EAC3ToOutputNamingService_test()
        {
            //given
            AbstractEAC3ToOutputNamingServiceFactory factory = new AbstractEAC3ToOutputNamingServiceFactory(new AudioService());
            //when
            AbstractEAC3ToOutputNamingService service = factory.CreateNewRemuxTemplate3EAC3ToOutputNamingService();
            //then
            service.EnumEAC3ToNamingConventionType.Should().Be(EnumEAC3ToNamingConventionType.RemuxNamingConventionTemplate3);
        }

        [Test]
        public void abstractEAC3ToOutputNamingServiceFactory_CreateNewMovieRemuxTemplate1EAC3ToOutputNamingServiceService_test()
        {
            //given
            AbstractEAC3ToOutputNamingServiceFactory factory = new AbstractEAC3ToOutputNamingServiceFactory(new AudioService());
            //when
            AbstractEAC3ToOutputNamingService service = factory.CreateNewMovieRemuxTemplate1EAC3ToOutputNamingServiceService();
            //then
            service.EnumEAC3ToNamingConventionType.Should().Be(EnumEAC3ToNamingConventionType.MovieRemuxNamingConventionTemplate1);
        }
    }
}
