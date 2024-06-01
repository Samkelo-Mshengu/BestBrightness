using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Age;
using ViewLogic.Branch;
using ViewLogic.Statuses;
using ViewLogic.User;

namespace ViewLogic.Members
{
    public class MemberView
    {
        public Guid MemberID { get; set; }
        public string Address { get; set; } = default!;
        public DateTime? JoiningDate { get; set; }
        public Guid? UserID { get; set; }
        public virtual UserView User { get; set; } = default!;
        public Guid? StatusID { get; set; }
        public virtual StatusView Status { get; set; } = default!;
        public Guid? AgeGroupID { get; set; }
        public virtual AgeGroupView Age { get; set; } = default!;
        public Guid? BranchID { get; set; }
        public virtual BranchView Branch { get; set; } = default!;
    }
}
