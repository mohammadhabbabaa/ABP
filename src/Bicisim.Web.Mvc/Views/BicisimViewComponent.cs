using Abp.AspNetCore.Mvc.ViewComponents;

namespace Bicisim.Web.Views
{
    public abstract class BicisimViewComponent : AbpViewComponent
    {
        protected BicisimViewComponent()
        {
            LocalizationSourceName = BicisimConsts.LocalizationSourceName;
        }
    }
}
