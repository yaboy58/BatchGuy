using BatchGuy.App.Models;
using BatchGuy.App.Parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Services
{
    public class CommandLineProcessService : ICommandLineProcessService
    {
        private CommandLineProcessStartInfo _commandLineProcessStartInfo;
        private readonly List<Error> _errors;

        public CommandLineProcessService(CommandLineProcessStartInfo commandLineProcessStartInfo)
        {
            _commandLineProcessStartInfo = commandLineProcessStartInfo;
            _errors = new List<Error>();
        }

        public List<Error> CheckErrors()
        {
            this.CheckFileName();
            this.CheckArguments();

            return _errors;
        }

        private void CheckFileName()
        {
            if (_commandLineProcessStartInfo.FileName == string.Empty || _commandLineProcessStartInfo.FileName == null)
            {
                _errors.Add(new Error() { Description = "Invalid file name" });
            }
        }

        private void CheckArguments()
        {
            if (_commandLineProcessStartInfo.Arguments == string.Empty || _commandLineProcessStartInfo.Arguments == null)
            {
                _errors.Add(new Error() { Description = "Invalid arguments" });
            }
        }
    }
}
