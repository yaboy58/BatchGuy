using BatchGuy.App.MKVMerge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.MKVMerge.Interfaces
{
    public interface IMKVMergeLanguageService
    {
        List<MKVMergeLanguageItem> GetLanguages();

        MKVMergeLanguageItem GetLanguageByName(string name);
   }
}
