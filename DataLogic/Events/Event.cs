using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Events
{
    [Keyless]
    public class Event
    {
        public Guid EventID { get; set; }
        public string EventType { get; set; }
        public string EventDescription { get; set; }
        public Guid? MemberID { get; set; }
        public Guid? BranchID { get; set; }
    }
}
