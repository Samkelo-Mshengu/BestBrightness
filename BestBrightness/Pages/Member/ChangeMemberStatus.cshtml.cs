using BusinesssLogic.LogicInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewLogic.Await;
using ViewLogic.Members;

namespace BestBrightness.Pages.Member
{
    public class ChangeMemberStatusModel : PageModel
    {
        private readonly IMembersLogic _membersLogic;
        private readonly IAwaitingLogic _awaitingLogic;
        public List<MemberProfileView> GetAllMembers { get; set; }
        public List<AwaitingViewModel> GetAwaitingList { get; set; }

        public ChangeMemberStatusModel(IMembersLogic membersLogic, IAwaitingLogic awaitingLogic)
        {
            _membersLogic = membersLogic;
            GetAllMembers = new List<MemberProfileView>();
            _awaitingLogic = awaitingLogic;
            GetAwaitingList= new List<AwaitingViewModel>();
        }
        public async Task OnGet()
        {
            GetAllMembers = await _membersLogic.AllMemberDetails();
            GetAwaitingList=await _awaitingLogic.GetAwaitingListAsync();
        }


    }
}
