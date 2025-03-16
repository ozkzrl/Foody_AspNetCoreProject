using Foody.EntityLayer.Concrete;

public class EfProductDal : GenericRepository<Product>, IProductDal
{
    public EfProductDal(FoodyContext context) : base(context)
    {

        
    }
}
