using Foody.EntityLayer.Concrete;

public class EfAboutDal : GenericRepository<About>, IAboutdal
{
    public EfAboutDal(FoodyContext context) : base(context)
    {

        
    }
}