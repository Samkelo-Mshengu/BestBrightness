using DataLogic.Countries;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterfaces
{
    public interface iCountry:iGenericRepository<County>
    {
        Task<List<County>> GetAllCountries(CancellationToken token = default);

    }
}
