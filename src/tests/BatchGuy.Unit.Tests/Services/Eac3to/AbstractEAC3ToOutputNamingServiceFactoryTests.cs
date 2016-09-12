using BatchGuy.App.Eac3To.Abstracts;
using BatchGuy.App.Eac3To.Services;
using BatchGuy.App.Enums;
using BatchGuy.App.Shared.Services;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.Unit.Tests.Services.Eac3to
{
    [TextFixture]
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
    }
}
