using Microsoft.AspNetCore.Mvc;

namespace Foody.ViewComponents
{
    [ViewComponent]
    public class _FooterLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); // View'in adını buraya yazabilirsiniz, ya da bir model ile de dönebilirsiniz
        }
    }
}
