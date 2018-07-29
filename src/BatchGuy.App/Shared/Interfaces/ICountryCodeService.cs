using BatchGuy.App.Shared.Models;
using System.Collections.Generic;

namespace BatchGuy.App.Shared.Interfaces
{
    public interface ICountryCodeService
    {
        List<CountryCodeItem> GetCountryCodes();
        CountryCodeItem GetCountryCodeByISOLongCode(string isoLongCode);
    }
}
