using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Shared.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace BatchGuy.Unit.Tests.Services.Shared
{
    [TestFixture]
    public class CountryCodeServiceTests
    {
        [Test]
        public void countrycodeservice_can_get_country_codes_test()
        {
            //given
            ICountryCodeService service = new CountryCodeService(new JsonSerializationService<ISOCountryCodeCollection>());
            //when
            var countryCodes = service.GetCountryCodes();
            //then 
            countryCodes.Should().NotBeNull();
        }

        [Test]
        public void countrycodeservice_can_get_country_code_by_iso_long_code_test()
        {
            //given
            ICountryCodeService service = new CountryCodeService(new JsonSerializationService<ISOCountryCodeCollection>());
            string isoLongCode = "PNG";
            //when
            var countryCode = service.GetCountryCodeByISOLongCode(isoLongCode);
            //then 
            countryCode.Value.Should().Be("PNG");
        }
    }
}
