using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.AVS.Models;
using BatchGuy.App.AVS.Services;
using BatchGuy.App.Models;
using NUnit;
using NUnit.Framework;

namespace BatchGuy.Unit.Tests
{
    [TestFixture]
    public class ValidationServiceTests
    {
        [Test]
        public void batch_directory_is_empty_test()
        {
            AVSBatchSettings avsBatchSettings;
            IValidationService validationService;

            //given an empty batch directory
            avsBatchSettings = new AVSBatchSettings() { BatchDirectoryPath = string.Empty, NamingConvention = "NamingConvention", NumberOfFiles = 1 };
            //when I validate
            validationService = new ValidationService(avsBatchSettings);
            List<Error> errors = validationService.Validate();
            //then error list contains error
            Assert.AreEqual(errors[0].Description, "Batch Directory is required!");
        }

        [Test]
        public void batch_directory_is_invalid_directory_test()
        {
            AVSBatchSettings avsBatchSettings;
            IValidationService validationService;

            //given an empty batch directory
            avsBatchSettings = new AVSBatchSettings() { BatchDirectoryPath = "BatchDirectory", NamingConvention = "NamingConvention", NumberOfFiles = 1 };
            //when I validate
            validationService = new ValidationService(avsBatchSettings);
            List<Error> errors = validationService.Validate();
            //then error list contains error
            Assert.AreEqual(errors[0].Description, "Batch Directory does not exist!");
        }

        [Test]
        public void naming_convention_is_empty_test()
        {
            AVSBatchSettings avsBatchSettings;
            IValidationService validationService;

            //given an empty batch directory
            avsBatchSettings = new AVSBatchSettings() { BatchDirectoryPath = "C:\\temp", NamingConvention = string.Empty, NumberOfFiles = 1 };
            //when I validate
            validationService = new ValidationService(avsBatchSettings);
            List<Error> errors = validationService.Validate();
            //then error list contains error
            Assert.AreEqual(errors[0].Description, "Naming Convention is required");
        }
    }
}
