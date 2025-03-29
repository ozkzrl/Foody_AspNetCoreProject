using Foody.EntityLayer.Concrete;

public interface IProductService : IGenericService<Product>
{

    List<Product> TProductListWithCategory();
}