

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

public class ProductsController : Controller
{


    private readonly IProductService _productservice;

    public ProductsController(IProductService productService)
    {
        _productservice=productService;
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


}