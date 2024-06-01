﻿using DataLogic.Branches;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterfaces
{
    public interface iBranch:iGenericRepository<Branch>
    {
        Task AddNewBranchAsync(AddBranchModel branch);
        Task<List<Branch>> GetAllBranches(CancellationToken token = default);
        Task<List<BranchInfo>> GetAllBranchesInfo(CancellationToken token = default);
    }
}
