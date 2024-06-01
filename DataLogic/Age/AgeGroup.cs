using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Age
{
    
    public class AgeGroup
    {
        [Key]
        public Guid AgeGroupID { get; set; }
        public string AgeGroupName { get; set; } = default!;
      
    }
}
