using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Countries;
using ViewLogic.Provinces;

namespace ViewLogic.Branch
{
    public class GetAllBranches
    {
        public BranchView? BranchView { get; set; } = default!;
        public ProvinceView? ProvinceView { get; set; } = default!;
        public  CountryView? CountryView { get; set; } = default!;
    }
}
