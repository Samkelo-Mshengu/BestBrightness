using BusinesssLogic.LogicInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewLogic.Branch;
using ViewLogic.Members;

namespace BestBrightness.Pages.Member
{
    public class ViewMembersModel : PageModel
    {
        private readonly IMembersLogic _membersLogic;
        public List<MemberProfileView> GetAllMembers { get; set; }

        public ViewMembersModel(IMembersLogic membersLogic)
        { 
            _membersLogic = membersLogic;
            GetAllMembers= new List<MemberProfileView>();
        }
        public async Task OnGet()
        {
            GetAllMembers = await _membersLogic.AllMemberDetails();
        }
    }
}
