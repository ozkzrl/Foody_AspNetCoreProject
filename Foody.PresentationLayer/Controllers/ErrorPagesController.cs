using Microsoft.AspNetCore.Mvc;

public class ErrorPagesController : Controller
{
    public IActionResult ErrorPage404()
    {
        return View();
    }
}