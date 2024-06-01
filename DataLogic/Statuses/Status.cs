using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Statuses
{
   
    public class Status
    {
        [Key]
        public Guid StatusID { get; set; }
        public string StatusName { get; set; }
    }
}
