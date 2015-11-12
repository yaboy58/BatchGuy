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

namespace BatchGuy.App.X264.Services
{
    public class EncodeService : IEncodeService
    {
        private X264FileSettings _x264FileSettings;
        private List<X264File> _x264Files;
        private List<Error> _errors;
        private string _batFile;
        private IValidationService _validationService;

        public EncodeService(IValidationService validationService, X264FileSettings x264FileSettings, List<X264File> x264Files)
        {
            _x264Files = x264Files;
            _x264FileSettings = x264FileSettings;
            _errors = new List<Error>();
            _batFile = "batchguy.encode.bluray.bat";
            _validationService = validationService;
        }

        public List<Error> CreateX264File()
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
                using (StreamWriter sw = new StreamWriter(string.Format("{0}\\{1}", _x264FileSettings.AviSynthFileOutputPath, _batFile), false))
                {
                    foreach (X264File x264File in _x264Files)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(string.Format("\"{0}\"", _x264FileSettings.vfw4x264Exe));
                        sb.Append(string.Format(" \"{0}\"", x264File.AVSFilePath));
                        sb.Append(string.Format(" {0}", _x264FileSettings.X264Template));
                        sb.Append(string.Format(" --output \"{0}\\{1}\"", _x264FileSettings.AviSynthFileOutputPath, x264File.EncodeName));
                        sb.Append(string.Format(" - 2> \"{0}\\{1}.x264.log\"", _x264FileSettings.AviSynthFileOutputPath, x264File.EncodeName));
                        sw.WriteLine(sb.ToString());
                        sw.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                _errors.Add(new Error() { Description =  ex.Message});
            }
        }

        public void CreateTwoPassX264File()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(string.Format("{0}\\{1}", _x264FileSettings.AviSynthFileOutputPath, _batFile), false))
                {
                    foreach (X264File x264File in _x264Files)
                    {
                        //1st pass
                        StringBuilder sb1stPass = new StringBuilder();
                        sb1stPass.Append(string.Format("\"{0}\"", _x264FileSettings.vfw4x264Exe));
                        sb1stPass.Append(string.Format(" \"{0}\"", x264File.AVSFilePath));
                        sb1stPass.Append(" --pass 1");
                        sb1stPass.Append(string.Format(" {0}", _x264FileSettings.X264Template));
                        sb1stPass.Append(string.Format(" --output NUL - 2> \"{0}\\{1}.x264.log\"", _x264FileSettings.AviSynthFileOutputPath, x264File.EncodeName));
                        sw.WriteLine(sb1stPass.ToString());
                        sw.WriteLine();

                        //2nd pass
                        StringBuilder sb2ndPass = new StringBuilder();
                        sb2ndPass.Append(string.Format("\"{0}\"", _x264FileSettings.vfw4x264Exe));
                        sb2ndPass.Append(string.Format(" \"{0}\"", x264File.AVSFilePath));
                        sb1stPass.Append(" --pass 2");
                        sb2ndPass.Append(string.Format(" {0}", _x264FileSettings.X264Template));
                        sb2ndPass.Append(string.Format(" --output \"{0}\\{1}\"", _x264FileSettings.AviSynthFileOutputPath, x264File.EncodeName));
                        sb2ndPass.Append(string.Format(" - 2> \"{0}\\{1}.x264.log\"", _x264FileSettings.AviSynthFileOutputPath, x264File.EncodeName));
                        sw.WriteLine(sb2ndPass.ToString());
                        sw.WriteLine();
                        sw.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                _errors.Add(new Error() { Description = ex.Message });
            }
        }
    }
}
