using DataLogic;
using DataLogic.Provinces;
using Microsoft.EntityFrameworkCore;
using Repository.GenericRepository;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ProvinceRepository
{
    public class ProvinceRepo: GenericRepository<Province>,iProvince
    {
        private readonly DefaultContext _context;

        public ProvinceRepo(DefaultContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Province>> GetAllProvines(CancellationToken token=default)
        {
            const string query = "EXEC [GetAllProvinces]";
            return await _context.Set<Province>().FromSqlRaw(query).ToListAsync(cancellationToken:token);
        }
    }
}
