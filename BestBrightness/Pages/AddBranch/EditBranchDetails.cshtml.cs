using BusinesssLogic.LogicInterface;
using BusinesssLogic.ProvincesLogic;
using DataLogic.Branches;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewLogic.Branch;

namespace BestBrightness.Pages.AddBranch
{
    public class EditBranchDetailsModel : PageModel
    {
        private readonly IBranchLogic _IBranchLogic;
        public List<BranchInfoView> Branch { get; set; } = default!;
        [BindProperty]
        public BranchInfoView EditedBranch { get; set; }
        public EditBranchDetailsModel(IBranchLogic IBranchLogic)
        {
            _IBranchLogic = IBranchLogic;
            Branch = new List<BranchInfoView>();
            EditedBranch = new BranchInfoView();
        }
        public async Task OnGet(Guid BranchID)
        {
            if (BranchID != Guid.Empty)
            {
                Branch = await GetBranchByCity(BranchID);
            }
        }

        public async Task<List<BranchInfoView>> GetBranchByCity(Guid BranchID)
        {

            Branch = await _IBranchLogic.GetBranchByCity(BranchID);
            return Branch;

        }
        public async Task<IActionResult> OnPostAsync()
        {
            await UpdateBranchByID();
            return RedirectToPage("/AddBranch/UpdateBranch");
        }
        public async Task UpdateBranchByID()
        { 
             await _IBranchLogic.UpdateBranchByID(EditedBranch);
             RedirectToPage("/AddBranch/UpdateBranch");
        }
    }
}
