using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Settings
{
    public class Settings
    {
        [Key]
        public Guid Id { get; set; }
        public string Key { get; set; } = default!;
        public string Value { get; set; } = default!;
        public string Description { get; set; } = default!;
        public bool IsActive { get; set; }
    }
}
