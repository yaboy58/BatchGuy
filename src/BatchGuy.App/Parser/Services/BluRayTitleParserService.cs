﻿using BatchGuy.App.Parser.Interfaces;
using BatchGuy.App.Parser.Models;
using System.Collections.Generic;
using System.Linq;
using BatchGuy.App.Enums;
using System.Text.RegularExpressions;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Models;

namespace BatchGuy.App.Parser.Services
{
    public class BluRayTitleParserService : IBluRayTitleParserService
    {
        private ILineItemIdentifierService _lineItemIdentifierService;
        private List<ProcessOutputLineItem> _processOutputLineItems;
        private readonly BluRayTitleInfo _bluRayTtileInfo;
        private IMKVMergeLanguageService _languageService;

        public BluRayTitleParserService(ILineItemIdentifierService lineItemIdentifierService, List<ProcessOutputLineItem> processOutputLineItems, IMKVMergeLanguageService languageService)
        {
            _lineItemIdentifierService = lineItemIdentifierService;
            _processOutputLineItems = processOutputLineItems;
            _bluRayTtileInfo = new BluRayTitleInfo();
            _languageService = languageService;
        }

        public BluRayTitleInfo GetTitleInfo()
        {
            foreach (ProcessOutputLineItem item in _processOutputLineItems)
            {
                EnumBluRayLineItemType type = _lineItemIdentifierService.GetLineItemType(item);

                switch (type)
                {
                    case EnumBluRayLineItemType.BluRayTitleHeaderLine:
                        _bluRayTtileInfo.HeaderText = item.Text;
                        break;
                    case EnumBluRayLineItemType.BluRayTitleChapterLine:
                        this.SetChapter(item);
                        break;
                    case EnumBluRayLineItemType.BluRayTitleVideoLine:
                        this.SetVideo(item);
                        break;
                    case EnumBluRayLineItemType.BluRayTitleAudioLine:
                        this.SetAudio(item);
                        break;
                    case EnumBluRayLineItemType.BluRayTitleSubtitleLine:
                        this.SetSubtitle(item);
                        break;
                    default:
                        break;
                }
            }

            return _bluRayTtileInfo;
        }

        public string GetId(ProcessOutputLineItem lineItem)
        {
            string[] splitted = lineItem.Text.Split(' ');
            return splitted[0];
        }

        public EnumAudioType GetAudioType(ProcessOutputLineItem lineItem)
        {
            EnumAudioType type = EnumAudioType.AC3;

            if (this.IsAudioType(lineItem, "dts master audio"))
            {
                type = EnumAudioType.DTSMA;
            }
            else if (this.IsAudioType(lineItem, "dts express"))
            {
                type = EnumAudioType.DTSEXPRESS;
            }
            else if (this.IsAudioType(lineItem, "truehd"))
            {
                type = EnumAudioType.TrueHD;
            }
            else if (this.IsAudioType(lineItem, "pcm"))
            {
                type = EnumAudioType.LPCM;
            }
            return type;
        }

        public string GetLanguage(ProcessOutputLineItem lineItem)
        {
            var languages = _languageService.GetLanguages();
            string lineItemLanguage = "undetermined";

            foreach (MKVMergeLanguageItem language in languages)
            {
                if (lineItem.Text.ToLower().Contains(language.Language.ToLower()))
                {
                    return lineItemLanguage = language.Language;
                }
            }
            return lineItemLanguage;
        }

        public bool IsAudioType(ProcessOutputLineItem processOutputLineItem, string criteria )
        {
            string[] values = new string[] { criteria };

            bool isAudio = values.Any(v => processOutputLineItem.Text.ToLower().Contains(v));

            return isAudio;
        }

        public bool IsIdValid(string id)
        {
            string pattern = "^[0-9,:]+$";
            Regex regEx = new Regex(pattern, RegexOptions.IgnoreCase);

            bool isMatch = regEx.IsMatch(id);

            return isMatch;
        }

        private void SetChapter(ProcessOutputLineItem lineItem)
        {
            _bluRayTtileInfo.Chapter = new BluRayTitleChapter() { Id = this.GetId(lineItem), IsSelected = true, Text = lineItem.Text };
        }

        private void SetVideo(ProcessOutputLineItem lineItem)
        {
            if (_bluRayTtileInfo.Video == null)
                _bluRayTtileInfo.Video = new BluRayTitleVideo() { Id = this.GetId(lineItem), IsSelected = true, Text = lineItem.Text };
        }

        private void SetAudio(ProcessOutputLineItem lineItem)
        {
            string id = this.GetId(lineItem);

            if (!this.IsIdValid(id))
                return;

            if (_bluRayTtileInfo.AudioList == null)
                _bluRayTtileInfo.AudioList = new List<BluRayTitleAudio>();

            BluRayTitleAudio audio = new BluRayTitleAudio();
            audio.Id = id;
            audio.IsSelected = false;
            audio.AudioType = this.GetAudioType(lineItem);
            audio.Language = this.GetLanguage(lineItem);
            audio.Text = lineItem.Text;
            audio.OriginalAudioType = audio.AudioType;
            audio.IsLossless = this.SetIsLosslessAudioFlag(audio.OriginalAudioType);

            _bluRayTtileInfo.AudioList.Add(audio);
        }

        private bool SetIsLosslessAudioFlag(EnumAudioType audioType)
        {
            bool isLossless = false;

            switch (audioType)
            {
                case EnumAudioType.TrueHD:
                    isLossless = true;
                    break;
                case EnumAudioType.DTSMA:
                    isLossless = true;
                    break;
                case EnumAudioType.LPCM:
                    isLossless = true;
                    break;
            }
            return isLossless;
        }

        private void SetSubtitle(ProcessOutputLineItem lineItem)
        {
            if (_bluRayTtileInfo.Subtitles == null)
                _bluRayTtileInfo.Subtitles = new List<BluRayTitleSubtitle>();

            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle();
            subtitle.Id = this.GetId(lineItem);
            subtitle.Language = this.GetLanguage(lineItem);
            subtitle.Text = lineItem.Text;
            _bluRayTtileInfo.Subtitles.Add(subtitle);
        }
    }
}
