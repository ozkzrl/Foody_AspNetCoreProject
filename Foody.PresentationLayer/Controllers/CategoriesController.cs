
using System.Security.Cryptography.X509Certificates;
using Foody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class CategoriesController : Controller
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;

    }

    public IActionResult CategoryList()
    {
        var values = _categoryService.TGetAll();
        return View(values);
    }

    [HttpGet]
    public IActionResult CreateCategory()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateCategory(Category category)
    {
        if (ModelState.IsValid)
        {
            // Kategori oluşturma işlemi
            _categoryService.TAdd(category);
            return RedirectToAction("CreateCategory"); // Başka bir sayfaya yönlendirebilirsiniz.
        }
        return View(category); // Eğer model geçerli değilse tekrar aynı sayfayı render et.
    }

    public IActionResult DeleteCategory(int id)
    {
        _categoryService.TDelete(id);
        return RedirectToAction("CategoryList");
    }

    [HttpGet]
    public IActionResult UpdateCategory(int id)
    {
        var value = _categoryService.TGetById(id);
        return View(value);
    }

    [HttpPost]
    public IActionResult UpdateCategory(Category category)
    {

        if (ModelState.IsValid)
        {
            var existingCategory = _categoryService.TGetById(category.CategoryId); // ID'ye göre kaydı getir
            if (existingCategory != null)
            {
                existingCategory.CategoryName = category.CategoryName; // Kategori adını güncelle
                _categoryService.TUpdate(existingCategory); // Güncelleme işlemini gerçekleştir
            }
            return RedirectToAction("CategoryList");
        }
        return View(category); // Model geçersizse tekrar formu göster
    }
}