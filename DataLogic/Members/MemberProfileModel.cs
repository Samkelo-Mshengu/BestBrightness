using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Members
{
    [Keyless]
    public class MemberProfileModel
    {
        //Member properties
        public Guid MemberID { get; set; }
        public DateTime JoiningDate { get; set; } = default!;
        public string Address { get; set; } = default!;

        // User properties
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Username { get; set; } = default!;
        public char? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; } = default!;

        // Status properties
        public Guid StatusID { get; set; }
        public string StatusName { get; set; } = default!;

        // Age properties
        public Guid AgeGroupID { get; set; }
        public string AgeGroupName { get; set; } = default!;

        // Branch properties
        public Guid BranchID { get; set; }
        public string BranchName { get; set; } = default!;
    }
}
