using DataLogic;
using DataLogic.Countries;
using DataLogic.Provinces;
using Microsoft.EntityFrameworkCore;
using Repository.GenericRepository;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.CountriesRepository
{
     public class CountriesRepository: GenericRepository<County>,iCountry
    {
        private readonly DefaultContext _context;

        public CountriesRepository(DefaultContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<List<County>> GetAllCountries(CancellationToken token = default)
        {
            const string query = "EXEC [GetAllCountries]";
            return await _context.Set<County>().FromSqlRaw(query).ToListAsync(cancellationToken: token);
        }




    }
}
