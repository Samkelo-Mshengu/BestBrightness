using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Provinces;
using ViewLogic.User;

namespace ViewLogic.Branch
{
    public class BranchView
    {
        public Guid? BranchID { get; set; }
        public string? BranchName { get; set; } = default!;
        public string? BranchLocation { get; set; } = default!;
        public Guid? ProvinceID { get; set; }
        public Guid? CityID { get; set; }
        public virtual ProvinceView? Province { get; set; } = default!;
    }
}
