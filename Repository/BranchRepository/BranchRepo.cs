using DataLogic;
using DataLogic.Branches;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repository.GenericRepository;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.BranchRepository
{
    public class BranchRepo:GenericRepository<Branch>,iBranch
    {
        private readonly DefaultContext _context;

        public BranchRepo(DefaultContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewBranchAsync(AddBranchModel branch)
        {
            object[] parameters =
            {
              new SqlParameter("@BranchName",branch.BranchName.ToUpper()),
              new SqlParameter("@BranchLocation",branch.BranchLocation.ToUpper()),
              new SqlParameter("@ProvinceID",branch.ProvinceID)
            };

            var query = "EXEC [AddBranch] @BranchName,@BranchLocation,@ProvinceID";
            await _context.Database.ExecuteSqlRawAsync(query, parameters);
        }

        public async Task<List<Branch>> GetAllBranches(CancellationToken token = default)
        {
            const string query = "EXEC [GetAllBranches]";
            return await _context.Set<Branch>().FromSqlRaw(query).ToListAsync(cancellationToken: token);
        }
        public async Task<List<BranchInfo>> GetAllBranchesInfo(CancellationToken token = default)
        {
            const string query = "EXEC [GetBranchesWithProvinceName]";
            return await _context.Set<BranchInfo>().FromSqlRaw(query).ToListAsync(cancellationToken: token);
        }

    }

}
