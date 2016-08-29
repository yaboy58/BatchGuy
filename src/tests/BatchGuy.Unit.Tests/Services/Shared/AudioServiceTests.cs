using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using BatchGuy.App.Enums;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Services;

namespace BatchGuy.Unit.Tests.Services.Shared
{
    [TestFixture]
    public class AudioServiceTests
    {
        [Test]
        public void audioservice_can_get_ac3_audio_type_name()
        {
            //given
            EnumAudioType audioType = EnumAudioType.AC3;
            IAudioService service = new AudioService();
            //when
            string name = service.GetAudioTypeName(audioType);
            //then
            name.Should().Be("AC3");
        }

        [Test]
        public void audioservice_can_get_dts_audio_type_name()
        {
            //given
            EnumAudioType audioType = EnumAudioType.DTS;
            IAudioService service = new AudioService();
            //when
            string name = service.GetAudioTypeName(audioType);
            //then
            name.Should().Be("DTS");
        }

        [Test]
        public void audioservice_can_get_flac_audio_type_name()
        {
            //given
            EnumAudioType audioType = EnumAudioType.FLAC;
            IAudioService service = new AudioService();
            //when
            string name = service.GetAudioTypeName(audioType);
            //then
            name.Should().Be("FLAC");
        }

        [Test]
        public void audioservice_can_get_truehd_audio_type_name()
        {
            //given
            EnumAudioType audioType = EnumAudioType.TrueHD;
            IAudioService service = new AudioService();
            //when
            string name = service.GetAudioTypeName(audioType);
            //then
            name.Should().Be("TrueHD");
        }

        [Test]
        public void audioservice_can_get_mpa_audio_type_name()
        {
            //given
            EnumAudioType audioType = EnumAudioType.MPA;
            IAudioService service = new AudioService();
            //when
            string name = service.GetAudioTypeName(audioType);
            //then
            name.Should().Be("MPA");
        }

        [Test]
        public void audioservice_can_get_dtsma_audio_type_name()
        {
            //given
            EnumAudioType audioType = EnumAudioType.DTSMA;
            IAudioService service = new AudioService();
            //when
            string name = service.GetAudioTypeName(audioType);
            //then
            name.Should().Be("DTSMA");
        }

        [Test]
        public void audioservice_can_get_lpcm_audio_type_name()
        {
            //given
            EnumAudioType audioType = EnumAudioType.LPCM;
            IAudioService service = new AudioService();
            //when
            string name = service.GetAudioTypeName(audioType);
            //then
            name.Should().Be("LPCM");
        }
    }
}
