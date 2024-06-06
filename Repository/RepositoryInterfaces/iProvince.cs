using DataLogic.Cities;
using DataLogic.Provinces;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.City;

namespace Repository.RepositoryInterfaces
{
    public interface iProvince:iGenericRepository<Province>
    {
        Task<List<Province>> GetAllProvines(string countryName, CancellationToken token = default);
        Task<List<City>> GetAllCityAsync(Guid cityName, CancellationToken token = default);
    }
}
