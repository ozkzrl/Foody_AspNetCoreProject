using Microsoft.AspNetCore.Mvc;

public class _HeadLayoutComponentPartial:ViewComponent
{

    public IViewComponentResult Invoke()
    {
        return View();
    }

}