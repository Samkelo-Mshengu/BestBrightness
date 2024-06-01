using BusinesssLogic.CountryLogic;
using BusinesssLogic.LogicInterface;
using BusinesssLogic.Mappings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewLogic.Age;
using ViewLogic.Branch;
using ViewLogic.Members;
using ViewLogic.Provinces;
using ViewLogic.Statuses;

namespace BestBrightness.Pages.Member
{
    public class AddMemberModel : PageModel
    {
        private readonly IStatusesLogic _IStatusesLogic;
        private readonly IAgeGroupsLogic _IAgeGroupsLogic;
        private readonly IBranchLogic _IBranchLogic;
        private readonly IMembersLogic _MembersLogic;

        [BindProperty]
        public MemberView AddMember {  get; set; }
        public List<StatusView> GetAllStatuses { get; set; }
        public List<AgeGroupView> GetAllAgeGroups { get; set; }
        public List<BranchView> GetAllBranches { get; set; }
        public AddMemberModel(IStatusesLogic IStatusesLogic, IAgeGroupsLogic IAgeGroupsLogic, IBranchLogic iBranchLogic, IMembersLogic MembersLogic)
        {
            _IStatusesLogic = IStatusesLogic;
            _IAgeGroupsLogic = IAgeGroupsLogic;
            _IBranchLogic = iBranchLogic;
            AddMember = new MemberView();
            _MembersLogic = MembersLogic;
        }
        public async Task OnGet()
        {
            GetAllStatuses = await _IStatusesLogic.GetStatusAsync();
            GetAllAgeGroups= await _IAgeGroupsLogic.GetAllAgeGroupsAsync();
            GetAllBranches = await _IBranchLogic.GetBranchesAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (AddMember!=null) 
            {
                var model = ObjectMapper.Mapper.Map<MemberView>(AddMember);

                await _MembersLogic.AddBranchMemberAsync(model);
                Redirect("Member/AddMember");
            } 
            await OnGet();
            return Page();
        } 

    }
}
