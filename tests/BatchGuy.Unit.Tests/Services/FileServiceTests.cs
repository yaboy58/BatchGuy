using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssert;
using BatchGuy.App.Models;
using BatchGuy.App.Services;

namespace BatchGuy.Unit.Tests
{
    [TestFixture]
    public class FileServiceTests
    {
        [Test]
        public void avsfile_has_correct_name_test()
        {
            AVSBatchSettings avsBatchSettings;
            IFileService fileService;

            //given correct settings
            avsBatchSettings = new AVSBatchSettings() { BatchDirectoryPath = "C:\\Temp", NamingConvention = "encode", NumberOfFiles = 9 };
            //when I create the avs file batch
            fileService = new FileService(avsBatchSettings);
            List<AVSFile> avsFiles = fileService.CreateAVSFileList();
            //then error list contains error
            avsFiles[0].FileNameOnly.ShouldBeEqualTo("encode01.avs");
        }
    }
}
