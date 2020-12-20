using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RAdminstration.Authorization.Roles;
using RAdminstration.Authorization.Users;
using RAdminstration.MultiTenancy;

namespace RAdminstration.EntityFrameworkCore
{
    public class RAdminstrationDbContext : AbpZeroDbContext<Tenant, Role, User, RAdminstrationDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public RAdminstrationDbContext(DbContextOptions<RAdminstrationDbContext> options)
            : base(options)
        {
        }
    }
}
