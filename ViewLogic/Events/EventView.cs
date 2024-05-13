using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLogic.Events
{
    public class EventView
    {
        public Guid EventID { get; set; }
        public string EventType { get; set; }
        public string EventDescription { get; set; }
        public string MemberName { get; set; }
        public string BranchName { get; set; }
    }
}
