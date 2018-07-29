using System.Linq;
using NUnit.Framework;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Services;
using FluentAssertions;
using BatchGuy.App.MKVMerge.Models;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.Shared.Interface;

namespace BatchGuy.Unit.Tests.Services.MKVMerge
{
    [TestFixture]
    public class MKVMergeLanguageServiceTests
    {
        [Test]
        public void mkvmergelanguageservice_can_get_languages_test()
        {
            //given
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService service = new MKVMergeLanguageService(jsonSerializationService);
            //when
            var languages = service.GetLanguages();
            //then
            languages.Count().Should().BeGreaterThan(0);
        }

        [Test]
        public void mkvmergelanguageservice_returns_undetermined_when_language_not_found_test()
        {
            //given
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService service = new MKVMergeLanguageService(jsonSerializationService);
            //when
            var language = service.GetLanguageByName("nolanguage");
            //then
            language.Value.Should().Be("und");
        }

        [Test]
        public void mkvmergelanguageservice_returns_correct_language_test()
        {
            //given
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService service = new MKVMergeLanguageService(jsonSerializationService);
            //when
            var language = service.GetLanguageByName("English");
            //then
            language.Value.Should().Be("eng");
        }
    }
}
