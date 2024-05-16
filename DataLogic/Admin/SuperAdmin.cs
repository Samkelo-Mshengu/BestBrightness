using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Admin
{
    [Keyless]
    public class SuperAdmin
    {
        
        public Guid AdminID { get; set; }
        public Guid? UserID { get; set; }
    }
}
