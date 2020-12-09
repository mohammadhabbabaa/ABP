using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Bicisim.EntityFrameworkCore;
using Bicisim.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Bicisim.Web.Tests
{
    [DependsOn(
        typeof(BicisimWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BicisimWebTestModule : AbpModule
    {
        public BicisimWebTestModule(BicisimEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BicisimWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BicisimWebMvcModule).Assembly);
        }
    }
}