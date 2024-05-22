using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Branch;

namespace BusinesssLogic.LogicInterface
{
    public interface IBranchLogic
    {
        Task AddNewBranchAsync(AddBranchView view);
    }
}
