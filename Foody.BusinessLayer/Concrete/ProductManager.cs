using Foody.EntityLayer.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal=productDal;
    }

    public void TAdd(Product entity)
    {
        _productDal.Add(entity);
    }

    public void TDelete(int id)
    {
        _productDal.Delete(id);
    }

    public List<Product> TGetAll()
    {
        return _productDal.GetAll();
    }

    public Product TGetById(int id)
    {
        return _productDal.GetById(id);
    }

    public void TUpdate(Product entity)
    {
        _productDal.Update(entity);
    }
}