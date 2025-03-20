using Microsoft.AspNetCore.Mvc;

public class _SidebarLayoutComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}