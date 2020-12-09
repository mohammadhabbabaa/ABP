using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Bicisim.EntityFrameworkCore
{
    public static class BicisimDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BicisimDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BicisimDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
