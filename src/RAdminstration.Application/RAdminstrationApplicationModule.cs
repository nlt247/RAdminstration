using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RAdminstration.Authorization;

namespace RAdminstration
{
    [DependsOn(
        typeof(RAdminstrationCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RAdminstrationApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<RAdminstrationAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RAdminstrationApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
