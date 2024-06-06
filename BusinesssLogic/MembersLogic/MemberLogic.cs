using AutoMapper.Execution;
using BusinesssLogic.LogicInterface;
using BusinesssLogic.Mappings;
using DataLogic.Branches;
using DataLogic.Members;
using DataLogic.Provinces;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Branch;
using ViewLogic.Members;
using ViewLogic.Provinces;

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

        private static MemberView? MemberByIdAsync(MemberModel? member)

        {

            var mappedMember = member != null ? ObjectMapper.Mapper.Map<MemberModel, MemberView>(member) : null;
            if ((mappedMember != null) && (member?.Branch != null) && (member?.User != null))
            {
                mappedMember.MemberID = member.MemberID;
                mappedMember.User.FirstName = member.User.FirstName;
                mappedMember.User.LastName = member.User.LastName;
                mappedMember.User.Username = member.User.Username;
                mappedMember.User.Gender = member.User.Gender;
                mappedMember.User.DateOfBirth = member.User.DateOfBirth;
                mappedMember.User.ContactNumber = member.User.ContactNumber;
                mappedMember.Status.StatusID= member.Status.StatusID;
                mappedMember.Status.StatusName = member.Status.StatusName;
                mappedMember.Age.AgeGroupID = member.Age.AgeGroupID;
                mappedMember.Age.AgeGroupName = member.Age.AgeGroupName;
                mappedMember.BranchID = member.BranchID;
                mappedMember.Branch.BranchName = member.Branch.BranchName;
         
            }
            return mappedMember;
        }
        public async Task<List<MemberProfileView>> AllMemberDetails()
        {
            var MemberInfor = await _member.GetAllMembers();
            var model = ObjectMapper.Mapper.Map<List<MemberProfileModel>, List<MemberProfileView>>(MemberInfor.ToList());

            return model;

        }

        public async Task<MemberProfileView> MemberDetailsByID(Guid MemberID)
        {
            var MemberInfor = await _member.GetAllMemberById(MemberID);
            var model = ObjectMapper.Mapper.Map<MemberProfileModel, MemberProfileView>(MemberInfor);

            return model;

        }

        public async Task<List<MemberProfileView>> GetProfileDetailsAsync(string Username) 
        {
            var profile = await _member.GetProfileDetails(Username);
            var model = ObjectMapper.Mapper.Map<List<MemberProfileModel>, List<MemberProfileView>>(profile.ToList());

            return model;

        }

    }
}
