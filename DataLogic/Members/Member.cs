using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Members
{
    public class MemberModel
    {
        public Guid MemberID { get; set; }
        public string Address { get; set; }
        public DateTime? JoiningDate { get; set; }
        public Guid? UserID { get; set; }
        public Guid? StatusID { get; set; }
        public Guid? AgeGroupID { get; set; }
        public Guid? BranchID { get; set; }
    }
}
