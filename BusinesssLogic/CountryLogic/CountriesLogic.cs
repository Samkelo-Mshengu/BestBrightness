using BusinesssLogic.LogicInterface;
using BusinesssLogic.Mappings;
using DataLogic.Countries;
using DataLogic.Provinces;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Countries;
using ViewLogic.Provinces;

namespace BusinesssLogic.CountryLogic
{
    public class CountriesLogic : ICountriesLogic
    {
        private readonly iCountry _iCountry;

        public CountriesLogic(iCountry iCountry)
        {
            _iCountry = iCountry;
        }
        public async Task<List<CountryView>> GetCountriesAsync()
        {
            var country = await _iCountry.GetAllCountries();
            return ObjectMapper.Mapper.Map<List<County>, List<CountryView>>(country.ToList());
        }

    }
}
