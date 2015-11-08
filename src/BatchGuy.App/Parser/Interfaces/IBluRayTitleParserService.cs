using BatchGuy.App.Enums;
using BatchGuy.App.Parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Interfaces
{
    public interface IBluRayTitleParserService
    {
        BluRayTitleInfo GetTitleInfo();
        string GetId(ProcessOutputLineItem lineItem);
        EnumAudioType GetAudioType(ProcessOutputLineItem lineItem);
        string GetLanguage(ProcessOutputLineItem lineItem);
        bool IsAudioType(ProcessOutputLineItem processOutputLineItem, string criteria);
        bool IsIdValid(string id);
    }
}
