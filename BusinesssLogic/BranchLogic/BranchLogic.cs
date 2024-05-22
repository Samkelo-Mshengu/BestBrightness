using BusinesssLogic.LogicInterface;
using BusinesssLogic.Mappings;
using DataLogic.Branches;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Branch;

namespace BusinesssLogic.BranchLogic
{
    public class BranchLogic:IBranchLogic
    {
        private readonly iBranch _branch;

        public BranchLogic(iBranch branch)
        {
            _branch = branch;
        }

        public async Task AddNewBranchAsync(AddBranchView view)
        {
            var branchModel=ObjectMapper.Mapper.Map<AddBranchView, AddBranchModel>(view);

            branchModel.BranchName = view.branch.BranchName;
            branchModel.BranchLocation = view.branch.BranchLocation;
            branchModel.Provinces.ProvinceID = view.province.ProvinceID;
            branchModel.Provinces.ProvinceName = view.province.ProvinceName;

            await _branch.AddNewBranchAsync(branchModel);
        }
    }
}
