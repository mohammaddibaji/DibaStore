using Microsoft.AspNetCore.Mvc;

namespace DibaStore.Web.ViewComponents
{
    public class SiteHeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View("SiteHeader"));
        }
    }
}
