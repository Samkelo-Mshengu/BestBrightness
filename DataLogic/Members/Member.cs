using DataLogic.Age;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Members
{

    public class MemberModel
    {
        [Key]
        public Guid MemberID { get; set; }
        public string Address { get; set; } = default!;
        public DateTime? JoiningDate { get; set; }
        [ForeignKey("UserId")]
        public Guid? UserID { get; set; }
        public virtual Users.User User { get; set; } = default!;
        [ForeignKey("StatusID")]
        public Guid? StatusID { get; set; }
        public virtual Statuses.Status Status { get; set; } = default!;
        [ForeignKey("AgeGroupID")]
        public Guid? AgeGroupID { get; set; }
        public virtual AgeGroup Age { get; set; } = default!;
        [ForeignKey("BranchID")]
        public Guid? BranchID { get; set; }
        public virtual Branches.Branch Branch { get; set; } = default!;
    }
}
