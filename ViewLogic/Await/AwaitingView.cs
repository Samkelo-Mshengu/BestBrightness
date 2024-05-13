using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLogic.Await
{
    public class AwaitingView
    {
        public Guid AwaitingID { get; set; }
        public string AwaitStatus { get; set; }
        public string MemberName { get; set; }
        public string BranchName { get; set; }
    }
}
