using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssert;
using BatchGuy.App.AviSynth.Models;
using BatchGuy.App.AviSynth.Services;
using BatchGuy.App.AviSynth.Interfaces;

namespace BatchGuy.Unit.Tests.Services.AviSynth
{
    [TestFixture]
    public class FileServiceTests
    {
        [Test]
        public void avsfile_has_correct_name_test()
        {
            AviSynthBatchSettings avsBatchSettings;
            IAviSynthFileService fileService;
            AviSynthTemplateScript avsTemplateScript;

            //given correct settings
            avsBatchSettings = new AviSynthBatchSettings() { AviSynthFilesOutputDirectoryPath = "C:\\Temp", NamingConvention = "encode", NumberOfFiles = 9 };
            avsTemplateScript = new AviSynthTemplateScript() {  Script = string.Empty};
            //when I create the avs file batch
            fileService = new AviSynthFileService(avsBatchSettings, avsTemplateScript);
            List<AviSynthFile> avsFiles = fileService.CreateAVSFileList();
            //then error list contains error
            avsFiles[0].FileNameOnly.ShouldBeEqualTo("encode01.avs");
        }
    }
}
