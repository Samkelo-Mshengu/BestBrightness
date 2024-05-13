using DataLogic.Settings;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterfaces
{
    public interface iSettingsRepository : iGenericRepository<Settings>
    {
        Task<Settings?> GetSettingByKeyAsync(string key);
    }
}
