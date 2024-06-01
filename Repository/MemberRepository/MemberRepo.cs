using DataLogic.Branches;
using DataLogic;
using Repository.GenericRepository;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLogic.Members;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Repository.MemberRepository
{
    public class MemberRepo : GenericRepository<MemberModel>, iMember
    {
        private readonly DefaultContext _context;

        public MemberRepo(DefaultContext context) : base(context)
        {
            _context = context;
        }
        public async Task AddNewMemberAsync(MemberModel member)
        {
            object[] parameters =
            {
              new SqlParameter("@FirstName",member.User.FirstName.ToUpper()),
              new SqlParameter("@LastName",member.User.LastName.ToUpper()),
              new SqlParameter("@Username",member.User.Username),
              new SqlParameter("@Gender",member.User.Gender),
              new SqlParameter("@DateOfBirth",member.User.DateOfBirth),
              new SqlParameter("@ContactNumber",member.User.ContactNumber),
              new SqlParameter("@Address",member.Address),
              new SqlParameter("@JoiningDate",member.JoiningDate),
              new SqlParameter("@StatusID",member.StatusID),
              new SqlParameter("@AgeGroupID",member.AgeGroupID),
              new SqlParameter("@BranchID",member.BranchID)
            };

            var query = "EXEC [AddBranchMember] @FirstName,@LastName,@Username,@Gender,@DateOfBirth,@ContactNumber,@Address,@JoiningDate,@StatusID,@AgeGroupID,@BranchID";
            await _context.Database.ExecuteSqlRawAsync(query, parameters);
        }

    }
}
