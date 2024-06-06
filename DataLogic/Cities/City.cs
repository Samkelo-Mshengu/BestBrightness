using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Cities
{
    [Keyless]
    public class City
    {
        public Guid? CityID { get; set; } = Guid.Empty;
        public Guid? ProvinceID { get; set; } = Guid.Empty;
        public string? CityName { get; set; } = string.Empty;
    }
}
