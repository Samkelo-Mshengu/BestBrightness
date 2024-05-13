using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Settings;

namespace BusinesssLogic.LogicInterface
{
    public interface ISettingsLogic
    {
        Task<SettingsView?> GetSettingByKeyAsync(string key);
    }
}
