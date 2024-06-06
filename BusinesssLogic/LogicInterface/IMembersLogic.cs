using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Members;

namespace BusinesssLogic.LogicInterface
{
    public interface IMembersLogic
    {
        Task<List<MemberProfileView>> AllMemberDetails();
        Task AddBranchMemberAsync(MemberView member);
        Task<MemberProfileView> MemberDetailsByID(Guid MemberID);
        Task<List<MemberProfileView>> GetProfileDetailsAsync(string Username);
    }
}
 