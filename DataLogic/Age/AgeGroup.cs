using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Age
{
    public class AgeGroup
    {
        public Guid AgeGroupID { get; set; }
        public string AgeGroupName { get; set; }
        public int? Age { get; set; }
    }
}
