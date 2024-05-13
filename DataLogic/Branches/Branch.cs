using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Branches
{
    public class Branch
    {
        public Guid BranchID { get; set; }
        public string BranchName { get; set; }
        public string BranchLocation { get; set; }
        public Guid ProvinceID { get; set; }
    }
}
