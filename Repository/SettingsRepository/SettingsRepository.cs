using DataLogic.Settings;
using DataLogic;
using Repository.GenericRepository;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repository.SettingsRepository
{
    public class SettingsRepository : GenericRepository<Settings>, iSettingsRepository
    {
        private DefaultContext _context;

        public SettingsRepository(DefaultContext dataContext) : base(dataContext)
        {
            _context = dataContext;
        }

        public async Task<Settings?> GetSettingByKeyAsync(string key)
        {
            return await _context.Set<Settings>().SingleOrDefaultAsync(s => s.Key == key);
        }
    }
}
