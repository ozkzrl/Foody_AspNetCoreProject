using Microsoft.AspNetCore.Mvc;

public class _FooterLayoutComponentPartial:ViewComponent
{
        public IViewComponentResult Invoke()
    {
        return View();
    }
}