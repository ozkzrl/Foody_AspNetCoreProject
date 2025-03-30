

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

public class ProductsController : Controller
{


    private readonly IProductService _productservice;
    private readonly ICategoryService _categoryservice;
    public ProductsController(IProductService productService, ICategoryService categoryService)
    {
        _productservice=productService;
        _categoryservice = categoryService;
    }
    public IActionResult ProductList()
    {
        var values =_productservice.TGetAll();
        return View(values);
    }

    public IActionResult ProductListWithCategory()
    {
        
        var values=_productservice.TProductListWithCategory();
        return View(values);
    }

    public IActionResult DeleteProduct(int id)
    {

        _productservice.TDelete(id);
        return RedirectToAction("ProductListWithCategory");
    }

    [HttpGet]
    public IActionResult CreateProduct()
    {
        var values= _categoryservice.TGetAll();
        ViewBag.categories= new SelectList(values, "CategoryId", "CategoryName");
        return View();

    }

    [HttpPost]
    public IActionResult CreateProduct(Product product)
    {
        _productservice.TAdd(product);
        return RedirectToAction("ProductListWithCategory");

    }

}