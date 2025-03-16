using Foody.EntityLayer.Concrete;

public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
{
    public EfCategoryDal(FoodyContext context) : base(context)
    {

        
    }
}