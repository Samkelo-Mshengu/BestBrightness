using DataLogic;
using DataLogic.Branches;
using DataLogic.Provinces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repository.GenericRepository;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core.Tokenizer;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Branch;

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
              new SqlParameter("@ProvinceID",branch.ProvinceID),
              new SqlParameter("@CityID",branch.CityID)
            };

            var query = "EXEC [AddBranch] @BranchName,@BranchLocation,@ProvinceID,@CityID";
            await _context.Database.ExecuteSqlRawAsync(query, parameters);
        }

        public async Task DeleteBranchByID(Guid BranchID, CancellationToken token = default)
        {
            var parameters = new SqlParameter[]
            {
                  new SqlParameter("@BranchID", BranchID)

            };
            string query = "EXEC [DeleteBranchByID] @BranchID";
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

        public async Task<List<BranchInfo>> GetBranchByCity(Guid BranchID, CancellationToken token)
        {
            var parameters = new SqlParameter[]
            {
                  new SqlParameter("@BranchID", BranchID)

            };
            const string query = "EXEC [GetBranchByCity] @BranchID";
            return await _context.Set<BranchInfo>().FromSqlRaw(query, parameters).ToListAsync(cancellationToken: token);
        }



        public async Task UpdateBranchByID(BranchInfo dBModel, CancellationToken token)
        {
            object[] parameters =
            {
              new SqlParameter("@BranchID", dBModel.BranchID),
                  new SqlParameter("@BranchName", dBModel.BranchName),
                  new SqlParameter("@BranchLocation",dBModel.BranchLocation),
            };

            var query = "EXEC [UpdateBranchByID]@BranchID, @BranchName,@BranchLocation";
            await _context.Database.ExecuteSqlRawAsync(query, parameters);

        }
    }

}
