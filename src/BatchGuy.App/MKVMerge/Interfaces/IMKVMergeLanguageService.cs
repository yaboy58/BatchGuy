using BatchGuy.App.MKVMerge.Models;
using System.Collections.Generic;

namespace BatchGuy.App.MKVMerge.Interfaces
{
    public interface IMKVMergeLanguageService
    {
        List<MKVMergeLanguageItem> GetLanguages();

        MKVMergeLanguageItem GetLanguageByName(string name);
   }
}
