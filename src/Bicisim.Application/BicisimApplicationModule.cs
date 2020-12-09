using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Bicisim.Authorization;

namespace Bicisim
{
    [DependsOn(
        typeof(BicisimCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BicisimApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BicisimAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BicisimApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
