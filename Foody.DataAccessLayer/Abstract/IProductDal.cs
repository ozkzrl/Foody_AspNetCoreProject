using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

public interface IProductDal:IGenericDal<Product>
{
 List<Product> ProductListWithCategory();


}