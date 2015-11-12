using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssert;
using NUnit.Framework;
using BatchGuy.App.X264.Models;
using BatchGuy.App.X264.Interfaces;
using BatchGuy.App.X264.Services;
using BatchGuy.App.Shared.Models;

namespace BatchGuy.Unit.Tests.Services.X264
{
    [TestFixture]
    public class ValidationServiceTests
    {
        [Test]
        public void validationservice_has_the_output_folder_for_avisynth_files_does_not_exist_test()
        {
            //given an invalid output path
            X264FileSettings x264FileSettings = new X264FileSettings() { AviSynthFileOutputPath = string.Empty};
            List<X264File> x264Files = new List<X264File>();
            //when i attempt to write out a x264 bat file
            IValidationService service = new ValidationService(x264FileSettings, x264Files);
            //then there is an error
            List<Error> error = service.Validate();
            error.Where(e => e.Description == "The Output Folder for AviSynth files does not exist").Count().ShouldBeEqualTo(1);
        }

        public void validationservice_has_all_avisynth_files_must_have_an_encode_name_exist_test()
        {
            //given an invalid output path
            X264FileSettings x264FileSettings = new X264FileSettings() { AviSynthFileOutputPath = string.Empty };
            List<X264File> x264Files = new List<X264File>() { new X264File() { Id = 1, EncodeName = null}};
            //when i attempt to write out a x264 bat file
            IValidationService service = new ValidationService(x264FileSettings, x264Files);
            //then there is an error
            List<Error> error = service.Validate();
            error.Where(e => e.Description == "All AviSynth files must have a encode name").Count().ShouldBeEqualTo(1);
        }
    }
}
