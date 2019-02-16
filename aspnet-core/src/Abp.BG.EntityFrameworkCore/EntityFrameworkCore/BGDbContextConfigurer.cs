using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Abp.BG.EntityFrameworkCore
{
    public static class BGDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BGDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BGDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
