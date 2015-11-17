using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.AviSynth.Models;
using BatchGuy.App.AviSynth.Services;
using NUnit;
using NUnit.Framework;
using BatchGuy.App.AviSynth.Interfaces;
using BatchGuy.App.Shared.Models;

namespace BatchGuy.Unit.Tests.Services.AviSynth
{
    [TestFixture]
    public class ValidationServiceTests
    {
        [Test]
        public void batch_directory_is_empty_test()
        {
            AVSBatchSettings avsBatchSettings;
            IAviSynthValidationService validationService;

            //given an empty batch directory
            avsBatchSettings = new AVSBatchSettings() { BatchDirectoryPath = string.Empty, NamingConvention = "NamingConvention", NumberOfFiles = 1 };
            //when I validate
            validationService = new AviSynthValidationService(avsBatchSettings);
            ErrorCollection errors = validationService.Validate();
            //then error list contains error
            Assert.AreEqual(errors[0].Description, "Batch Directory is required!");
        }

        [Test]
        public void batch_directory_is_invalid_directory_test()
        {
            AVSBatchSettings avsBatchSettings;
            IAviSynthValidationService validationService;

            //given an empty batch directory
            avsBatchSettings = new AVSBatchSettings() { BatchDirectoryPath = "BatchDirectory", NamingConvention = "NamingConvention", NumberOfFiles = 1 };
            //when I validate
            validationService = new AviSynthValidationService(avsBatchSettings);
            ErrorCollection errors = validationService.Validate();
            //then error list contains error
            Assert.AreEqual(errors[0].Description, "Batch Directory does not exist!");
        }

        [Test]
        public void naming_convention_is_empty_test()
        {
            AVSBatchSettings avsBatchSettings;
            IAviSynthValidationService validationService;

            //given an empty batch directory
            avsBatchSettings = new AVSBatchSettings() { BatchDirectoryPath = "C:\\temp", NamingConvention = string.Empty, NumberOfFiles = 1 };
            //when I validate
            validationService = new AviSynthValidationService(avsBatchSettings);
            ErrorCollection errors = validationService.Validate();
            //then error list contains error
            Assert.AreEqual(errors[0].Description, "Naming Convention is required");
        }
    }
}
