using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Bicisim.Web.Views
{
    public abstract class BicisimRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected BicisimRazorPage()
        {
            LocalizationSourceName = BicisimConsts.LocalizationSourceName;
        }
    }
}
