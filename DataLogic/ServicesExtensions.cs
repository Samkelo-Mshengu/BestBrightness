using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
    public static class ServicesExtensions
    {
        public static string? InqolaConnectionString { get; set; }
        public static void InqolaConnectionStringService(this IServiceCollection services, string connectionString)
        {
            InqolaConnectionString = connectionString;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString)
            {
                ColumnEncryptionSetting = SqlConnectionColumnEncryptionSetting.Enabled
            };
            InqolaConnectionString = builder.ConnectionString;
        }
    }
}
