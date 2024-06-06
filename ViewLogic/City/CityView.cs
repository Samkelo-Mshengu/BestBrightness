using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLogic.City
{
    public class CityView
    {
        public Guid? CityID { get; set; } = Guid.Empty;
        public Guid? ProvinceID {  get; set; } = Guid.Empty;
        public string? CityName { get; set; } = string.Empty;
    }
}
