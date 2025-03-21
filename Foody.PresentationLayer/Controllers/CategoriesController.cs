
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

public class CategoriesController : Controller
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService=categoryService;

    }
    public IActionResult CategoryList()
    {
        var values=_categoryService.TGetAll();
        return View(values);

    }

}