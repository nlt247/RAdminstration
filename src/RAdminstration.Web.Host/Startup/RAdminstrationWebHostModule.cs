using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RAdminstration.Configuration;

namespace RAdminstration.Web.Host.Startup
{
    [DependsOn(
       typeof(RAdminstrationWebCoreModule))]
    public class RAdminstrationWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public RAdminstrationWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RAdminstrationWebHostModule).GetAssembly());
        }
    }
}
