using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Branches
{
    [Keyless]
    public class BranchInfo
    {
        public Guid? BranchID { get; set; } = Guid.Empty;
        public string? BranchName { get; set; } = null;
        public string? BranchLocation { get; set; } = null;
        public string? City { get; set; } = null;
        public string? ProvinceName { get; set; } = null;
        public string? CountyName { get; set; } = null;

    }
}
