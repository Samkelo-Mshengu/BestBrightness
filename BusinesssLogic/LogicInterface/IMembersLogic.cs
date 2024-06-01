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
        Task AddBranchMemberAsync(MemberView member);
    }
}
