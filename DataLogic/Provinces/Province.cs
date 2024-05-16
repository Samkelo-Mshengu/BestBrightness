using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Provinces
{
    [Keyless]
    public class Province
    {
        public Guid ProvinceID { get; set; }
        public string ProvinceName { get; set; }
        public string City { get; set; }
        public Guid? CountyID { get; set; }
    }
}
