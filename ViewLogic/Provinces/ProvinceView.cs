using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Countries;

namespace ViewLogic.Provinces
{
    public class ProvinceView
    {
        public Guid? ProvinceID { get; set; }
        public string? ProvinceName { get; set; } = default!;
        public Guid CountyID { get; set; }
        public virtual CountryView? Country { get; set; }
    }
}
