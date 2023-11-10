using Microsoft.AspNetCore.Mvc;

namespace DibaStore.Web.ViewComponents
{
    public class SiteFooterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View("SiteFooter"));
        }
    }
}
