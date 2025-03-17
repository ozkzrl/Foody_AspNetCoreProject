using Foody.EntityLayer.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal CategoryDal)
    {
        _categoryDal=CategoryDal;
    }

    
    public void Add(Category entity)
    {
        _categoryDal.Add(entity);
    }

    public void Delete(int id)
    {
        _categoryDal.Delete(id);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category GetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    public void Update(Category entity)
    {
        _categoryDal.Update(entity);
    }
}