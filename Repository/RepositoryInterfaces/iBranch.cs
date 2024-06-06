using DataLogic.Branches;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Branch;

namespace Repository.RepositoryInterfaces
{
    public interface iBranch:iGenericRepository<Branch>
    {
        Task AddNewBranchAsync(AddBranchModel branch);
        Task<List<Branch>> GetAllBranches(CancellationToken token = default);
        Task<List<BranchInfo>> GetAllBranchesInfo(CancellationToken token = default);
        Task<List<BranchInfo>> GetBranchByCity(Guid BranchID, CancellationToken token = default);
        Task UpdateBranchByID(BranchInfo dBModel, CancellationToken token);
        Task DeleteBranchByID(Guid BranchID, CancellationToken token = default);
    }
}
