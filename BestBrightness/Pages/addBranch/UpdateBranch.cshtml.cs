using BusinesssLogic.LogicInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewLogic.Branch;

namespace BestBrightness.Pages.addBranch
{
    public class UpdateBranchModel : PageModel
    {
        private readonly IBranchLogic _IBranchLogic;

        public List<BranchInfoView> GetAllBranches { get; set; }
        public UpdateBranchModel(IBranchLogic IBranchLogic) 
        {
        _IBranchLogic = IBranchLogic;
        }

        public async Task OnGet()
        {
            GetAllBranches = await _IBranchLogic.AllBranchDetails();
        }
    }
}
