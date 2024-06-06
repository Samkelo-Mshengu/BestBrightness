using DataLogic;
using DataLogic.Cities;
using DataLogic.Provinces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repository.GenericRepository;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.City;

namespace Repository.ProvinceRepository
{
    public class ProvinceRepo: GenericRepository<Province>,iProvince
    {
        private readonly DefaultContext _context;

        public ProvinceRepo(DefaultContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<City>> GetAllCityAsync(Guid provinceName, CancellationToken token = default)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@province", provinceName)
            };

            string query = "EXEC [AllCityAsync] @province"; // Assuming your stored procedure name is AllCityAsync
            return await _context.Set<City>().FromSqlRaw(query, parameters).ToListAsync(cancellationToken: token);
        }


        public async Task<List<Province>> GetAllProvines(string countryName ,CancellationToken token=default)
        {
            var parameters = new SqlParameter[]
          {
                  new SqlParameter("@countryName", countryName)
                   
          };
            const string query = "EXEC [GetAllProvinces] @countryName";
            return await _context.Set<Province>().FromSqlRaw(query, parameters).ToListAsync(cancellationToken:token);
        }
    }
}
