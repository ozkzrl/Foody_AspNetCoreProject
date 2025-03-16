using Foody.EntityLayer.Concrete;

public class EfSocialmedia : GenericRepository<SocialMedia>, ISocialMediaDal
{
    public EfSocialmedia(FoodyContext context) : base(context)
    {


        
    }
}