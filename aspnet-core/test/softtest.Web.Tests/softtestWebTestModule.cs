using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using softtest.EntityFrameworkCore;
using softtest.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace softtest.Web.Tests
{
    [DependsOn(
        typeof(softtestWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class softtestWebTestModule : AbpModule
    {
        public softtestWebTestModule(softtestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(softtestWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(softtestWebMvcModule).Assembly);
        }
    }
}