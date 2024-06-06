using DataLogic;
using DataLogic.Await;
using DataLogic.Members;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repository.GenericRepository;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AwaitingRepository
{
    public class AwaitingRepo:GenericRepository<Awaiting>,iAwaiting
    {
        private readonly DefaultContext _context;

        public AwaitingRepo(DefaultContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<AwaitingModel>> GetAwaitingList(CancellationToken token = default)
        {
            const string query = "EXEC [GetAwaitingList]";
            return await _context.Set<AwaitingModel>().FromSqlRaw(query).ToListAsync(cancellationToken: token);
        }

        public async Task AwaitingStatusChange(AwaitingModel awaiting)
        {
            object[] parameters =
            {
              new SqlParameter("@AwaitStatus",awaiting.AwaitStatus.ToUpper()),
            
              new SqlParameter("@MemberID",awaiting.MemberID),
        
              new SqlParameter("@BranchID",awaiting.BranchID)
            };

            var query = "EXEC [AwaitingStatusChange] @AwaitStatus, @MemberID, @BranchID";
            await _context.Database.ExecuteSqlRawAsync(query, parameters);
        }

    }
}
