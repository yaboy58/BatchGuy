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
        public List<MKVMergeLanguageItem> GetLanguages()
        {
            return new List<MKVMergeLanguageItem>() { new MKVMergeLanguageItem() { Name = "Undetermined (und)", Value = "und" },
            new MKVMergeLanguageItem() { Name = "Chinese (chi)", Value = "chi" },
            new MKVMergeLanguageItem() { Name = "Dutch: Flemish (dut)", Value = "dut" },
            new MKVMergeLanguageItem() { Name = "English (eng)", Value = "eng" },
            new MKVMergeLanguageItem() { Name = "Finnish (fin)", Value = "fin" },
            new MKVMergeLanguageItem() { Name = "French (fre)", Value = "fre" },
            new MKVMergeLanguageItem() { Name = "German (ger)", Value = "ger" },
            new MKVMergeLanguageItem() { Name = "Italian (ita)", Value = "ita" },
            new MKVMergeLanguageItem() { Name = "Japanese (jpn)", Value = "jpn" },
            new MKVMergeLanguageItem() { Name = "Multiple Languages (mul)", Value = "mul" },
            new MKVMergeLanguageItem() { Name = "No linguistic content; Not applicable (zxx)", Value = "zxx" },
            new MKVMergeLanguageItem() { Name = "Norwegian (nor)", Value = "nor" },
            new MKVMergeLanguageItem() { Name = "Portuguese (por)", Value = "por" },
            new MKVMergeLanguageItem() { Name = "Russian (rus)", Value = "rus" },
            new MKVMergeLanguageItem() { Name = "Spanish; Castillian (spa)", Value = "spa" },
            new MKVMergeLanguageItem() { Name = "Swedish (swe)", Value = "swe" },
            new MKVMergeLanguageItem() { Name = "Undetermined (und)", Value = "und" },
            new MKVMergeLanguageItem() { Name = "Danish (dan)", Value = "dan" }};
        }
    }
}
