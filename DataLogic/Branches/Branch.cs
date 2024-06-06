using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.User;

namespace DataLogic.Branches
{
 
    public class Branch
    {
        [Key]
        public Guid? BranchID { get; set; }
        public string? BranchName { get; set; } = default!;
        public string? BranchLocation { get; set; } = default!;
        [ForeignKey("ProvinceID")]
        public Guid? ProvinceID { get; set; }
        public Guid? CityID { get; set; }
        public virtual Provinces.Province? Province { get; set; } = default!;
    }
}
