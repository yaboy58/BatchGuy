using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssert;
using BatchGuy.App.EAC.Models;
using BatchGuy.App.EAC.Services;
using BatchGuy.App;

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

        [Test]
        public void eacoutputservice_can_set_dts_audio_settings_test()
        {
            //given dts and audio settings
            EAC3ToConfiguration config = new EAC3ToConfiguration() {  BatFilePath = "c:\\temp", AudioType = EnumAudioType.DTS, AudioSettings = "-core" };
            EAC3ToBluRayFile file = new EAC3ToBluRayFile() {  MainAudioStreamNumber = "1" };
            //when I want the output
            IEACOutputService service = new EACOutputService(config, file);
            //then the dts audio is set
            string output = service.GetAudioStreamPart();
            output.ShouldContain(".dts");
            output.ShouldContain("-core");
        }

        [Test]
        public void eacoutputservice_can_set_truehd_audio_settings_test()
        {
            //given truehd and audio settings
            EAC3ToConfiguration config = new EAC3ToConfiguration() { BatFilePath = "c:\\temp", AudioType = EnumAudioType.TrueHD, AudioSettings = "-640" };
            EAC3ToBluRayFile file = new EAC3ToBluRayFile() { MainAudioStreamNumber = "1" };
            //when I want the output
            IEACOutputService service = new EACOutputService(config, file);
            //then the truehd audio is set
            string output = service.GetAudioStreamPart();
            output.ShouldContain(".ac3");
            output.ShouldContain("-640");
        }
    }
}
