using BusinesssLogic.LogicInterface;
using BusinesssLogic.Mappings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewLogic.Await;
using ViewLogic.Members;

namespace BestBrightness.Pages.Member
{
    public class EditMemberModel : PageModel
    {
        private readonly IMembersLogic _membersLogic;
        private readonly IAwaitingLogic _waitingLogic;
        [BindProperty]
        public MemberProfileView Member { get; set; }
        public MemberProfileView SELECTEED { get; set; }
        public AwaitingViewModel AwaitState { get; set; }
        [BindProperty]
        public string StatusAwait {  get; set; }

        public EditMemberModel(IMembersLogic membersLogic, IAwaitingLogic waitingLogic) 
        {
            _membersLogic = membersLogic;
            _waitingLogic = waitingLogic;
            Member = new MemberProfileView();
            AwaitState = new AwaitingViewModel();
        }
        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            Member = await _membersLogic.MemberDetailsByID(id);
            if (Member == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
           

            // Ensure Member property is populated correctly
            SELECTEED = await _membersLogic.MemberDetailsByID(id);

            if (Member == null)
            {
                return NotFound();
            }


            // Retrieve MemberID and BranchID
         

            // Create AwaitingViewModel instance
            var awaitViewModel= new AwaitingViewModel
            {
                MemberID = SELECTEED.MemberID,
                BranchID = SELECTEED.BranchID,
                AwaitStatus = StatusAwait

            };

            // Update the awaiting status
            await _waitingLogic.AwaitingStatusChangeAsync(awaitViewModel);
                return RedirectToPage("/Member/ChangeMemberStatus");
            

        }


    }
}
