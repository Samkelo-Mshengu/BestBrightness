using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Branch;
using ViewLogic.Statuses;

namespace BusinesssLogic.LogicInterface
{
    public interface IBranchLogic
    {
        Task AddNewBranchAsync(AddBranchView view);
        Task<List<BranchView>> GetBranchesAsync();
        Task<List<BranchInfoView>> AllBranchDetails();
        Task<List<BranchInfoView>> GetBranchByCity(Guid BranchID);
        Task UpdateBranchByID(BranchInfoView EditedBranch, CancellationToken token = default);
        Task DeleteBranchByID(Guid BranchID, CancellationToken token = default);
    }
}
