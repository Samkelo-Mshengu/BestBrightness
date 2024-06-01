using DataLogic.Members;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterfaces
{
    public interface iMember:iGenericRepository<MemberModel>
    {
        Task AddNewMemberAsync(MemberModel member);
    }
}
