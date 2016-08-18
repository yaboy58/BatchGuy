using BatchGuy.App.MKVMerge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.MKVMerge.Models;

namespace BatchGuy.App.MKVMerge.Services
{
    public class MKVMergeLanguageService : IMKVMergeLanguageService
    {
        List<MKVMergeLanguageItem> _languages;

        public MKVMergeLanguageService()
        {
            _languages = PopulateLangugeList();
        }
        public MKVMergeLanguageItem GetLanguageByName(string name)
        {
            MKVMergeLanguageItem item = _languages.SingleOrDefault(l => l.Language.ToLower() == name.ToLower());
            if (item != null)
                return item;
            else
                return _languages.SingleOrDefault(l => l.Language == "Undetermined");
        }

        public List<MKVMergeLanguageItem> GetLanguages()
        {
            return _languages;
        }

        private List<MKVMergeLanguageItem> PopulateLangugeList()
        {
            return _languages = new List<MKVMergeLanguageItem>() { new MKVMergeLanguageItem() { Name = "Undetermined (und)", Value = "und" },
            new MKVMergeLanguageItem() { Language = "Chinese", Name = "Chinese (chi)", Value = "chi" },
            new MKVMergeLanguageItem() { Language = "Dutch", Name = "Dutch: Flemish (dut)", Value = "dut" },
            new MKVMergeLanguageItem() { Language = "English", Name = "English (eng)", Value = "eng" },
            new MKVMergeLanguageItem() { Language = "English", Name = "Finnish (fin)", Value = "fin" },
            new MKVMergeLanguageItem() { Language = "French", Name = "French (fre)", Value = "fre" },
            new MKVMergeLanguageItem() { Language = "German", Name = "German (ger)", Value = "ger" },
            new MKVMergeLanguageItem() { Language = "Italian", Name = "Italian (ita)", Value = "ita" },
            new MKVMergeLanguageItem() { Language = "Japanese", Name = "Japanese (jpn)", Value = "jpn" },
            new MKVMergeLanguageItem() { Language = "Multiple Languages", Name = "Multiple Languages (mul)", Value = "mul" },
            new MKVMergeLanguageItem() { Language = "No linguistic content", Name = "No linguistic content; Not applicable (zxx)", Value = "zxx" },
            new MKVMergeLanguageItem() { Language = "Norwegian", Name = "Norwegian (nor)", Value = "nor" },
            new MKVMergeLanguageItem() { Language = "Portuguese", Name = "Portuguese (por)", Value = "por" },
            new MKVMergeLanguageItem() { Language = "Russian", Name = "Russian (rus)", Value = "rus" },
            new MKVMergeLanguageItem() { Language = "Spanish", Name = "Spanish (spa)", Value = "spa" },
            new MKVMergeLanguageItem() { Language = "Castillian", Name = "Castillian (spa)", Value = "spa" },
            new MKVMergeLanguageItem() { Language = "Swedish", Name = "Swedish (swe)", Value = "swe" },
            new MKVMergeLanguageItem() { Language = "Undetermined", Name = "Undetermined (und)", Value = "und" },
            new MKVMergeLanguageItem() { Language = "Danish", Name = "Danish (dan)", Value = "dan" }};
        }
    }
}
