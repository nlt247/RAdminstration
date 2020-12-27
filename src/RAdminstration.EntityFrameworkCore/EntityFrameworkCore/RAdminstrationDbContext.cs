using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RAdminstration.Authorization.Roles;
using RAdminstration.Authorization.Users;
using RAdminstration.MultiTenancy;
using RAdminstration.PhoneBooks.Persons;
using RAdminstration.PhoneBooks.PhoneNumbers;

namespace RAdminstration.EntityFrameworkCore
{
    public class RAdminstrationDbContext : AbpZeroDbContext<Tenant, Role, User, RAdminstrationDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public RAdminstrationDbContext(DbContextOptions<RAdminstrationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person","PB");
            modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
            base.OnModelCreating(modelBuilder);
        }
    }
}
