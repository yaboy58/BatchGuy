using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Parser.Interfaces;
using BatchGuy.App.Parser.Services;
using BatchGuy.App.Enums;
using FluentAssertions;
using BatchGuy.App.Shared.Interface;
using BatchGuy.App.MKVMerge.Models;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Services;

namespace BatchGuy.Unit.Tests.Services.Parser
{
    [TestFixture]
    public class BluRayTitleParserServiceTests
    {
        [Test]
        public void bluraytitleparserservice_can_set_header_text_test()
        {
            List<ProcessOutputLineItem> lineItems = new List<ProcessOutputLineItem> 
            {
                new ProcessOutputLineItem()  { Id = 1, Text = "M2TS, 1 video track, 1 audio track, 1 subtitle track, 0:58:28, 50i" }
            };
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
            ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
            IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, lineItems, languageService);
            BluRayTitleInfo info = parserService.GetTitleInfo();

            info.HeaderText.Should().Be(lineItems[0].Text);
       }

        [Test]
        public void bluraytitleparserservice_can_set_chapter_test()
        {
            List<ProcessOutputLineItem> lineItems = new List<ProcessOutputLineItem> 
            {
                new ProcessOutputLineItem()  { Id = 1, Text = "1: Chapters, 6 chapters" }
            };
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
            ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
            IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, lineItems, languageService);
            BluRayTitleInfo info = parserService.GetTitleInfo();

            info.Chapter.Should().NotBeNull();
            info.Chapter.Id.Should().Be("1:");
        }

        [Test]
        public void bluraytitleparserservice_can_set_video_test()
        {
            List<ProcessOutputLineItem> lineItems = new List<ProcessOutputLineItem> 
            {
                new ProcessOutputLineItem()  { Id = 1, Text = "2: h264/AVC, 1080i50 (16:9)" }
            };
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
            ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
            IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, lineItems,languageService);
            BluRayTitleInfo info = parserService.GetTitleInfo();

            info.Video.Should().NotBeNull();
            info.Video.Id.Should().Be("2:");
        }

        [Test]
        public void bluraytitleparserservice_can_set_audiolist_test()
        {
            List<ProcessOutputLineItem> lineItems = new List<ProcessOutputLineItem> 
            {
                new ProcessOutputLineItem()  { Id = 1, Text = "3: DTS Master Audio, French, 5.1 channels, 24 bits, 48kHz" }
            };
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
            ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
            IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, lineItems,languageService);
            BluRayTitleInfo info = parserService.GetTitleInfo();

            info.AudioList.Should().NotBeNull();
        }

        [Test]
        public void bluraytitleparserservice_can_set_audio_id_test()
        {
            List<ProcessOutputLineItem> lineItems = new List<ProcessOutputLineItem> 
            {
                new ProcessOutputLineItem()  { Id = 1, Text = "3: DTS Master Audio, French, 5.1 channels, 24 bits, 48kHz" }
            };
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
            ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
            IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, lineItems, languageService);
            BluRayTitleInfo info = parserService.GetTitleInfo();

            info.AudioList[0].Id.Should().Be("3:");
        }

        [Test]
        public void bluraytitleparserservice_can_set_audio_type_dts_test()
        {
            List<ProcessOutputLineItem> lineItems = new List<ProcessOutputLineItem> 
            {
                new ProcessOutputLineItem()  { Id = 1, Text = "3: DTS Master Audio, French, 5.1 channels, 24 bits, 48kHz" }
            };
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
            ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
            IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, lineItems,languageService);
            BluRayTitleInfo info = parserService.GetTitleInfo();

            info.AudioList[0].AudioType.Should().Be(EnumAudioType.DTSMA);
        }


        [Test]
        public void bluraytitleparserservice_can_set_audio_type_lpcm_test()
        {
            List<ProcessOutputLineItem> lineItems = new List<ProcessOutputLineItem> 
            {
                new ProcessOutputLineItem()  { Id = 1, Text = "3: English / LPCM Audio / 1.0 / 48 kHz / 1152 kbps / 24-bit" }
            };
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
            ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
            IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, lineItems,languageService);
            BluRayTitleInfo info = parserService.GetTitleInfo();

            info.AudioList[0].AudioType.Should().Be(EnumAudioType.LPCM);
        }

        [Test]
        public void bluraytitleparserservice_can_set_audio_type_ac3_test()
        {
            List<ProcessOutputLineItem> lineItems = new List<ProcessOutputLineItem> 
            {
                new ProcessOutputLineItem()  { Id = 1, Text = "3: Dolby Digital Audio English 448 kbps 5.1 / 48 kHz / 448 kbps" }
            };
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
            ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
            IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, lineItems,languageService);
            BluRayTitleInfo info = parserService.GetTitleInfo();

            info.AudioList[0].AudioType.Should().Be(EnumAudioType.AC3);
        }

        [Test]
        public void bluraytitleparserservice_can_set_audio_language_test()
        {
            List<ProcessOutputLineItem> lineItems = new List<ProcessOutputLineItem> 
            {
                new ProcessOutputLineItem()  { Id = 1, Text = "3: Dolby Digital Audio English 448 kbps 5.1 / 48 kHz / 448 kbps" }
            };
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
            ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
            IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, lineItems,languageService);
            BluRayTitleInfo info = parserService.GetTitleInfo();

            info.AudioList[0].Language.Should().Be("English");
        }

        [Test]
        public void bluraytitleparserservice_can_set_subtitle_id_test()
        {
            List<ProcessOutputLineItem> lineItems = new List<ProcessOutputLineItem> 
            {
                new ProcessOutputLineItem()  { Id = 1, Text = "4: Subtitle (pgs), French" }
            };
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
            ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
            IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, lineItems,languageService);
            BluRayTitleInfo info = parserService.GetTitleInfo();

            info.Subtitles.Should().NotBeNull();
            info.Subtitles[0].Id.Should().Be("4:");
        }

        [Test]
        public void bluraytitleparserservice_can_set_subtitle_language_test()
        {
            List<ProcessOutputLineItem> lineItems = new List<ProcessOutputLineItem> 
            {
                new ProcessOutputLineItem()  { Id = 1, Text = "4: Subtitle (pgs), French" }
            };
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
            ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
            IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, lineItems,languageService);
            BluRayTitleInfo info = parserService.GetTitleInfo();

            info.Subtitles[0].Language.Should().Be("French");
        }

        [Test]
        public void bluraytitleparserservice_is_id_not_valid_test()
        {
            List<ProcessOutputLineItem> lineItems = new List<ProcessOutputLineItem> 
            {
                new ProcessOutputLineItem()  { Id = 1, Text = "(core: DTS, 5.1 channels, 1509kpps, 48kHz)" }
            };
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
            ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
            IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, lineItems, languageService);

            bool isValid = parserService.IsIdValid("core:");

            isValid.Should().BeFalse();
        }

        [Test]
        public void bluraytitleparserservice_is_id_valid_test()
        {
            List<ProcessOutputLineItem> lineItems = new List<ProcessOutputLineItem> 
            {
                new ProcessOutputLineItem()  { Id = 1, Text = "4: Subtitle (pgs), French" }
            };
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService languageService = new MKVMergeLanguageService(jsonSerializationService);
            ILineItemIdentifierService lineItemService = new BluRayTitleLineItemIdentifierService();
            IBluRayTitleParserService parserService = new BluRayTitleParserService(lineItemService, lineItems,languageService);

            bool isValid = parserService.IsIdValid("4:");

            isValid.Should().BeTrue();
        }
    }
}
