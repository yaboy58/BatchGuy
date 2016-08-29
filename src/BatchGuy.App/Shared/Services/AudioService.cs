﻿using BatchGuy.App.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                case EnumAudioType.DTS:
                    audioExtension = "dts";
                    break;
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
                default:
                    throw new Exception("Invalid Audio Type");
            }
            return audioExtension;
        }

        public EnumAudioType GetAudioTypeByName(string name)
        {
            EnumAudioType audioType = EnumAudioType.DTS;
            switch (name)
            {
                case "DTS":
                    audioType = EnumAudioType.DTS;
                    break;
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
                case EnumAudioType.DTS:
                    name = "DTS";
                    break;
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
                default:
                    throw new Exception("Invalid Audio Type");
            }
            return name;
        }

        public List<EnumAudioType> GetBluRayAudioTypes()
        {
            return new List<EnumAudioType>() { EnumAudioType.AC3, EnumAudioType.DTSMA, EnumAudioType.LPCM, EnumAudioType.TrueHD };
        }
    }
}