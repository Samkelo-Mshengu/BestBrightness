using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLogic.Statuses
{
    public class StatusView
    {
        public Guid StatusID { get; set; }
        public string StatusName { get; set; } = default!;
    }
}
