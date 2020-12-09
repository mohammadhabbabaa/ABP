using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Bicisim.Authorization.Roles;
using Bicisim.Authorization.Users;
using Bicisim.MultiTenancy;
using Bicisim.Tasks;

namespace Bicisim.EntityFrameworkCore
{
    public class BicisimDbContext : AbpZeroDbContext<Tenant, Role, User, BicisimDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Task> Tasks { get; set; }
        public BicisimDbContext(DbContextOptions<BicisimDbContext> options)
            : base(options)
        {
        }
    }
}
