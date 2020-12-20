using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RAdminstration.EntityFrameworkCore;
using RAdminstration.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace RAdminstration.Web.Tests
{
    [DependsOn(
        typeof(RAdminstrationWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class RAdminstrationWebTestModule : AbpModule
    {
        public RAdminstrationWebTestModule(RAdminstrationEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RAdminstrationWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(RAdminstrationWebMvcModule).Assembly);
        }
    }
}