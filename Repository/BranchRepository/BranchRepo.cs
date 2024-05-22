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
              new SqlParameter("@ProvinceName",branch.Provinces.ProvinceName.ToUpper())
            };

            var query = "EXEC [AddBranch] @BranchName,@BranchLocation,@ProvinceName";
            await _context.Database.ExecuteSqlRawAsync(query, parameters);
        }
    }
}
