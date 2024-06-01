using BusinesssLogic.LogicInterface;
using BusinesssLogic.Mappings;
using DataLogic.Branches;
using DataLogic.Members;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Branch;
using ViewLogic.Members;

namespace BusinesssLogic.MembersLogic
{
    public class MemberLogic:IMembersLogic
    {
        private readonly iMember _member;
        public MemberLogic(iMember member)
        {
            _member = member;
        }

        public async Task AddBranchMemberAsync(MemberView member)
        {
            var memberModel = ObjectMapper.Mapper.Map<MemberView, MemberModel>(member);

            

            memberModel.Address = member.Address;
            memberModel.JoiningDate = member.JoiningDate;
            memberModel.User.FirstName = member.User.FirstName;
            memberModel.User.LastName = member.User.LastName;
            memberModel.User.Gender = member.User.Gender;
            memberModel.User.DateOfBirth = member.User.DateOfBirth;
            memberModel.User.ContactNumber = member.User.ContactNumber;
            memberModel.User.Username = member.User.Username;
            memberModel.StatusID = member.StatusID;
            memberModel.AgeGroupID = member.AgeGroupID;
            memberModel.BranchID = member.BranchID;

            await _member.AddNewMemberAsync(memberModel);
        }

    }
}
