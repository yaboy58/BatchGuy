using BatchGuy.App.Shared.Interfaces;
using System;
using System.Collections.Generic;
using BatchGuy.App.Enums;

namespace BatchGuy.App.Shared.Services
{
    public class AudioService : IAudioService
    {
        public string GetAudioExtension(EnumAudioType audioType)
        {
            string audioExtension = string.Empty;

            switch (audioType)
            {
                case EnumAudioType.AC3:
                    audioExtension = "ac3";
                    break;
                case EnumAudioType.FLAC:
                    audioExtension = "flac";
                    break;
                case EnumAudioType.TrueHD:
                    audioExtension = "thd";
                    break;
                case EnumAudioType.MPA:
                    audioExtension = "mpa";
                    break;
                case EnumAudioType.DTSMA:
                    audioExtension = "dtsma";
                    break;
                case EnumAudioType.LPCM:
                    audioExtension = "wav";
                    break;
                case EnumAudioType.DTSEXPRESS:
                    audioExtension = "dts";
                    break;
                case EnumAudioType.M4A:
                    audioExtension = "m4a";
                    break;
                default:
                    throw new Exception("Invalid Audio Type");
            }
            return audioExtension;
        }

        public EnumAudioType GetAudioTypeByName(string name)
        {
            EnumAudioType audioType = EnumAudioType.AC3;
            switch (name)
            {
                case "AC3":
                    audioType = EnumAudioType.AC3;
                    break;
                case "FLAC":
                    audioType = EnumAudioType.FLAC;
                    break;
                case "TrueHD":
                    audioType = EnumAudioType.TrueHD;
                    break;
                case "DTSMA":
                    audioType = EnumAudioType.DTSMA;
                    break;
                case "LPCM":
                    audioType = EnumAudioType.LPCM;
                    break;
                case "MPA":
                    audioType = EnumAudioType.MPA;
                    break;
                case "DTS Express":
                    audioType = EnumAudioType.DTSEXPRESS;
                    break;
                case "M4A":
                    audioType = EnumAudioType.M4A;
                    break;
                default:
                    throw new Exception("Invalid Audio Type");
            }
            return audioType;
        }

        public string GetAudioTypeName(EnumAudioType audioType)
        {
            string name = string.Empty;

            switch (audioType)
            {
                case EnumAudioType.AC3:
                    name = "AC3";
                    break;
                case EnumAudioType.FLAC:
                    name = "FLAC";
                    break;
                case EnumAudioType.TrueHD:
                    name = "TrueHD";
                    break;
                case EnumAudioType.MPA:
                    name = "MPA";
                    break;
                case EnumAudioType.DTSMA:
                    name = "DTSMA";
                    break;
                case EnumAudioType.LPCM:
                    name = "LPCM";
                    break;
                case EnumAudioType.DTSEXPRESS:
                    name = "DTS Express";
                    break;
                case EnumAudioType.M4A:
                    name = "M4A";
                    break;
                default:
                    throw new Exception("Invalid Audio Type");
            }
            return name;
        }

        public List<EnumAudioType> GetBluRayAudioTypes()
        {
            return new List<EnumAudioType>() { EnumAudioType.AC3, EnumAudioType.DTSEXPRESS, EnumAudioType.DTSMA, EnumAudioType.LPCM, EnumAudioType.TrueHD };
        }
    }
}
