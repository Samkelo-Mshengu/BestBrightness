﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Countries
{
    [Keyless]
    public class County
    {
        public Guid CountyID { get; set; }
        public string CountyName { get; set; }
    }
}
