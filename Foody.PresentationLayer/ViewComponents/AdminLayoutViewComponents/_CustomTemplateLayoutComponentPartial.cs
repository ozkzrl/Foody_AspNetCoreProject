using Microsoft.AspNetCore.Mvc;

public class _CustomLayoutComponentPartial:ViewComponent
{
        public IViewComponentResult Invoke()
    {
        return View();
    }
}