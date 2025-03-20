using Microsoft.AspNetCore.Mvc;

public class _HeadLayoutComponrntPartial:ViewComponent
{

    public IViewComponentResult Invoke()
    {
        return View();
    }

}