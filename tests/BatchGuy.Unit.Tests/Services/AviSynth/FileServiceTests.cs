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
            AVSBatchSettings avsBatchSettings;
            IFileService fileService;
            AVSTemplateScript avsTemplateScript;

            //given correct settings
            avsBatchSettings = new AVSBatchSettings() { BatchDirectoryPath = "C:\\Temp", NamingConvention = "encode", NumberOfFiles = 9 };
            avsTemplateScript = new AVSTemplateScript() {  Script = string.Empty};
            //when I create the avs file batch
            fileService = new FileService(avsBatchSettings, avsTemplateScript);
            List<AVSFile> avsFiles = fileService.CreateAVSFileList();
            //then error list contains error
            avsFiles[0].FileNameOnly.ShouldBeEqualTo("encode01.avs");
        }
    }
}
