using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RAdminstration.EntityFrameworkCore
{
    public static class RAdminstrationDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RAdminstrationDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RAdminstrationDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
