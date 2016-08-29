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

        [Test]
        public void audioservice_can_get_dts_audio_type_by_name()
        {
            //given
            string name = "DTS";
            IAudioService service = new AudioService();
            //when
            EnumAudioType audioType = service.GetAudioTypeByName(name);
            //then
            audioType.Should().Be(EnumAudioType.DTS);
        }

        [Test]
        public void audioservice_can_get_ac3_audio_type_by_name()
        {
            //given
            string name = "AC3";
            IAudioService service = new AudioService();
            //when
            EnumAudioType audioType = service.GetAudioTypeByName(name);
            //then
            audioType.Should().Be(EnumAudioType.AC3);
        }

        [Test]
        public void audioservice_can_get_flac_audio_type_by_name()
        {
            //given
            string name = "FLAC";
            IAudioService service = new AudioService();
            //when
            EnumAudioType audioType = service.GetAudioTypeByName(name);
            //then
            audioType.Should().Be(EnumAudioType.FLAC);
        }

        [Test]
        public void audioservice_can_get_truehd_audio_type_by_name()
        {
            //given
            string name = "TrueHD";
            IAudioService service = new AudioService();
            //when
            EnumAudioType audioType = service.GetAudioTypeByName(name);
            //then
            audioType.Should().Be(EnumAudioType.TrueHD);
        }

        [Test]
        public void audioservice_can_get_mpa_audio_type_by_name()
        {
            //given
            string name = "MPA";
            IAudioService service = new AudioService();
            //when
            EnumAudioType audioType = service.GetAudioTypeByName(name);
            //then
            audioType.Should().Be(EnumAudioType.MPA);
        }

        [Test]
        public void audioservice_can_get_dtsma_audio_type_by_name()
        {
            //given
            string name = "DTSMA";
            IAudioService service = new AudioService();
            //when
            EnumAudioType audioType = service.GetAudioTypeByName(name);
            //then
            audioType.Should().Be(EnumAudioType.DTSMA);
        }

        [Test]
        public void audioservice_can_get_lpcm_audio_type_by_name()
        {
            //given
            string name = "LPCM";
            IAudioService service = new AudioService();
            //when
            EnumAudioType audioType = service.GetAudioTypeByName(name);
            //then
            audioType.Should().Be(EnumAudioType.LPCM);
        }

        [Test]
        public void audioservice_can_get_dts_audio_extension()
        {
            //given
            EnumAudioType audioType = EnumAudioType.DTS;
            IAudioService service = new AudioService();
            //when
            string extension = service.GetAudioExtension(audioType);
            //then
            extension.Should().Be("dts");
        }

        [Test]
        public void audioservice_can_get_ac3_audio_extension()
        {
            //given
            EnumAudioType audioType = EnumAudioType.AC3;
            IAudioService service = new AudioService();
            //when
            string extension = service.GetAudioExtension(audioType);
            //then
            extension.Should().Be("ac3");
        }

        [Test]
        public void audioservice_can_get_flac_audio_extension()
        {
            //given
            EnumAudioType audioType = EnumAudioType.FLAC;
            IAudioService service = new AudioService();
            //when
            string extension = service.GetAudioExtension(audioType);
            //then
            extension.Should().Be("flac");
        }

        [Test]
        public void audioservice_can_get_truehd_audio_extension()
        {
            //given
            EnumAudioType audioType = EnumAudioType.TrueHD;
            IAudioService service = new AudioService();
            //when
            string extension = service.GetAudioExtension(audioType);
            //then
            extension.Should().Be("thd");
        }

        [Test]
        public void audioservice_can_get_mpa_audio_extension()
        {
            //given
            EnumAudioType audioType = EnumAudioType.MPA;
            IAudioService service = new AudioService();
            //when
            string extension = service.GetAudioExtension(audioType);
            //then
            extension.Should().Be("mpa");
        }

        [Test]
        public void audioservice_can_get_dtsma_audio_extension()
        {
            //given
            EnumAudioType audioType = EnumAudioType.DTSMA;
            IAudioService service = new AudioService();
            //when
            string extension = service.GetAudioExtension(audioType);
            //then
            extension.Should().Be("dtsma");
        }

        [Test]
        public void audioservice_can_get_lpcm_audio_extension()
        {
            //given
            EnumAudioType audioType = EnumAudioType.LPCM;
            IAudioService service = new AudioService();
            //when
            string extension = service.GetAudioExtension(audioType);
            //then
            extension.Should().Be("wav");
        }
    }
}
