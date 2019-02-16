using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Abp.BG.Configuration;
using Abp.BG.Web;

namespace Abp.BG.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BGDbContextFactory : IDesignTimeDbContextFactory<BGDbContext>
    {
        public BGDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BGDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BGDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BGConsts.ConnectionStringName));

            return new BGDbContext(builder.Options);
        }
    }
}
