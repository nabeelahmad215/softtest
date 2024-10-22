using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace softtest.EntityFrameworkCore
{
    public static class softtestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<softtestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<softtestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
