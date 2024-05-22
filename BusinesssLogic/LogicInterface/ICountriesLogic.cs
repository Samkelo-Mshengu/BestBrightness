using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Countries;

namespace BusinesssLogic.LogicInterface
{
    public interface ICountriesLogic
    {
        Task<List<CountryView>> GetCountriesAsync();

    }
}
