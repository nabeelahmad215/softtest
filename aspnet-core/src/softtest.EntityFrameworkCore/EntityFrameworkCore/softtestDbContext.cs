using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using softtest.Authorization.Roles;
using softtest.Authorization.Users;
using softtest.MultiTenancy;

namespace softtest.EntityFrameworkCore
{
    public class softtestDbContext : AbpZeroDbContext<Tenant, Role, User, softtestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public softtestDbContext(DbContextOptions<softtestDbContext> options)
            : base(options)
        {
        }
    }
}
