using DataLogic.Countries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Provinces
{
    
    public class Province
    {
        [Key]
        public Guid ProvinceID { get; set; }
        public string ProvinceName { get; set; } = default!;
        public string City { get; set; } = default!;
        [ForeignKey("CountyID")]
        public Guid? CountyID { get; set; }

        public virtual County County { get; set; } = default!;
    }
}
