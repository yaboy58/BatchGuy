using BatchGuy.App.X264.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using BatchGuy.App.X264.Interfaces;
using BatchGuy.App.Shared.Models;
using log4net;
using System.Reflection;

namespace BatchGuy.App.X264.Services
{
    public class X264ValidationService : IX264ValidationService
    {
        private X264FileSettings _x264FileSettings;
        private ErrorCollection _errors;
        private List<X264File> _x264Files;

        public static readonly ILog _log = LogManager.GetLogger(typeof(X264ValidationService));

        public X264ValidationService(X264FileSettings x264FileSettings, List<X264File> x264Files)
        {
            _x264FileSettings = x264FileSettings;
            _errors = new ErrorCollection();
            _x264Files = x264Files;
        }
        public ErrorCollection Validate()
        {
            try
            {
                this.IsValid();
            }
            catch (Exception ex)
            {
                _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message,ex.StackTrace, MethodBase.GetCurrentMethod().Name);
                _errors.Add(new Error() { Description = "There was an error trying to validate the x264 batch file information.  Please see the error log for more details." });
            }
            return _errors;
        }

        private bool IsValid()
        {
            if (!this.SettingsAndFilesNotNull())
                return false;
            if (!this.AllAviSynthFilesHaveEncodeName())
                return false;
            if (!this.AllEncodeNamesAreUnique())
                return false;
            if (!this.AllEncodeNamesHaveAnMatraskaExtension())
                return false;
            if (!this.X264EncodeAndLogFileOutputDirectoryPathNotNull())
                return false;
            if (!this.X264LogFileOutputDirectoryPathNotNullWhenSaveLogToDifferentDirectory())
                return false;
            return true;
        }

        private bool SettingsAndFilesNotNull()
        {
            if (_x264FileSettings == null || _x264Files == null)
            {
                this._errors.Add(new Error() { Description = "x264 Settings or x264 files not found" });
                return false;
            }
            return true;
        }

        private bool AllAviSynthFilesHaveEncodeName()
        {
            if (_x264Files.Where(f => f.EncodeName == null || f.EncodeName == string.Empty).Count() > 0)
            {
                this._errors.Add(new Error() { Description = "All AviSynth files must have a encode name" });
                return false;
            }
            return true;
        }

        private bool X264EncodeAndLogFileOutputDirectoryPathNotNull()
        {
            if (string.IsNullOrEmpty(_x264FileSettings.X264EncodeAndLogFileOutputDirectoryPath))
            {
                this._errors.Add(new Error() { Description = "The x264 encode and (.log) file Output directory is required" });
                return false;                
            }
            return true;
        }

        private bool X264LogFileOutputDirectoryPathNotNullWhenSaveLogToDifferentDirectory()
        {
            if (_x264FileSettings.SaveX264LogFileToDifferentDirectory && string.IsNullOrEmpty(_x264FileSettings.X264LogFileOutputDirectoryPath))
            {
                this._errors.Add(new Error() { Description = "The x264 (.log) file Output directory is required" });
                return false;
            }
            return true;
        }

        private bool AllEncodeNamesAreUnique()
        {
            int uniqueCount = _x264Files.GroupBy(f => f.EncodeName).Count();
            if (uniqueCount != _x264Files.Count())
            {
                this._errors.Add(new Error() { Description = "All of the encode names must be unique" });
                return false;
            }
            return true;
        }

        private bool AllEncodeNamesHaveAnMatraskaExtension()
        {
            int numberOfEncodeNamesWithMatraskaExtension = _x264Files.Where(f => f.EncodeName.Length >= 5 && f.EncodeName.Substring(f.EncodeName.Length - 4, 4) == ".mkv").Count();
            if (numberOfEncodeNamesWithMatraskaExtension != _x264Files.Count())
            {
                this._errors.Add(new Error() { Description = "All of the encode names must have a (.mkv) extension" });
                return false;
            }

            return true;
        }
    }
}
