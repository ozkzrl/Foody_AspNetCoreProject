using Foody.EntityLayer.Concrete;

public class EfReviewDal : GenericRepository<Review>, IReviewDal
{
    public EfReviewDal(FoodyContext context) : base(context)
    {

        
    }
}