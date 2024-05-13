using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Activity
{
    public class ActivityHistory
    {
        public Guid ActivityID { get; set; }
        public Guid? MemberID { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string ActivityType { get; set; }
        public string Details { get; set; }
    }
}
