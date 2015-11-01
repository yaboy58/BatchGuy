using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssert;
using BatchGuy.App.EAC.Models;
using BatchGuy.App.EAC.Services;

namespace BatchGuy.Unit.Tests.Services.EAC
{
    [TestFixture]
    public class EACOutputServiceTests
    {
        [Test]
        public void eacoutputservice_can_set_eac3to_executable_path_test()
        {
            //given eac3to path
            EAC3ToConfiguration config = new EAC3ToConfiguration() { EAC3ToPath = "c:\\exe\\eac3to" };
            //when I want the output
            IEACOutputService service = new EACOutputService(config, new EAC3ToBluRayFile());
            //then the eac3to path is set
            string output = service.GetEAC3ToPathPart();
            output.ShouldContain(config.EAC3ToPath);
        }

        [Test]
        public void eacoutputservice_can_set_bluray_stream_test()
        {
            //given bluray folder and stream#
            EAC3ToConfiguration config = new EAC3ToConfiguration() {  BluRayPath = "c:\\disc" };
            EAC3ToBluRayFile file = new EAC3ToBluRayFile() { BluRaySteamNumber = "1" };
            //when I want the output
            IEACOutputService service = new EACOutputService(config, file);
            //then the bluray path/stream# is set
            string output = service.GetBluRayStreamPart();
            output.ShouldContain(config.BluRayPath);
            output.ShouldContain(file.BluRaySteamNumber);
        }
    }
}
