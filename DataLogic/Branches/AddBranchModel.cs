using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Branches
{
    [Keyless]
    public class AddBranchModel
    {
        public Guid BranchID { get; set; }
        public string BranchName { get; set; } = default!;
        public string BranchLocation { get; set; } = default!;
        public Guid ProvinceID { get; set; }
        public virtual Provinces.Province Provinces { get; set; } = default!;
    }
}
