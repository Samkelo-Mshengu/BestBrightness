using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLogic.Await
{
    public class AwaitingViewModel
    {
        public Guid AwaitingID { get; set; }
        public string AwaitStatus { get; set; } = default!;
        public Guid MemberID { get; set; }
        public Guid BranchID { get; set; }
        public Guid UserID { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Username { get; set; } = default!;
        public char? Gender { get; set; }
        public string ContactNumber { get; set; } = default!;
        public string StatusName { get; set; } = default!;
    }
}
