using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using softtest.Authorization;

namespace softtest
{
    [DependsOn(
        typeof(softtestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class softtestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<softtestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(softtestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
