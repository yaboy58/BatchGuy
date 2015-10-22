using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssert;
using BatchGuy.App.AVS.Models;
using BatchGuy.App.AVS.Services;

namespace BatchGuy.Unit.Tests
{
    [TestFixture]
    public class FileServiceTests
    {
        [Test]
        public void avsfile_has_correct_name_test()
        {
            AVSBatchSettings avsBatchSettings;
            IAVSFileService fileService;
            AVSTemplateScript avsTemplateScript;

            //given correct settings
            avsBatchSettings = new AVSBatchSettings() { BatchDirectoryPath = "C:\\Temp", NamingConvention = "encode", NumberOfFiles = 9 };
            avsTemplateScript = new AVSTemplateScript() {  Script = string.Empty};
            //when I create the avs file batch
            fileService = new AVSFileService(avsBatchSettings, avsTemplateScript);
            List<AVSFile> avsFiles = fileService.CreateAVSFileList();
            //then error list contains error
            avsFiles[0].FileNameOnly.ShouldBeEqualTo("encode01.avs");
        }
    }
}
