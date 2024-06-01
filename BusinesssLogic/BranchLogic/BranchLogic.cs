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
using ViewLogic.Statuses;

namespace BusinesssLogic.BranchLogic
{
    public class BranchLogic:IBranchLogic
    {
        private readonly iBranch _branch;
        private readonly ICountriesLogic _country;
        private readonly IProvinceLogic _province;

        public BranchLogic(iBranch branch, ICountriesLogic country, IProvinceLogic province)
        {
            _branch = branch;
            _country = country;
            _province = province;
        }

        public async Task AddNewBranchAsync(AddBranchView view)
        {
            var branchModel=ObjectMapper.Mapper.Map<AddBranchView, AddBranchModel>(view);

            branchModel.BranchName = view.branch.BranchName;
            branchModel.BranchLocation = view.branch.BranchLocation;
            branchModel.ProvinceID = view.branch.ProvinceID;

            await _branch.AddNewBranchAsync(branchModel);
        }

        public async Task<List<BranchInfoView>> AllBranchDetails()
        {
            var BranchInfor = await _branch.GetAllBranchesInfo();
            var model= ObjectMapper.Mapper.Map<List<BranchInfo>, List<BranchInfoView>>(BranchInfor.ToList());
            return model;

        }

        public async Task<List<BranchView>> GetBranchesAsync()
        {
            var branches = await _branch.GetAllBranches();
            return ObjectMapper.Mapper.Map<List<Branch>, List<BranchView>>(branches.ToList());
        }
    }
}
