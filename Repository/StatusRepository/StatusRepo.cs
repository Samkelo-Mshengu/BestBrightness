using DataLogic.Countries;
using DataLogic;
using DataLogic.Statuses;
using Repository.GenericRepository;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repository.StatusRepository
{

    public class StatusRepo:GenericRepository<Status>,iStatus
    {
        private readonly DefaultContext _context;

        public StatusRepo(DefaultContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Status>> GetAllStatuses(CancellationToken token = default)
        {
            const string query = "EXEC [GetAllStatuses]";
            return await _context.Set<Status>().FromSqlRaw(query).ToListAsync(cancellationToken: token);
        }
    }
}
