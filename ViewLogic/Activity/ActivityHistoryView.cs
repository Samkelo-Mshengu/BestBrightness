using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLogic.Activity
{
    public class ActivityHistoryView
    {
        public Guid ActivityID { get; set; }
        public string MemberName { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string ActivityType { get; set; }
        public string Details { get; set; }
    }
}
