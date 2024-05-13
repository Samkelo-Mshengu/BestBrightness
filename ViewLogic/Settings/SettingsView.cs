using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLogic.Settings
{
    public class SettingsView
    {
        public Guid Id { get; set; }
        public string Key { get; set; } = default!;
        public string Value { get; set; } = default!;
        public string Description { get; set; } = default!;
        public bool IsActive { get; set; }
    }
}
