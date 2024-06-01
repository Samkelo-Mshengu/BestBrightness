using DataLogic;
using DataLogic.Age;
using Microsoft.EntityFrameworkCore;
using Repository.GenericRepository;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AgeGroupsRepository
{
    public class AgeGroupsRepo:GenericRepository<AgeGroup>,iAgeGroup
    {
        private readonly DefaultContext _context;

        public AgeGroupsRepo(DefaultContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<AgeGroup>> GetAllAgeGroups(CancellationToken token = default)
        {
            const string query = "EXEC [GetAllAgeGroups]";
            return await _context.Set<AgeGroup>().FromSqlRaw(query).ToListAsync(cancellationToken: token);
        }
    }
}
