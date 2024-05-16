using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Statuses
{
    [Keyless]
    public class Status
    {
        public Guid StatusID { get; set; }
        public string StatusName { get; set; }
    }
}
