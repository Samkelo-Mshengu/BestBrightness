using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Countries;
using ViewLogic.Provinces;

namespace ViewLogic.Branch
{
    public class AddBranchView
    {
        public BranchView? branch {  get; set; }    

        public ProvinceView? province { get; set; }
    }
}
