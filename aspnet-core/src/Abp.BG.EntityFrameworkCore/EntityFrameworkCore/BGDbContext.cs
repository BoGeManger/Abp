using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Abp.BG.Authorization.Roles;
using Abp.BG.Authorization.Users;
using Abp.BG.MultiTenancy;
using Abp.BG.Entities;
namespace Abp.BG.EntityFrameworkCore
{
    public class BGDbContext : AbpZeroDbContext<Tenant, Role, User, BGDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BGDbContext(DbContextOptions<BGDbContext> options)
            : base(options)
        {
        }

        public DbSet<PdBrand> PdBrand { get; set; }
    }
}
