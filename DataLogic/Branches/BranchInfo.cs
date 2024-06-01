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
        public string BranchName { get; set; } = string.Empty;
        public string BranchLocation { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ProvinceName { get; set; } = string.Empty;
        public string CountyName { get; set; } = string.Empty;
    }
}
