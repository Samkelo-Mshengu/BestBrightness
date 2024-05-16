using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Await
{
    [Keyless]
    public class Awaiting
    {
        public Guid AwaitingID { get; set; }
        public string AwaitStatus { get; set; }
        public Guid? MemberID { get; set; }
        public Guid? BranchID { get; set; }
    }
}
