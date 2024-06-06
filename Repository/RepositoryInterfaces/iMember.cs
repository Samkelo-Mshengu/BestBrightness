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
        Task<List<MemberProfileModel>> GetAllMembers(CancellationToken token = default);
        Task<MemberProfileModel> GetAllMemberById(Guid MemberID, CancellationToken token = default);
        Task<List<MemberProfileModel>> GetProfileDetails(string Username, CancellationToken token = default);
    }
}
