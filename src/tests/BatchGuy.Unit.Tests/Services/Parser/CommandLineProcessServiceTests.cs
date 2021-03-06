﻿using BatchGuy.App.Parser.Models;
using BatchGuy.App.Parser.Services;
using NUnit.Framework;
using FluentAssertions;
using BatchGuy.App.Parser.Interfaces;
using BatchGuy.App.Shared.Models;

namespace BatchGuy.Unit.Tests.Services.Parser
{
    [TestFixture]
    public class CommandLineProcessServiceTests
    {
        [Test]
        public void commandlineprocessservice_has_no_process_start_info_filename_in_error_test()
        {
            ICommandLineProcessService service = new CommandLineProcessService(new CommandLineProcessStartInfo() { Arguments = "someargument" });
            ErrorCollection errors = service.Errors;
            errors[0].Description.Should().Be("Invalid file name");
        }

        [Test]
        public void commandlineprocessservice_has_no_process_start_info_arguments_in_error_test()
        {
            ICommandLineProcessService service = new CommandLineProcessService(new CommandLineProcessStartInfo() { FileName  = "somefilename" });
            ErrorCollection errors = service.Errors;
            errors[0].Description.Should().Be("Invalid arguments");
        }
    }
}
