using BusinesssLogic.LogicInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewLogic.Members;

namespace BestBrightness.Pages.Member
{
    public class ProfileModel : PageModel
    {

        private readonly IMembersLogic _membersLogic;

        public List<MemberProfileView> GetProfileDetails { get; set; }
        public ProfileModel(IMembersLogic membersLogic)
        {
            _membersLogic = membersLogic;
            GetProfileDetails=new List<MemberProfileView>();
        }
        public async Task OnGet()
        {
            string Username = "m@GMAIL.COM";
            GetProfileDetails = await _membersLogic.GetProfileDetailsAsync(Username);
        }
    }
}
