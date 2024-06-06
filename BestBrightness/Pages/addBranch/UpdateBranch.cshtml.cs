using BusinesssLogic.LogicInterface;
using DataLogic.Branches;
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
        public async Task<IActionResult> OnPostAsync(string action, Guid BranchID)
        {
            if (action == "update")
            {
                return RedirectToPage("/AddBranch/EditBranchDetails", new { BranchID = BranchID });
            }
            if (action == "delete")
            {
                await _IBranchLogic.DeleteBranchByID(BranchID);
                return RedirectToPage("/AddBranch/addBranch");
            }
            return Page();
        }
    }
}
