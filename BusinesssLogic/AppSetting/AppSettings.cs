using BusinesssLogic.LogicInterface;
using BusinesssLogic.SettingLogic;
using DataLogic;
using Microsoft.Extensions.Configuration;
using Repository.RepositoryInterfaces;
using Repository.SettingsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesssLogic.AppSetting
{
    public static class AppSettings
    {
        private static readonly IConfigurationRoot Configuration = GetCurrentSettings();
        private static readonly Dictionary<string, string> ConfigSettings = new();
        private static readonly ISettingsLogic _settingsLogic;

        static AppSettings()
        {
            iSettingsRepository _iSettingsRepository = new SettingsRepository(new DefaultContext());
            _settingsLogic = new SettingsLogic(_iSettingsRepository);
        }

        //public static string ConnectionString =
        //	Environment.GetEnvironmentVariable("DOIConnectionString");

        public static readonly string EnvironmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Development";
        public static string ClientId = Settings("AppSettings", "ClientId");
        public static string BaseUrl = Settings("AppSettings", "BaseUrl");
        public static string azureBlobUri = Settings("AppSettings", "AzureBlobUri");


        public static readonly string ConnectionString = Environment.GetEnvironmentVariable("InqolaConnectionString") ?? string.Empty;

        public static string Settings(string parent, string key)
        {
            ConfigSettings.TryGetValue(key, out var setting);
            return setting ?? GetKeyFromAppSettingJson(parent, key);
        }

        private static string GetKeyFromAppSettingJson(string parent, string key)
        {
            var value = Configuration.GetSection(parent).GetValue<string>(key) ?? string.Empty;
            ConfigSettings.TryAdd(key, value);
            return value;
        }

        private static IConfigurationRoot GetCurrentSettings()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json",
                    optional: false,
                    reloadOnChange: true)
                .AddEnvironmentVariables();

            return builder.Build();
        }

        public static string GetJWTTokenKey()
        {
            var secret = Environment.GetEnvironmentVariable("JWTTokenKey");
            if (string.IsNullOrEmpty(secret))
            {
                throw new Exception("Cannot read the JWTToken key !");
            }
            return secret;
        }
    }
}
