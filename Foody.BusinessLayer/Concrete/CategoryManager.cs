using Foody.EntityLayer.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal CategoryDal)
    {
        _categoryDal=CategoryDal;
    }

    
    public void TAdd(Category entity)
    {
        _categoryDal.Add(entity);
    }

    public void TDelete(int id)
    {
        _categoryDal.Delete(id);
    }

    public List<Category> TGetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category TGetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    public void TUpdate(Category entity)
    {
        _categoryDal.Update(entity);
    }
}