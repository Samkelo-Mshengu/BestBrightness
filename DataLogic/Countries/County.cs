using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Countries
{
  
    public class County
    {
        [Key]
        public Guid CountyID { get; set; }
        public string CountyName { get; set; } = default!;
    }
}
