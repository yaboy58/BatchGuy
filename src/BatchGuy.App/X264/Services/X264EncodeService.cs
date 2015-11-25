using BatchGuy.App.X264.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BatchGuy.App.X264.Interfaces;
using BatchGuy.App.Enums;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Helpers;
using log4net;
using System.Reflection;

namespace BatchGuy.App.X264.Services
{
    public class X264EncodeService : IX264EncodeService
    {
        private X264FileSettings _x264FileSettings;
        private List<X264File> _x264Files;
        private ErrorCollection _errors;
        private string _batFile;
        private IX264ValidationService _validationService;

        public static readonly ILog _log = LogManager.GetLogger(typeof(X264EncodeService));

        public X264EncodeService(IX264ValidationService validationService, X264FileSettings x264FileSettings, List<X264File> x264Files)
        {
            _x264Files = x264Files;
            _x264FileSettings = x264FileSettings;
            _errors = new ErrorCollection();
            _batFile = "batchguy.encode.bluray.bat";
            _validationService = validationService;
        }

        public ErrorCollection CreateX264File()
        {
            _errors = _validationService.Validate();

            if (_errors.Count() == 0)
            {
                switch (_x264FileSettings.EncodeType)
                {
                    case EnumEncodeType.CRF:
                        this.CreateCRFX264File();
                        break;
                    case EnumEncodeType.TwoPass:
                        this.CreateTwoPassX264File();
                        break;
                    default:
                        _errors.Add(new Error() { Description = "Invalid x264 encode type" });
                        break;
                }                
            }
            return _errors;
        }

        public void CreateCRFX264File()
        {
            try
            {
                int episodeNumber = 1;
                using (StreamWriter sw = new StreamWriter(_x264FileSettings.X264BatchFilePath, false))
                {
                    foreach (X264File x264File in _x264Files.OrderBy(f => f.AviSynthFileNameOnly))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(string.Format("\"{0}\"", _x264FileSettings.vfw4x264Exe));
                        sb.Append(string.Format(" \"{0}\"", x264File.AviSynthFilePath));
                        sb.Append(string.Format(" {0}", _x264FileSettings.X264Template));
                        if (_x264FileSettings.X264EncodeAndLogFileOutputDirectoryPathType == EnumDirectoryType.DirectoryPerEpisode)
                        {
                            string episodeFolderName = HelperFunctions.PadNumberWithZeros(_x264Files.Count(),episodeNumber);
                            sb.Append(string.Format(" --output \"{0}\\{1}\\{2}\"", _x264FileSettings.X264EncodeAndLogFileOutputDirectoryPath,episodeFolderName, x264File.EncodeName));
                            sb.Append(string.Format(" - 2> \"{0}\\{1}\\{2}.x264.log\"", _x264FileSettings.X264EncodeAndLogFileOutputDirectoryPath,episodeFolderName, x264File.EncodeName));     
                        }
                        else
                        {
                            sb.Append(string.Format(" --output \"{0}\\{1}\"", _x264FileSettings.X264EncodeAndLogFileOutputDirectoryPath, x264File.EncodeName));
                            sb.Append(string.Format(" - 2> \"{0}\\{1}.x264.log\"", _x264FileSettings.X264EncodeAndLogFileOutputDirectoryPath, x264File.EncodeName));                            
                        }

                        episodeNumber++;
                        sw.WriteLine(sb.ToString());
                        sw.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, MethodBase.GetCurrentMethod().Name);
                _errors.Add(new Error() { Description =  "There was an error trying to create the x264 batch file"});
            }
        }

        public void CreateTwoPassX264File()
        {
            try
            {
                int episodeNumber = 1;
                using (StreamWriter sw = new StreamWriter(_x264FileSettings.X264BatchFilePath, false))
                {
                    foreach (X264File x264File in _x264Files.OrderBy(f => f.AviSynthFileNameOnly))
                    {
                        //1st pass
                        StringBuilder sb1stPass = new StringBuilder();
                        sb1stPass.Append(string.Format("\"{0}\"", _x264FileSettings.vfw4x264Exe));
                        sb1stPass.Append(string.Format(" \"{0}\"", x264File.AviSynthFilePath));
                        sb1stPass.Append(" --pass 1");
                        sb1stPass.Append(string.Format(" {0}", _x264FileSettings.X264Template));
                        if (_x264FileSettings.X264EncodeAndLogFileOutputDirectoryPathType == EnumDirectoryType.DirectoryPerEpisode)
                        {
                            string episodeFolderName = HelperFunctions.PadNumberWithZeros(_x264Files.Count(),episodeNumber);
                            sb1stPass.Append(string.Format(" --output NUL - 2> \"{0}\\{1}\\{2}.x264.log\"", _x264FileSettings.X264EncodeAndLogFileOutputDirectoryPath, episodeFolderName, x264File.EncodeName));
                        }
                        else
                        {
                            sb1stPass.Append(string.Format(" --output NUL - 2> \"{0}\\{1}.x264.log\"", _x264FileSettings.X264EncodeAndLogFileOutputDirectoryPath, x264File.EncodeName));
                        }

                        sw.WriteLine(sb1stPass.ToString());
                        sw.WriteLine();

                        //2nd pass
                        StringBuilder sb2ndPass = new StringBuilder();
                        sb2ndPass.Append(string.Format("\"{0}\"", _x264FileSettings.vfw4x264Exe));
                        sb2ndPass.Append(string.Format(" \"{0}\"", x264File.AviSynthFilePath));
                        sb1stPass.Append(" --pass 2");
                        sb2ndPass.Append(string.Format(" {0}", _x264FileSettings.X264Template));
                        if (_x264FileSettings.X264EncodeAndLogFileOutputDirectoryPathType == EnumDirectoryType.DirectoryPerEpisode)
                        {
                            string episodeFolderName = HelperFunctions.PadNumberWithZeros(_x264Files.Count(), episodeNumber);
                            sb2ndPass.Append(string.Format(" --output \"{0}\\{1}\\{2}\"", _x264FileSettings.X264EncodeAndLogFileOutputDirectoryPath,episodeFolderName, x264File.EncodeName));
                            sb2ndPass.Append(string.Format(" - 2> \"{0}\\{1}\\{2}.x264.log\"", _x264FileSettings.X264EncodeAndLogFileOutputDirectoryPath,episodeFolderName, x264File.EncodeName));
                        }
                        else
                        {
                            sb2ndPass.Append(string.Format(" --output \"{0}\\{1}\"", _x264FileSettings.X264EncodeAndLogFileOutputDirectoryPath, x264File.EncodeName));
                            sb2ndPass.Append(string.Format(" - 2> \"{0}\\{1}.x264.log\"", _x264FileSettings.X264EncodeAndLogFileOutputDirectoryPath, x264File.EncodeName));
                        }

                        sw.WriteLine(sb2ndPass.ToString());
                        sw.WriteLine();
                        sw.WriteLine();
                        episodeNumber++;
                    }
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, MethodBase.GetCurrentMethod().Name);
                _errors.Add(new Error() { Description = "There was an error trying to create the x264 batch file" });
            }
        }
    }
}
