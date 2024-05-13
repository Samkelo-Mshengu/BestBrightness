using AutoMapper.Internal.Mappers;
using BusinesssLogic.LogicInterface;
using BusinesssLogic.Mappings;
using Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic.Settings;

namespace BusinesssLogic.SettingLogic
{
    public class SettingsLogic : ISettingsLogic
    {
        private readonly iSettingsRepository _settingsRepository;

        public SettingsLogic(iSettingsRepository iSettingsRepository)
        {
            _settingsRepository = iSettingsRepository;
        }

        public async Task<SettingsView?> GetSettingByKeyAsync(string key)
        {
            var settingDbModel = await _settingsRepository.GetSettingByKeyAsync(key);
            return ObjectMapper.Mapper.Map<SettingsView>(settingDbModel);
        }
    }
}
