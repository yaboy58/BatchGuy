using BatchGuy.App.Enums;
using BatchGuy.App.Parser.Models;

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
